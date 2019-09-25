(function(){

    // base class for grocery item - includes name and cost for single item
    class GroceryItem {
        constructor(name, cost) {
            this._name = name;
            this._cost = cost;
        }
    }
    // child class for bulk items, extends base and adds in quantity or weight and total to calculate a total base on those two
    class BulkItem extends GroceryItem {
        constructor(name, cost, quantity) {
            super(name, cost);
            this._quantity = quantity;
            this._total = groc.methods.calculateTotal(cost, this._quantity);
        }
    }
    // index to iterate through when a new item is built
    var inputIndex = 0;
    // select the input area to append elements to
    let inputArea = document.querySelector('section.input-area');
    // arrays to be used for unique names in input and label creation
    var labelNames = ['Item Name', 'Item Cost (only #\'s ex. 12.34)', 'Weight/Quantity (only #\'s ex. 2.45) This may be left blank'];
    var labelFor = ['name', 'cost', 'quant'];
    var errorList = ['must be 2 characters or longer','must only be a number and at least 1 digit','must only be a number'];
    // const REGEXCOST = RegExp('^\d*\.?\d2$');
    // const REGEXNAME = RegExp('^(\d*+([a-zA-Z])*|([a-zA-Z])*+\d*)');
    // function to run the new field creation
    function createNewField() {
        // call article creation function
        createArticle();
        // make new event listeners for each field
        inputEventListener();
        // increment the index for use in the next new field creation
        inputIndex++;
    }
    // build and prepend the new article before the add new item button
    function createArticle(){
        // create element
        let articleArea = document.createElement('article');
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
        let div = document.createElement('div');
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
        // call the create total function
        createTotalDiv(div);
    }
    // build label and append to the new div -- uses the i from the for loop to run through the arrays and give correct naming convention
    function createLabel(div, thisIndex){
        // create new label element
        let lab = document.createElement('label');
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
        let input = document.createElement('input');
        // set class attributes for the input
        input.setAttribute('class', 'w-100 input-'+labelFor[thisIndex])
        // set type to text
        input.setAttribute('type', 'text');
        // append to the div under the newly created label
        div.appendChild(input);
    }

    // build errors for input fields
    function createError(div, thisIndex) {
        // create new error element
        let error = document.createElement('p');
        // set class attributes for the p tag
        error.setAttribute('class', 'error-text invisible');
        // set text for error field
        error.textContent = errorList[thisIndex];
        // append to the div under the newly created input
        div.appendChild(error);
    }

    function createTotalDiv(div) {
        // new section for a row
        let section = document.createElement('section');
        // add class row
        section.setAttribute('class', 'row mt-3');
        // new div for 5/12's
        let leftDiv = document.createElement('div');
        // set class for 5/12's
        leftDiv.setAttribute('class', 'col-sm-5');
        // new div for 7/12's
        let rightDiv = document.createElement('div');
        // set class for 7/12's
        rightDiv.setAttribute('class', 'col-sm-7');
        // append section to div
        div.appendChild(section);
        // append div to section
        section.appendChild(leftDiv);
        // append div to section
        section.appendChild(rightDiv);
        // get return value from createSubTotal
        let subTotal = createSubTotal();
        // get return value from createTax        
        let tax = createTax();
        // get return value from createTax        
        let total = createTotal();
        // append h6 sub to the div
        leftDiv.appendChild(subTotal);
        // append h6 tax to the div
        leftDiv.appendChild(tax);
        // append h5 to the div
        leftDiv.appendChild(total);
    }

    function createSubTotal() {
        // create new h6 subtotal element
        let subTotal = document.createElement('h6');
        // set class for subtotal
        subTotal.setAttribute('class', 'text-left');
        // text content for subtotal
        subTotal.textContent = 'Subtotal: $'
        return subTotal;
    }

    function createTax(div) {
        // create new h6 tax element
        let tax = document.createElement('h6');
        // set class for tax
        tax.setAttribute('class', 'text-left');
        // text content for tax
        tax.textContent = 'Tax: $';
        return tax;
    }

    function createTotal(div) {
        // create new h5 total element
        let total = document.createElement('h5');
        // set class attributes for the h5
        total.setAttribute('class', 'mt-3 text-left h5-item');
        // set text content for h5
        total.textContent = 'Total: $';
        return total;
    }
    
    function buttonListener() {
        let button = document.querySelector('button');
        button.addEventListener('click', createNewField)
    }
    // event listener function for all the inputs
    function inputEventListener() {
        let article = document.querySelector('#item'+inputIndex);
        // select the div inside this article
        let div = article.childNodes[0];
        // will always be input name
        let name = div.childNodes[1];
        // will always be input error
        let nameError = div.childNodes[2];
        // will always be input cost
        let cost = div.childNodes[4];
        // will always be input error
        let costError = div.childNodes[5];
        // will always be input quant
        let quant = div.childNodes[7];
        // will always be input error
        let quantError = div.childNodes[8];
        // add event listener to name input
        // set button to change disabled state
        let button = document.querySelector('button');
        name.addEventListener('input', function(){
            // temp variable to get value of input field
            let temp = name.value;
            if (temp == '' || temp.length < 2) {
                if (button.disabled == false) {
                    button.setAttribute('disabled', 'true');
                }                  
                name.classList.add('error');
                nameError.classList.remove('invisible');
            }
            else {
                name.classList.remove('error');
                nameError.classList.add('invisible');
            }
        });
        cost.addEventListener('input', function(){
            // temp variable to get value of input field
            let temp = parseFloat(cost.value);
            if (temp == '' || temp.length < 1 || isNaN(temp) ) {
                if (button.disabled == false) {
                    button.setAttribute('disabled', 'true');
                }                
                cost.classList.add('error');
                costError.classList.remove('invisible');
            }
            else {
                cost.classList.remove('error');
                costError.classList.add('invisible');
            }
        });
        quant.addEventListener('input', function(){
            // temp variable to get value of input field
            let temp = parseFloat(quant.value);
            if (temp.length > 0) {
                if(isNaN(temp)) {
                    quant.classList.add('error');
                    quantError.classList.remove('invisible');
                    if (button.disabled == false) {
                        button.setAttribute('disabled', 'true');
                    }
                }
                else {
                    quant.classList.remove('error');
                    quantError.classList.add('invisible');
                }
            }
        })
    }

    (function(){
        // initial creation should always have one field
        createNewField();
        // start event listener on function
        buttonListener();
    }())
    
})();