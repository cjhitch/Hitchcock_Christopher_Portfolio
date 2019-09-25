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
    var labelNames = ['Item Name', 'Item Cost (only #\'s ex. 12.34)', 'Weight/Quantity (only #\'s ex. 2.45)'];
    var labelFor = ['name', 'cost', 'quant'];
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
        }
        // call the create total function
        createTotal(div);
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
    function createTotal(div) {
        // create new h5 element
        let total = document.createElement('h5');
        // set class attributes for the h5
        total.setAttribute('class', 'mt-3 text-left h5-item');
        // set text content for h5
        total.textContent = 'Total: $';
        // append h5 to the div
        div.appendChild(total);
    }
    
    function buttonListener() {
        let button = document.querySelector('button');
        button.addEventListener('click', createNewField)
    }

    function inputEventListener() {
        let article = document.querySelector('#item'+inputIndex);
        // select the div inside this article
        let div = article.childNodes[0];
        // should always be input name
        let name = div.childNodes[1];
        console.log(name);
        // should always be input cost
        let cost = div.childNodes[3];
        console.log(cost)
        // should always be input quant
        let quant = div.childNodes[5];
        console.log(quant)
        name.addEventListener('input', function(){
            let m;
            let temp = name.value;
            while ((m = REGEXNAME.exec(temp)) !== null) {
                // This is necessary to avoid infinite loops with zero-width matches
                if (m.index === REGEXNAME.lastIndex) {
                    REGEXNAME.lastIndex++;
                }
                
                // The result can be accessed through the `m`-variable.
                m.forEach((match, groupIndex) => {
                    console.log(`Found match, group ${groupIndex}: ${match}`);
                });
            }
            console.log(temp);
            if (temp == REGEXNAME) {
                alert('You suck!');
            }
        });
        cost.addEventListener('input', function(){

        });
        quant.addEventListener('input', function(){

        });
    }

    (function(){
        // initial creation should always have one field
        createNewField();
        // start event listener on function
        buttonListener();
    }())
    
})();