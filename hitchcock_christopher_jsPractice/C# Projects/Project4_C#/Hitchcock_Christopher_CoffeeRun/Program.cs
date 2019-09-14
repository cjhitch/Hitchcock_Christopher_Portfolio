using System;

namespace Hitchcock_Christopher_CoffeeRun
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            Christopher Hitchcock
            Scalable Database Infrastructure           
            MDV2330-O Section 01
            March 17th, 2019
            Coffee Run
            */

            // variables for program -- existing array from pdf, added names of each for second for loop, and int array for amount of each
            string[] coffeeOrderName = new string[] {"coffee", "cappuccino", "latte", "cappuccino", "latte", "coffee", "cappuccino", "coffee", "decaf", "cappuccino"};
            string[] coffeeNames = new string[] {"coffee", "cappucino", "latte", "decaf"};
            int[] coffeeOrderNum = new int[4];

            Console.WriteLine("Thank you for using our coffee run calculator. This program will tell you how many of each drink to order!\r\n");

            // for loop to establish how many of each drink was ordered -- since our array is given, no validation is needed
            for (int i = 0; i < coffeeOrderName.Length; i++) {
                if (coffeeOrderName[i] == "coffee") {
                    coffeeOrderNum[0] += 1;
                } else if (coffeeOrderName[i] == "cappuccino") {
                    coffeeOrderNum[1] += 1;
                } else if (coffeeOrderName[i] == "latte") {
                    coffeeOrderNum[2] += 1;
                } else {
                    coffeeOrderNum[3] += 1;
                }
            }
            
            // for loop to write out how many of each drink are needed
            for (int j = 0; j < coffeeNames.Length; j++)
            {
                // changed the "" a little to make more sense -- Order 3 number of coffees -- doesn't make much sense compared to Order 3 coffees
                Console.Write("Order " + coffeeOrderNum[j] + " " + coffeeNames[j]);if(coffeeOrderNum[j]>1){Console.WriteLine("s");};
            }
            // thank for using the program
            Console.WriteLine("\r\n\r\nThank you for using our coffee run calculator! Please use our app again in the future!");
        }
    }
}
