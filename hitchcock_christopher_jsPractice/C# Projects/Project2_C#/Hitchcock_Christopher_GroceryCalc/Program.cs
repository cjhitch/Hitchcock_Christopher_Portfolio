using System;

namespace Hitchcock_Christopher_GroceryCalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Christopher Hitchcock
            Scalable Database Infrastructure           
            MDV2330-O Section 01
            March 10th, 2019
            Grocery Calculator           
            */
               
            //Prompt Grocery Store Customer For Name
            Console.WriteLine("Please Enter Your Name and Press Enter");
            string customerName = Console.ReadLine();

            //Greeting for user using the calculator
            Console.WriteLine("Hello " + customerName + ",\r\nThank you for choosing to use our Grocery Calculator!\r\nPlease enter whole numbers with no decimals when prompted for quantity.");

            //
            //Prompt for first grocery item price, store in variable, and convert to decimal as we are using money
            //
            Console.WriteLine("Please enter the price of your apples and press enter");
            string groceryItem0 = Console.ReadLine();
            decimal groceryPrice0 = decimal.Parse(groceryItem0);

            //Prompt for quantity of item one, parse to integer, store in variable, and get total price
            Console.WriteLine("How many apples would you like?");
            string stringItemQuantity0 = Console.ReadLine();
            //Round to nearest int in case someone does put in a partial quantity -- Program had fatal error otherwise
            decimal itemQuantity0 = Math.Round(decimal.Parse(stringItemQuantity0),0);
            decimal totalItem0 = groceryPrice0 * itemQuantity0;
            Console.WriteLine("Your total for your apples is: $" + totalItem0);
            //Added for readability
            Console.WriteLine("\r\n");

            //
            //Prompt for second grocery item price, store in variable, and convert to decimal as we are using money
            //
            Console.WriteLine("Please enter the price of your carton of ice cream and press enter");
            string groceryItem1 = Console.ReadLine();
            decimal groceryPrice1 = decimal.Parse(groceryItem1);

            //Prompt for quantity of item two, parse to integer, store in variable, and get total price
            Console.WriteLine("How many cartons of ice cream would you like?");
            string stringItemQuantity1 = Console.ReadLine();
            //Round to nearest int in case someone does put in a partial quantity -- Program had fatal error otherwise
            decimal itemQuantity1 = Math.Round(decimal.Parse(stringItemQuantity1), 0);
            decimal totalItem1 = groceryPrice1 * itemQuantity1;
            Console.WriteLine("Your total for your ice cream is: $" + totalItem1);
            //Added for readability
            Console.WriteLine("\r\n");

            //
            //Prompt for third grocery item price, store in variable, and convert to decimal as we are using money
            //
            Console.WriteLine("Please enter the price of your steaks and press enter");
            string groceryItem2 = Console.ReadLine();
            decimal groceryPrice2 = decimal.Parse(groceryItem2);

            //Prompt for quantity of item three, parse to integer, store in variable, and get total price
            Console.WriteLine("How many steaks would you like?");
            string stringItemQuantity2 = Console.ReadLine();
            //Round to nearest int in case someone does put in a partial quantity -- Program had fatal error otherwise
            decimal itemQuantity2 = Math.Round(decimal.Parse(stringItemQuantity2), 0);
            decimal totalItem2 = groceryPrice2 * itemQuantity2;
            Console.WriteLine("Your total for your steaks is: $" + totalItem2);
            //Added for readability
            Console.WriteLine("\r\n");

            //
            //Calculate the subtotal
            //
            decimal subTotal = totalItem0 + totalItem1 + totalItem2;

            //
            //Calculate sales tax
            //
            Console.WriteLine("Enter Your Local Area Sales Tax and Press Enter -- Ex. 8.25 or 7");
            string salesTax = Console.ReadLine();
            //Get sales tax percentage from number entered by customer
            decimal salesTaxNum = decimal.Parse(salesTax) / 100;
            decimal salesTaxTotal = subTotal * salesTaxNum;
            //Rounded to two decimal places since grocery stores can't accept below a penny
            decimal taxRounded = Math.Round(salesTaxTotal, 2);
            //Added for readability
            Console.WriteLine("\r\n");

            //Show SubTotal
            Console.WriteLine("Your Subtotal is: $" + subTotal);

            //
            //Show Sales Tax
            //
            Console.WriteLine("Your Sales Tax is: $" + taxRounded);

            //
            //Calculate grand total
            //
            decimal grandTotal = subTotal + taxRounded;
            Console.WriteLine("Your Grand Total is: $" + grandTotal);

            /*
            Used multiple tests for this, this was my final test
            first item cost = 2.53 quantity = 4 -- Total is 10.12
            second item cost = 3.67 quantity = 3 -- Total is 11.01
            third item cost = 16.59 quantity = 2 -- Total is 33.18
            subtotal is 54.31
            sales tax is 4.480575 which should round to 4.48
            grand total is 58.79
            */

            //Goodbye text
            Console.WriteLine("\r\n");
            Console.WriteLine("Thank you for using our Grocery Calculator! \r\nWe look forward to serving you again!");

        }
    }
}
