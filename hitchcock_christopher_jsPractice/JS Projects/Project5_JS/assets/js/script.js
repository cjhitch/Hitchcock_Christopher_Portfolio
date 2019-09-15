(function(){

    // variables for the program
    let firstArray = [34, 20, 91, 49];
    let secondArray = [42, 120.30, 210.20, 32.50];
    var sumArrayOne = 0;
    var sumArrayTwo = 0;
    let newCombinedArray = [];

    // sum of arrays
    firstArray.forEach(element => {
        sumArrayOne += element;
    });
    // write out to the console
    console.log("Sum of Array One: ",sumArrayOne,"\r\nArray One's Length: ", firstArray.length);

    // sum of second array
    secondArray.forEach(element =>{
        sumArrayTwo += element;
    });
    // write to console
    console.log("\nSum of Array Two: ", sumArrayTwo,"\r\nArray Two's Length: ", secondArray.length);

    // get avg and print to console of both arrays
    let arrayOneAvg = sumArrayOne / firstArray.length;
    console.log("\nAverage of Array One: ", arrayOneAvg);

    let arrayTwoAvg = sumArrayTwo / secondArray.length;
    console.log("\nAverage of Array Two: ", arrayTwoAvg,"\n");

    // combine arrays into one array
    for (let i = 0; i < firstArray.length; i++) {
        newCombinedArray[i] = firstArray[i] + secondArray[i];
        console.log(`New Combined Array Value at Index ${i}: `,newCombinedArray[i]);
    }

    // mixed up string array
    let  mixedUp = ["universe is winning.", "erse trying to produce bigger an", "between software engineers striving to build bigger ", "d better idiots. So far, the ", "Programming today is a race ", "and better idiot-proof programs, and the univ"];

    // fixed string array and print to console
    let fixedSentence =  mixedUp[4] + mixedUp[2] + mixedUp[5] + mixedUp[1] + mixedUp[3] + mixedUp[0];
    console.log("\n",fixedSentence);

})();