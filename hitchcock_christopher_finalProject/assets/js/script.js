(function(){

    // base class for grocery item - includes name and cost for single item
    class GroceryItem {
        constructor(name, cost) {
            this._name = name;
            this._cost = cost;
        }
        Name() {

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
        get Total() {
            return this._total;
        }
    }
    // index to iterate through when a new item is built
    let inputIndex = 0;
    // select the input area to append elements to
    const inputArea = document.querySelector('section.input-area');
    // arrays to be used for unique names in input and label creation
    const labelNames = ['Item Name', 'Item Cost (only #\'s ex. 12.34)', 'Weight/Quantity (only #\'s ex. 2.45) This may be left blank'];
    const labelFor = ['name', 'cost', 'quant'];
    const errorList = ['must be 2 characters or longer','must only be a number and at least 1 digit','must only be a number'];
    // function to run the new field creation
    function createNewField() {
        // call article creation function
        createArticle();
        // make new event listeners for each field
        inputEventListener();
        // add event listener to the button
        totalButtonListener();
        // start event listener on function
        addNewListener();
        articleObserver();
        // increment the index for use in the next new field creation
        inputIndex++;
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
        createTotalButton(div);
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

    function createTotalButton(div) {
        // new section for a row
        const section = document.createElement('section');
        // add class row
        section.setAttribute('class', 'row');
        // append section to the div
        div.appendChild(section);
        // create button
        const button = document.createElement('button');
        // add class to button
        button.setAttribute('class', 'calculate-total mx-auto mt-3');
        // set initial state of button to be disabled
        button.setAttribute('disabled', 'true');
        // set text content
        button.textContent = 'Calculate Total';
        // append button to section
        section.appendChild(button);
    }

    function createTotalDiv(div) {
        // new section for a row
        const section = document.createElement('section');
        // add class row
        section.setAttribute('class', 'row mt-3');
        // new div for 5/12's
        const leftDiv = document.createElement('div');
        // set class for 5/12's
        leftDiv.setAttribute('class', 'col-sm-5');
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
        leftDiv.appendChild(subTotal);
        // append h6 tax to the div
        leftDiv.appendChild(tax);
        // append h5 to the div
        leftDiv.appendChild(total);
    }

    function createSubTotal() {
        // create new h6 subtotal element
        const subTotal = document.createElement('h6');
        // set class for subtotal
        subTotal.setAttribute('class', 'text-left');
        // text content for subtotal
        subTotal.textContent = 'Subtotal: $'
        return subTotal;
    }

    function createTax(div) {
        // create new h6 tax element
        const tax = document.createElement('h6');
        // set class for tax
        tax.setAttribute('class', 'text-left');
        // text content for tax
        tax.textContent = 'Tax: $';
        return tax;
    }

    function createTotal(div) {
        // create new h5 total element
        const total = document.createElement('h5');
        // set class attributes for the h5
        total.setAttribute('class', 'mt-3 text-left h5-item');
        // set text content for h5
        total.textContent = 'Total: $';
        return total;
    }
    
    function addNewListener() {
        // get new item button
        const button = document.querySelector('button#newItem');
        // call function to create a new item field once clicked
        button.addEventListener('click', createNewField)
    }

    function totalButtonListener() {
        // get calculate total button
        const button = document.querySelector('button.calculate-total');
        const div = document.querySelector('#item'+inputIndex+ ' div');
        button.addEventListener('click', function(e){
            e.preventDefault();
            // listener for click on calculate total button
            const input0 = div.childNodes[1].value;
            const input1 = div.childNodes[4].value;
            const input2 = div.childNodes[7].value;
            if (input2 == '') {
                console.log('I\'m here?');
                const newGroc = new GroceryItem(input0, input1);
            }
            else {
                const newBulk = new BulkItem(input0, input1, input2)
                console.log(newBulk);
            }
        });
    }

    function articleObserver() {
        const div = document.querySelector('#item'+inputIndex+ ' div');
        const observe0 = div.childNodes[1];
        const observe1 = div.childNodes[4];
        const observe2 = div.childNodes[7];
        const button = document.querySelector('button.calculate-total')

        const config = {attributes : true}

        const callback = function(mutationList, observer) {
            for (let mutation of mutationList) {
                if (mutation.type == 'attributes') {
                    if (observe0.classList.contains('success') && observe1.classList.contains('success') && observe2.classList.contains('success')) {
                        // remove disabled attribute from button
                        button.removeAttribute('disabled');
                    }
                    else {
                        button.setAttribute('disabled', 'true');
                    }
                }
            }
        }

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
        // get true or false values for event listeners
        nameListner(div, button);
        costListener(div, button);
        quantListener(div, button);
    }

    function nameListner(div, button) {
        // will always be input name
        const name = div.childNodes[1];
        // will always be input error
        const nameError = div.childNodes[2];
        // add event listener to name input
        name.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = name.value;
            if (temp == '' || temp.length < 2) {                
                name.classList.add('error');
                nameError.classList.remove('invisible');
                name.classList.remove('success');
            }
            else {
                name.classList.remove('error');
                nameError.classList.add('invisible');
                name.classList.add('success');
            }
        });
    }

    function costListener(div, button) {
        // will always be input cost
        const cost = div.childNodes[4];
        // will always be input error
        const costError = div.childNodes[5];
        cost.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = parseFloat(cost.value);
            if (temp == '' || temp.length < 1 || isNaN(temp) ) {
                cost.classList.add('error');
                costError.classList.remove('invisible');
                cost.classList.remove('success');
            }
            else {
                cost.classList.remove('error');
                costError.classList.add('invisible');
                cost.classList.add('success');
            }
        });
    }

    function quantListener(div, button) {
        // will always be input quant
        const quant = div.childNodes[7];
        // will always be input error
        const quantError = div.childNodes[8];
        quant.addEventListener('input', function(){
            // temp variable to get value of input field
            const temp = parseFloat(quant.value);
            if (quant.value == '') {
                quant.classList.remove('error');
                quantError.classList.add('invisible');
                quant.classList.add('success');
            }
            else if (temp != '') {
                if(isNaN(temp)) {
                    quant.classList.add('error');
                    quantError.classList.remove('invisible');
                    quant.classList.remove('success');
                }
                else {
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
    }())
    
})();