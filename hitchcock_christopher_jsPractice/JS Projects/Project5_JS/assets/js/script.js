(function(){

    let itemPrices = [1.25, 2.56, 5.67, 4, 8.25, 2.99, 9.99];
    let revampedItemPrices = [];
    let itemTotal = 0;

    addUpCosts(itemPrices);

    console.log(`Welcome to the Grocery List Calculator\nUsing your previously submitted values, we have calculated your grocery list total\nThe sum of the prices in the list is \$${parseFloat(itemTotal).toFixed(2)}`)

    console.log(`\nUh oh, looks like we have to cancel ont item, and replace another item with a different one, we will re-total your grocery list.`)
    
    revampedItemPrices = itemPrices;
    revampedItemPrices.length = 6;
    revampedItemPrices.splice(2,1);
    revampedItemPrices.unshift(6.78);

    addUpCosts(revampedItemPrices);

    console.log(`\nThe sum of the prices in the list is \$${parseFloat(itemTotal).toFixed(2)}`)
    
    function addUpCosts(array) {
        itemTotal = 0;
        for (let i = 0; i < array.length; i++) {            
            itemTotal += itemPrices[i];
        }
    }

})();