using System;
using System.Collections.Generic;

namespace Hitchcock_Christopher_Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            /*
            Christopher Hitchcock
            Scalable Database Infrastructure           
            MDV2330-O Section 01
            March 24th, 2019
            Lists
            */
            
            // declare variables for use in program
            // my original test values
//            List<decimal> itemPrices = new List<decimal>(){2.47m, 18.47m, 62.14m, 183.19m, 26.32m, 0.98m, 9.49m};
            // test #1
            List<decimal> itemPrices = new List<decimal>(){1.25m, 2.56m, 5.67m, 4m, 8.25m, 2.99m, 9.99m};
            decimal itemTotal;

            // call function and return value of function to variable
            itemTotal = AddUpCosts(itemPrices);
            
            // write out the first value of the lists' sum -- not necessary for our calculations, but rubrics said number needed to be rounded to 2 decimals
            Console.WriteLine("Welcome to the Grocery List Calculator\r\nUsing your previously submitted values, we have calculated your grocery list total\r\nThe sum of the prices in the list is ${0}.", Math.Round(itemTotal,2));
            
            // tell user we are making some changes to the list
            Console.WriteLine("\r\nUh oh, looks like we have to cancel one item, and replace another item with a different one, we will re-total your grocery list.");
            // my original test values -- remove two values, insert one at index 0
//            itemPrices.Remove(18.47m);
//            itemPrices.Remove(183.19m);
//            itemPrices.Insert(0,161.19m);
            // test #1 -- remove two values, insert one at index 0
            itemPrices.Remove(9.99m);
            itemPrices.Remove(5.67m);
            itemPrices.Insert(0,6.78m);

            // checked to verify new inserted price is in index 0 - start of the list - worked
//            for (int i = 0; i < itemPrices.Count; i++)
//            {
//                Console.WriteLine(itemPrices[i]);
//            }

            // call the function to calculate the lists' sum again using the new list
            itemTotal = AddUpCosts(itemPrices);
            // write out the newly summed list total -- not necessary for our calculations, but rubrics said number needed to be rounded to 2 decimals
            Console.WriteLine("\r\nThe sum of the prices in the list is ${0}.", Math.Round(itemTotal,2));
            
            /*
             * TESTING
             * tested my own values first, they are commented out in the code.
             * Entered list values 2.47m, 18.47m, 62.14m, 183.19m, 26.32m, 0.98m, 9.49m
             * program output The sum of the prices in the list is $303.06.
             * removed 18.47 and 183.19, and inserted 161.19m at the beginning of the list
             * program output Uh oh, looks like we have to cancel one item, and replace the other item with a different one, we will re-total your grocery list.
             * The sum of the prices in the list is $262.59.
             *
             * TEST #1
             * Entered list values 1.25m, 2.56m, 5.67m, 4m, 8.25m, 2.99m, 9.99m
             * program output The sum of the prices in the list is $34.71.
             * removed 9.99 and 5.67, and inserted 6.78m at the beginning of the list
             * program output Uh oh, looks like we have to cancel one item, and replace the other item with a different one, we will re-total your grocery list.
             * The sum of the prices in the list is $25.83.
             */
        }

        // new function "AddUpCosts" -- used to loop through the list and calculate the total sum -- used twice
        public static decimal AddUpCosts(List<decimal> price1)
        {
            // create variable to catch the lists' total
            decimal itemTotal = 0;
            // for loop to run through once for each amount of items in the list 
            for (int i = 0; i < price1.Count; i++)
            {
                // adds value of the price to the running total of the variable
                itemTotal += price1[i];
            }

            // return the completed value to be used in the main method
            return itemTotal;
        }
    }
}
