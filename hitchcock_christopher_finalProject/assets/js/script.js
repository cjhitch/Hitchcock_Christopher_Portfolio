///// Bootstrap is throwing a console error -- this isn't from my file /////////

(function(){

    var groceryCart = [];

    // base class for grocery item - includes name and cost for single item
    class GroceryItem {
        constructor(name, cost) {
            this._name = name;
            this._cost = cost;
            this._total = this.GetTotal(cost);
        }
        GetTotal(cost) {
            let total = cost;
            return total;
        }
        get Name() {
            return this._name;
        }
        get Total() {
            return this._total;
        }
        set Total(val){
            this._total = val;
        }
    }
    // child class for bulk items, extends base and adds in quantity or weight and total to calculate a total base on those two
    class BulkItem extends GroceryItem {
        constructor(name, cost, quantity) {
            super(name, cost);
            this._quantity = quantity;
            this._total = this.GetTotal(cost);
        }
        GetTotal(cost) {
            let total = cost * this._quantity;
            return total;
        }
        get Name() {
            return this._name;
        }
        get Total() {
            return this._total;
        }
        set Total(val){
            this._total = val;
        }
    }
    // index to iterate through when a new item is built
    let inputIndex = 0;
    // select the input area to append elements to
    const inputArea = document.querySelector('section.input-area');
    // arrays to be used for unique names in input and label creation
    const labelNames = ['Item Name', 'Item Cost (only #\'s ex. 12.34)', 'Weight/Quantity (only #\'s ex. 2.45)'];
    const labelFor = ['name', 'cost', 'quant'];
    const errorList = ['must be 2 characters or longer','must only be a number and at least 1 digit','must only be a number'];
    // function to run the new field creation
    function createNewField() {
        // get new item button
        const button = document.querySelector('button#newItem');
        button.setAttribute('disabled', 'true');
        button.classList.add('btn-outline-success');
        button.classList.remove('btn-success');
        // call article creation function
        createArticle();
        // make new event listeners for each field
        inputEventListener();
        // add event listener to the button
        totalButtonListener();
        // add observer on the articles children
        articleObserver();
    }
    // build and prepend the new article before the add new item button
    function createArticle(){
        // create element
        const articleArea = document.createElement('article');
        // set class attributes
        articleArea.setAttribute('class', 'col-md-4 col-sm-12');
        // set unique ID for entire article
        articleArea.setAttribute('id', 'item'+inputIndex);
        // prepend to section
        inputArea.prepend(articleArea);
        // call the div creation function
        createDiv(articleArea);
    }
    // build div and append to the article
    function createDiv(articleArea){
        // create new div element
        const div = document.createElement('div');
        // add class attributes
        div.setAttribute('class', 'col-sm-12');
        // append to the article
        articleArea.appendChild(div);
        // loop through 3 times and create 3 labels, and 3 inputs
        for (let i = 0; i < labelNames.length; i++) {
            createLabel(div, i); 
            createInput(div, i);
            createError(div, i);          
        }
        // create the total button
        createTotAndEditButtons(div);
        // call the create total function
        createTotalDiv(div);
    }
    // build label and append to the new div -- uses the i from the for loop to run through the arrays and give correct naming convention
    function createLabel(div, thisIndex){
        // create new label element
        const lab = document.createElement('label');
        // set class attributes for the label
        lab.setAttribute('class', 'text-center d-block mt-3');
        // set the for attribute to tell which input this label applies to
        lab.setAttribute('for', 'input-'+labelFor[thisIndex]);
        // set the text content of the label from the array values
        lab.textContent = labelNames[thisIndex];
        // append the label to the new div
        div.appendChild(lab);
        if (thisIndex == 2) {
            const span = document.createElement('span');
            span.setAttribute('class', 'span-red d-block');
            span.textContent = ' This may be left empty'
            lab.appendChild(span);
        }
    }

    // build input and append to the new div after the label - uses the i from the for loop to run through the arrays and give correct naming convention
    function createInput(div, thisIndex) {
        // create new input element
        const input = document.createElement('input');
        // set class attributes for the input
        input.setAttribute('class', 'w-100 input-'+labelFor[thisIndex])
        // checks for last input field -- will add success to field as this may be left blank
        if (input.classList.contains('input-quant')) {
            input.setAttribute('class', 'w-100 success input-'+labelFor[thisIndex])
        }
        // set type to text
        input.setAttribute('type', 'text');
        // append to the div under the newly created label
        div.appendChild(input);
    }

    // build errors for input fields
    function createError(div, thisIndex) {
        // create new error element
        const error = document.createElement('p');
        // set class attributes for the p tag
        error.setAttribute('class', 'error-text invisible');
        // set text for error field
        error.textContent = errorList[thisIndex];
        // append to the div under the newly created input
        div.appendChild(error);
    }

    function createTotAndEditButtons(div) {
        // new section for a row
        const section = document.createElement('section');
        // add class row
        section.setAttribute('class', 'row');
        // append section to the div
        div.appendChild(section);
        // create div for total
        const totalDiv = document.createElement('div');
        // add class to totalDiv
        totalDiv.setAttribute('class', 'col-md-6 col-sm-12')
        // append div to section
        section.appendChild(totalDiv);
        // create edit button div
        const editDiv = document.createElement('div');
        // add class to edit div
        editDiv.setAttribute('class', 'col-md-6 col-sm-12')
        // append to section
        section.appendChild(editDiv);
        // create button
        const editButton = document.createElement('button');
        editButton.setAttribute('class', 'edit-fields mx-auto mt-3 btn btn-outline-secondary');
        // set initial stat of button to disabled
        editButton.setAttribute('disabled', 'true');
        // set text content
        editButton.textContent = 'Edit Item';
        // I intend on continuing to build this with an edit button later
        // editDiv.appendChild(editButton)
        // create button
        const totButton = document.createElement('button');
        // add class to button
        totButton.setAttribute('class', 'calculate-total mx-auto mt-3 btn btn-outline-primary');
        // set initial state of button to be disabled
        totButton.setAttribute('disabled', 'true');
        // set text content
        totButton.textContent = 'Calculate Total';
        // append button to section
        totalDiv.appendChild(totButton);
    }

    function createTotalDiv(div) {
        // new section for a row
        const section = document.createElement('section');
        // add class row
        section.setAttribute('class', 'row mt-3');
        // new div for 5/12's
        const leftDiv = document.createElement('div');
        // set class for 5/12's
        leftDiv.setAttribute('class', 'col-sm-5 pr-0');
        // new div for 7/12's
        const rightDiv = document.createElement('div');
        // set class for 7/12's
        rightDiv.setAttribute('class', 'col-sm-7');
        // append section to div
        div.appendChild(section);
        // append div to section
        section.appendChild(leftDiv);
        // append div to section
        section.appendChild(rightDiv);
        // get return value from createSubTotal
        const subTotal = createSubTotal();
        // get return value from createTax        
        const tax = createTax();
        // get return value from createTax        
        const total = createTotal();
        // append h6 sub to the div
        leftDiv.appendChild(subTotal[0]);
        // append empty h6 to right div
        rightDiv.appendChild(subTotal[1])
        // append h6 tax to the div
        leftDiv.appendChild(tax[0]);
        // append empty h6 to right div
        rightDiv.appendChild(tax[1]);
        // append h5 to the div
        leftDiv.appendChild(total[0]);
        // append empty h5 to the div
        rightDiv.appendChild(total[1]);
    }

    function createSubTotal() {
        // create new h6 subtotal element
        const subTotal = document.createElement('h6');
        // create empty h6 that will hold the value
        const subTotalVal = document.createElement('h6');
        // set class for subtotal
        subTotal.setAttribute('class', 'text-right');
        // set class for subval
        subTotalVal.setAttribute('class', 'text-left sub-value');
        // text content for subtotal
        subTotal.textContent = 'Subtotal: $'
        // return value to be captured
        return [subTotal, subTotalVal];
    }

    function createTax() {
        // create new h6 tax element
        const tax = document.createElement('h6');
        // create empty h6 for tax value
        const taxVal = document.createElement('h6');
        // set class for tax
        tax.setAttribute('class', 'text-right');
        // set class for tax val
        taxVal.setAttribute('class', 'text-left tax-value')
        // text content for tax
        tax.textContent = 'Tax: $';
        // return value to be captured
        return [tax, taxVal];
    }

    function createTotal() {
        // create new h5 total element
        const total = document.createElement('h5');
        // create empty h5 for total value
        const totalVal = document.createElement('h5');
        // set class attributes for the h5
        total.setAttribute('class', 'mt-3 text-right');
        // set class for total val
        totalVal.setAttribute('class', 'mt-3 text-left total-value')
        // set text content for h5
        total.textContent = 'Total: $';
        // return value to be captured
        return [total, totalVal];
    }

    function runTotals() {
        // select the empty header tags to have text content added to them
        const sub = document.querySelector('#item'+inputIndex+ ' .sub-value')
        const tax = document.querySelector('#item'+inputIndex+ ' .tax-value')
        const total = document.querySelector('#item'+inputIndex+ ' .total-value')
        // set values and round to nearest hundreth
        const subVal = Math.round(100*groceryCart[inputIndex].Total)/100;
        const taxVal = Math.round(100*(subVal * .0825))/100;
        const totalVal = Math.round(100*(subVal + taxVal))/100;
        // reset the total of the object to now include tax
        groceryCart[inputIndex].Total = totalVal;

        sub.textContent = subVal;
        tax.textContent = taxVal;
        total.textContent = groceryCart[inputIndex].Total;

        entireCartTotal();
        
    }

    function entireCartTotal(){
        let total = 0;
        let hTotal = document.querySelector('div.cart-total h2');
        groceryCart.forEach(element => {
            total += element.Total;
        });
        hTotal.textContent = Math.round(100*total)/100;
    }
    
    function addNewListener() {
        // get new item button
        const button = document.querySelector('button#newItem');
        // call function to create a new item field once clicked
        button.addEventListener('click', function(){            
            // increment the index for use in the next new field creation
            inputIndex++;
            createNewField();
        })
    }

    function saveEventListener() {
        const button = document.querySelector('button#saveItems');
        button.addEventListener('click', function(){
            groceryCart.forEach(element => {
                localStorage.setItem(element.Name, JSON.stringify(element));
            });
            alert('Grocery Cart Saved to Local Storage!');
        })
    }

    // I intend on building this portion out at a later date to continue the project for my wife
    // function editButtonListener() {

    // }

    function totalButtonListener() {
        // get calculate total button
        const button = document.querySelector('button.calculate-total');
        // get edit item button -- I intend to continue building this out at a later date
        // const editBtn = document.querySelector('button.edit-fields');
        // new item button
        const newBtn = document.querySelector('button#newItem');
        // save button
        const saveBtn = document.querySelector('button#saveItems');
        // div for childnodes
        const div = document.querySelector('#item'+inputIndex+ ' div');
        // event listener for the calculate total button
        button.addEventListener('click', function(e){
            e.preventDefault();
            // declare each input value - needs to be inside the listener for when these change
            let input0 = div.childNodes[1].value;
            let input1 = div.childNodes[4].value;
            let input2 = div.childNodes[7].value;
            // check if the input value for weight/quantity is an empty string
            if (input2 == '') {
                // instantiate a new grocery item object
                const newGroc = new GroceryItem(input0, input1);
                // add to grocery cart
                groceryCart.push(newGroc);
                // remove the calculate button - this should only be changed now with the edit
                button.parentNode.removeChild(button);
                // enable the edit button -- I intend to continue building this out at a later date
                // editBtn.removeAttribute('disabled');
                // enable the add new item button
                newBtn.removeAttribute('disabled');
                newBtn.classList.remove('btn-outline-success')
                newBtn.classList.add('btn-success')
                saveBtn.removeAttribute('disabled');
                saveBtn.classList.remove('btn-outline-info');
                saveBtn.classList.add('btn-info');
                runTotals();
            }
            // if weight/quantity has a value
            else {
                // create a bulk product instead
                const newBulk = new BulkItem(input0, input1, input2);
                // add to grocery cart
                groceryCart.push(newBulk);
                // remove the calculate button - this should only be changed now with the edit
                button.parentNode.removeChild(button);
                // enable the edit button -- I intend to continue building this out at a later date
                // editBtn.removeAttribute('disabled');
                // enable the add new item button
                newBtn.removeAttribute('disabled');
                newBtn.classList.remove('btn-outline-success')
                newBtn.classList.add('btn-success')
                saveBtn.removeAttribute('disabled');
                saveBtn.classList.remove('btn-outline-info');
                saveBtn.classList.add('btn-info');
                runTotals();
            }
        });
    }

    // observer function on the article to watch for success class addition on the input fields
    function articleObserver() {
        // select div with inputs in it
        const div = document.querySelector('#item'+inputIndex+ ' div');
        // select all three child nodes
        const observe0 = div.childNodes[1];
        const observe1 = div.childNodes[4];
        const observe2 = div.childNodes[7];
        // button for calculate total selector
        const button = document.querySelector('button.calculate-total')

        // config observer to watch the attributes
        const config = {attributes : true}

        // set up of the observer
        const callback = function(mutationList, observer) {
            for (let mutation of mutationList) {
                // if the observer observes the attributes changing
                if (mutation.type == 'attributes') {
                    // if all three input fields contain 'success'
                    if (observe0.classList.contains('success') && observe1.classList.contains('success') && observe2.classList.contains('success')) {
                        // remove disabled attribute from button
                        button.removeAttribute('disabled');
                        button.classList.remove('btn-outline-primary');
                        button.classList.add('btn-primary');
                    }
                    // if they don't all three have success
                    else {
                        // ensure the button's attribute is still disabled or set to disabled
                        button.setAttribute('disabled', 'true');
                        button.classList.add('btn-outline-primary');
                        button.classList.remove('btn-primary');
                    }
                }
            }
        }

        // new mutation observer to watch all three input fields
        const observer = new MutationObserver(callback);
        observer.observe(observe0, config);
        observer.observe(observe1, config);
        observer.observe(observe2, config);
    }

    // event listener function for all the inputs
    function inputEventListener() {
        // set button to change disabled state
        const button = document.querySelector('button');
        // select article
        const article = document.querySelector('#item'+inputIndex);
        // select the div inside this article
        const div = article.childNodes[0];
        // call all three listeners from this function
        nameListner(div, button);
        costListener(div, button);
        quantListener(div, button);
    }

    function nameListner(div) {
        // will always be input name
        const name = div.childNodes[1];
        // will always be input error
        const nameError = div.childNodes[2];
        // add event listener to name input
        name.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = name.value;
            // check if the string is empty or less than 2 characters
            if (temp == '' || temp.length < 2) {
                // if it is, add and remove these classes
                name.classList.add('error');
                nameError.classList.remove('invisible');
                name.classList.remove('success');
            }
            else {
                // if it isn't remove and add these classes instead
                name.classList.remove('error');
                nameError.classList.add('invisible');
                name.classList.add('success');
            }
        });
    }

    function costListener(div) {
        // will always be input cost
        const cost = div.childNodes[4];
        // will always be input error
        const costError = div.childNodes[5];
        cost.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = parseFloat(cost.value);
            // check if the string is empty or the user hasn't entered a number
            if (temp == '' || temp.length < 1 || isNaN(temp) ) {
                // if it is, add and remove these classes
                cost.classList.add('error');
                costError.classList.remove('invisible');
                cost.classList.remove('success');
            }
            else {
                // if it isn't remove and add these classes instead
                cost.classList.remove('error');
                costError.classList.add('invisible');
                cost.classList.add('success');
            }
        });
    }

    function quantListener(div) {
        // will always be input quant
        const quant = div.childNodes[7];
        // will always be input error
        const quantError = div.childNodes[8];
        quant.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = parseFloat(quant.value);
            // if it is, add and remove these classes
            if (quant.value == '') {
                // if it was
                quant.classList.remove('error');
                quantError.classList.add('invisible');
                quant.classList.add('success');
            }
            // if it isn't blank
            else if (temp != '') {
                // check if they input a number
                if(isNaN(temp)) {
                    // if it is, add and remove these classes
                    quant.classList.add('error');
                    quantError.classList.remove('invisible');
                    quant.classList.remove('success');
                }
                else {
                    // if it isn't remove and add these classes instead
                    quant.classList.remove('error');
                    quantError.classList.add('invisible');
                    quant.classList.add('success');
                }
            }
        })
    }

    (function(){
        // initial creation should always have one field
        createNewField();
        // start event listener on function
        addNewListener();
        // start even listener for save
        saveEventListener();
    }())
    
})();