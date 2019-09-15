(function(){

    var gcp = {
        // variables for html selectors
        selectors : {
            btnSelector: document.querySelector('button'),
            nameDisplay: document.querySelector('section.nameDisplay h3'),
            foodSection: document.querySelector('.foodSection'),
            foodInputs: document.querySelectorAll('.foodSection input'),
            totalSelector: document.querySelectorAll('.total'),
            totalArea: document.querySelector('.totalArea'),
            displaySub: document.querySelector('.displaySub'),
            displayTax: document.querySelector('.displayTax'),
            displayTotal: document.querySelector('.displayTotal'),
        },
        // value items
        values : {
            name: document.querySelector('input.name').value,
            allTotals: [],
            sub: 0,
            tax: 0,
            total: 0
        },
        method : {
            // once hit submit, welcome user
            setName : function() {               
                gcp.selectors.nameDisplay.innerHTML = "Hello " + gcp.values.name +"<br>Enter the price and quantity of the items below";
            },
            // listen to the inputs for changes and run method based on the change
            listener: function() {
                gcp.selectors.foodInputs.forEach(element => {
                    element.addEventListener('input', function(){
                        if (gcp.selectors.foodInputs.item(0).value != "" && gcp.selectors.foodInputs.item(1).value != ""){
                            gcp.method.calculateItem(0,1,0);
                            gcp.method.calculateSub();
                        }
                        else {
                            gcp.selectors.totalSelector.item(0).innerHTML = "";
                            gcp.method.calculateSub();
                        }
                        if (gcp.selectors.foodInputs.item(2).value != "" && gcp.selectors.foodInputs.item(3).value != ""){
                            gcp.method.calculateItem(2,3,1);
                            gcp.method.calculateSub();
                        }
                        else {
                            gcp.selectors.totalSelector.item(1).innerHTML = "";
                            gcp.method.calculateSub();
                        }
                        if (gcp.selectors.foodInputs.item(4).value != "" && gcp.selectors.foodInputs.item(5).value != ""){
                            gcp.method.calculateItem(4,5,2);
                            gcp.method.calculateSub();
                        }
                        else {
                            gcp.selectors.totalSelector.item(2).innerHTML = "";
                            gcp.method.calculateSub();
                        }
                    })
                })
            },
            // calculate each individual item
            calculateItem: function(val1, val2, index) {
                let temp = gcp.selectors.foodInputs.item(val1).value * gcp.selectors.foodInputs.item(val2).value
                gcp.values.allTotals[index] = parseFloat(temp).toFixed(2);
                gcp.selectors.totalSelector.item(index).innerHTML = "$"+gcp.values.allTotals[index];
            },
            // calculate subtotal of all three items
            calculateSub: function() {
                if (gcp.selectors.totalSelector.item(0).textContent.includes('$') && gcp.selectors.totalSelector.item(1).textContent.includes('$') && gcp.selectors.totalSelector.item(2).textContent.includes('$')) {
                    gcp.selectors.totalArea.classList.remove('d-none');
                    gcp.values.sub = 0;
                    gcp.values.allTotals.forEach(element =>{
                        gcp.values.sub += parseFloat(element);
                    })
                    gcp.values.sub = parseFloat(gcp.values.sub).toFixed(2);
                    gcp.method.getTax();
                }
                else {
                    gcp.selectors.totalArea.classList.add('d-none');                    
                }
            },
            // calculate tax based off subtotal
            getTax: function(){
                    gcp.values.tax = gcp.values.sub * .0825;
                    gcp.values.tax = parseFloat(gcp.values.tax).toFixed(2);
                    gcp.method.getAndDisplayTotal();                          
            },
            // get total and display to DOM
            getAndDisplayTotal: function(){
                gcp.values.total = parseFloat(gcp.values.tax) + parseFloat(gcp.values.sub);
                gcp.values.total = parseFloat(gcp.values.total).toFixed(2);
                gcp.selectors.displaySub.innerHTML = "$"+gcp.values.sub;
                gcp.selectors.displayTax.innerHTML = "$"+gcp.values.tax;
                gcp.selectors.displayTotal.innerHTML = "$"+gcp.values.total;
            }
        }
    }

    // set up the event listener and initialized the setname and listener function
    gcp.selectors.btnSelector.addEventListener('click', function(e){
        gcp.method.setName();
        gcp.selectors.foodSection.classList.remove('d-none');
        gcp.method.listener();
    })
    
})();