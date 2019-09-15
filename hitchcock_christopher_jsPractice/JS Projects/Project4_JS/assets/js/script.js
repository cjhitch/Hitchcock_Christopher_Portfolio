(function(){

    let coffeeOrderName = ["coffee", "cappuccino", "latte", "cappuccino", "latte", "coffee", "cappuccino", "coffee", "decaf", "cappuccino"];
    let coffeeNames = ["coffee", "cappucino", "latte", "decaf"];
    let coffeeOrderNum = [0,0,0,0];

    console.log("Thank you for using our coffee run calculator. This program will tell you how many of each drink to order!")
    console.log("\n")
    for (let i = 0; i < coffeeOrderName.length; i++) {
        if (coffeeOrderName[i] == "coffee"){
            coffeeOrderNum[0] += 1;
        }
        else if (coffeeOrderName[i] == "cappuccino"){
            coffeeOrderNum[1] += 1;
        }
        else if (coffeeOrderName[i] == "latte"){
            coffeeOrderNum[2] += 1;
        }
        else{
            coffeeOrderNum[3] += 1;
        }   
    }

    for (let i = 0; i < coffeeOrderNum.length; i++) {
        if (coffeeOrderNum[i]>1){
            console.log(`Order ${coffeeOrderNum[i]} ${coffeeNames[i]}s`);
        }
        else {
            console.log(`Order ${coffeeOrderNum[i]} ${coffeeNames[i]}`);
        }
    }

    console.log("\nThank you for using our coffee run calculator! Please use our app again in the future!")

})();