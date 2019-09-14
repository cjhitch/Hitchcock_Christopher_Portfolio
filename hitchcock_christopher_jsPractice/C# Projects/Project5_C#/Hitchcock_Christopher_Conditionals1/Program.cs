using System;

namespace Hitchcock_Christopher_Conditionals1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            // *********** Problem example Stuff Your Face - Pie Eating Competition
            //

            //            Console.WriteLine("Welcome to the Pie Eating Contest. We need to determine your eligibility for the contest.\r\nPlease enter your weight and press enter.");
            //            // Get user input for weight
            //            string weightString = Console.ReadLine();
            //            // Setup Variable to be used for weight
            //            double weight;
            //            // Verify that user entered valid string which could be converted to a number, output converted weight
            //            while ( !(double.TryParse(weightString, out weight)) )
            //            {
            //                Console.WriteLine("\r\nPlease enter a valid number for weight"); 
            //                weightString = Console.ReadLine();
            //            }
            //            // Check for condition of user's weight being above or below 250lbs
            //            if (weight >= 250)
            //            {
            //                Console.WriteLine("The competitor qualifies for the heavyweight division.");
            //            } else {
            //                Console.WriteLine("The competitor needs to gain some weight!");
            //            }

            /*
             * Tested 0 returned "The competitor needs to gain some weight."
             * Tested 249.9 returned "The competitor needs to gain some weight."
             * Tested 250 returned "The competitor qualifies for the heavyweight division."
             * Tested cat returned "Please enter your weight and press enter."
             * Tested empty returned "Please enter your weight and press enter."
             * Tested spaces returned "Please enter your weight and press enter."
             * Tested 350 returned "The competitor qualifies for the heavyweight division."
             *
             * Only realized when I went on that this is the example. Didn't make sense to delete it so I left the built example.
             */

            //
            // *********** End Stuff Your Face --  Pie Eating Contest
            //


            //
            // *********** Problem #1: Hit the Jackpot!
            //

            Console.WriteLine("\r\nCongratulations on winning the lottery!\r\nPlease enter your winnings and press enter.");
            //Capture response
            string winningsString = Console.ReadLine();
            // Declare variable
            decimal winnings;

            // validation for receiving a number and a number above 0 -- Winnings wouldn't be negative. 
            while (!(decimal.TryParse(winningsString, out winnings) && winnings > 0))
            {
                //prompt user with problem and ask for input again
                Console.WriteLine("You entered an invalid number, please enter your winnings and press enter (This should be a positive number).");
                //Recapture response
                winningsString = Console.ReadLine();
            }
            // used console to verify the number coming out was a number and not a string
            //Console.WriteLine("The winnings are :{0} and the winnings multiplied by 2: {1}", winnings, winnings*2);

            //prompt user for selection of annual or lump sum payment
            Console.WriteLine("Thank you, now please select how you would like to receive your winnings. \r\nEnter \"L\" for one lump sum payment reduced by 15% \r\nEnter \"A\" for yearly payments for the next 20 years.\r\nAfter your response press enter");

            //capture response for payment type
            string paymentType = Console.ReadLine();
            //validate selection of payment type
            while (string.IsNullOrWhiteSpace(paymentType) || (!(paymentType.ToLower() == "a" || paymentType.ToLower() == "l")))
            {
                //prompt user there was a problem with their response and prompt for reponse again
                Console.WriteLine("You entered an invalid response for your payment type.\r\nEnter \"L\" for one lump sum payment reduced by 15% \r\nEnter \"A\" for yearly payments for the next 20 years.\r\nAfter your response press enter");
                //recapture response
                paymentType = Console.ReadLine();

            }

            //New variables for lump sum winnings and annual payout 
            decimal lumpDivider = (decimal)0.85;
            decimal lumpWinnings = winnings * lumpDivider;
            decimal annualDivider = 20;
            decimal annualWinnings = winnings / annualDivider;
            //(winnings).ToString("#,##0.00");
            //(annualWinnings).ToString("#,##0.00");
            //(lumpWinnings).ToString("#,##0.00");


            // conditional for giving response based on previously validated answer to lump sum or annual payout
            if (paymentType.ToLower() == "l")
            {
                Console.WriteLine("\r\nYour winnings of ${0} as a one-time lump sum payment is ${1}.", (winnings).ToString("#,##0.00"), (lumpWinnings).ToString("#,##0.00"));
            }
            else
            {
                Console.WriteLine("\r\nYour winnings of ${0} will be paid in 20 payments of ${1} a year.", (winnings).ToString("#,##0.00"), (annualWinnings).ToString("#,##0.00"));
            }


            /*
             * TESTING
             * corrected typo from pdf "as a one-time lump some payment", to "as a one-time lump sum payment"
             * Tested entering 20000 for first prompt, A for second prompt, program returned Your winnings of $20,000.00 will be paid in 20 payments of $1,000.00 a year.
             * Tested entering 100000.5 for first prompt, L for second prompt, program returned Your winnings of $100,000.50 as a one-time lump sum payment is $85,000.43.
             * Tested entering 65000000.99 for first prompt, a for second prompt, program returned Your winnings of $65,000,000.99 will be paid in 20 payments of $3,250,000.05 a year.
             * Tested entering 2.45 for first prompt, l for second prompt, program returned Your winnings of $2.45 as a one-time lump sum payment is $2.08.
             * Tested entering cat for first prompt, program returned "You entered an invalid number, please enter your winnings and press enter (This should be a positive number)."
             * Tested entering -12 for first prompt, program returned "You entered an invalid number, please enter your winnings and press enter (This should be a positive number)."
             * Tested entering no value for first prompt, program returned "You entered an invalid number, please enter your winnings and press enter (This should be a positive number)."
             * Tested entering spaces for first prompt, program returned "You entered an invalid number, please enter your winnings and press enter (This should be a positive number)."
             * Tested entering 1 for first prompt, and annual for second prompt, program returned:
                You entered an invalid response for your payment type.
                Enter "L" for one lump sum payment reduced by 15% 
                Enter "A" for yearly payments for the next 20 years.
                After your response press enter
             * Tested entering 1 for first prompt, and no value for second prompt, program returned:
                You entered an invalid response for your payment type.
                Enter "L" for one lump sum payment reduced by 15% 
                Enter "A" for yearly payments for the next 20 years.
                After your response press enter
             * Tested entering 1 for first prompt, and spaces for second prompt, program returned:
                You entered an invalid response for your payment type.
                Enter "L" for one lump sum payment reduced by 15% 
                Enter "A" for yearly payments for the next 20 years.
                After your response press enter
             * Finishing this last test, entered "a" for response and program returned, Your winnings of $1.00 will be paid in 20 payments of $0.05 a year.
             */

            //
            // *********** End Problem #1: Hit the Jackpot!
            //

            //
            // *********** Problem #2: Let's Make a Deal
            //


            // set up variables for problem
            string stringBulkNum;
            int bulkNum;
            string stringBulkCost;
            decimal bulkCost;
            string stringIndCost;
            decimal indCost;
            string couponType;
            string stringCoupVal;
            decimal coupVal;
            decimal bulkItemIndTotal;
            decimal indItemTotal;

            //ask question for number of items in bulk package
            Console.WriteLine("\r\nLet's find out if it is cheaper to buy in bulk or separately with your coupon.\r\nEnter the number of items in the bulk pack.");

            //record response to user prompt of bulk package quantity
            stringBulkNum = Console.ReadLine();

            // validate user gave whole number, number larger than 0 and in fact gave a number
            while (!(int.TryParse(stringBulkNum, out bulkNum) && bulkNum > 0))
            {
                // prompt user that invalid number was given, and re-prompt for user input on bulk package quantity
                Console.WriteLine("You entered an invalid quantity, please enter the number of items in the bulk pack and press enter. (These should be whole quantities and above 0)");
                // record response to user input for bulk package quantity
                stringBulkNum = Console.ReadLine();
            }
            // Checked to make sure the number being output gave me an integer
            //            Console.WriteLine("Bulk Number * 2: " + bulkNum*2);

            // prompt user for cost of bulk package
            Console.WriteLine("\r\nEnter the price of the bulk pack and press enter.");
            // record user response to bulk package #
            stringBulkCost = Console.ReadLine();

            // validate user response for actual number, and number above 0
            while (!(decimal.TryParse(stringBulkCost, out bulkCost) && bulkCost > 0))
            {
                // prompt user that invalid response was given to bulk cost and prompt for new input on bulk cost
                Console.WriteLine("You entered an invalid cost. Please enter a valid cost above $0 and press enter.");
                // re-record user response to bulk packaged cost
                stringBulkCost = Console.ReadLine();
            }
            // Checked to make sure the number being output gave me an decimal
            //            Console.WriteLine("Bulk Cost * 2: " + bulkCost*2);

            // prompt user for individual cost
            Console.WriteLine("\r\nEnter the price for the individual item and press enter.");
            // record user input for individual cost
            stringIndCost = Console.ReadLine();

            // validate user response for individual cost being actual number and above 0
            while (!(decimal.TryParse(stringIndCost, out indCost) && indCost > 0))
            {
                // prompt user that invalid cost was given, re-prompt for new answer
                Console.WriteLine("You entered an invalid cost, please enter the cost of the individual item and press enter. (this should be a number above 0)");
                // record new user answer
                stringIndCost = Console.ReadLine();
            }
            // Checked to make sure the number being output gave me an decimal
            //            Console.WriteLine("Individual0 Cost * 2: " + indCost*2);

            //prompt user for percentage or dollar amount coupon
            Console.WriteLine("\r\nFor your coupon \r\nEnter \"P\" if the coupon is percentage.\r\nEnter \"D\" if the coupon is dollar amount.\r\nAfter selection press enter.");
            //record user input for percentage or dollar amount
            couponType = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(couponType) || (!(couponType.ToLower() == "p" || couponType.ToLower() == "d")))
            {
                // prompt user they have entered an invalid value for coupon type, and re-prompt for input 
                Console.WriteLine("You entered an invalid response for coupon type. \r\nEnter \"P\" if the coupon is percentage.\r\nEnter \"D\" if the coupon is dollar amount.\r\nAfter selection press enter.");
                couponType = Console.ReadLine();
            }

            // conditional to get coupon value if it is percentage or dollar amount based on previously validated user response
            if (couponType.ToLower() == "p")
            {
                // prompt user for coupon percentage
                Console.WriteLine("\r\nEnter the percentage of your coupon and press enter. (Enter the number 7.5 for 7.5%)");
                // record user response for percentage
                stringCoupVal = Console.ReadLine();

                // validate user's response to be a number, and above 0 and below or equal to 100 -- used decimal as it will still be associated with cost when multiplied with the price
                while (!(decimal.TryParse(stringCoupVal, out coupVal) && coupVal > 0 && coupVal <= 100))
                {
                    // prompt user they entered an invalid value and re-prompt for new response
                    Console.WriteLine("You have entered an invalid response for the coupon percentage. Please enter the coupon percentage and press enter. (this should be a number above 0)");
                    // record user response
                    stringCoupVal = Console.ReadLine();
                }
                // make user entered value into percentage
                coupVal /= 100;
                // turn coupon value into percentage of item cost rather than percentage of item savings
                coupVal = 1 - coupVal;
                //                Console.WriteLine("This is the new coupon value: " + coupVal);
                // calculate the individual item total if coupon is %
                indItemTotal = indCost * coupVal;

            }
            else
            {

                // prompt user for coupon value
                Console.WriteLine("\r\nEnter the dollar amount of your coupon and press enter.");
                // record user response for coupon value
                stringCoupVal = Console.ReadLine();

                // validate user's response to be a number and above 0
                while (!(decimal.TryParse(stringCoupVal, out coupVal) && coupVal > 0))
                {
                    // prompt user they entered an invalid value and re-prompt for new response
                    Console.WriteLine("You have entered an invalid value for the coupon. Please enter the dollar amount of your coupon and press enter. (this should be a number above 0)");
                    // capture user response
                    stringCoupVal = Console.ReadLine();

                }
                //calculate individual item total if coupon is dollar amount
                indItemTotal = indCost - coupVal;
            }

            //            Console.WriteLine("This is the individual item cost: " + indItemTotal);
            // calculate individual item cost of bulk item
            bulkItemIndTotal = bulkCost / bulkNum;
            //            Console.WriteLine("This is the individual cost for each bulk item: " + bulkItemIndTotal);

            //conditional statement to calculate which is the better deal or if they are the same -- Using .toString to convert numbers to real prices with commas and only two decimal places
            if (bulkItemIndTotal < indItemTotal)
            {
                Console.WriteLine("\r\nThe cost of 1 item in the bulk pack is ${0}, which is cheaper than the cost of the individual item with coupon, which is ${1}. Buy the bulk pack!",
                    (bulkItemIndTotal).ToString("#,##0.00"), (indItemTotal).ToString("#,##0.00"));
            }
            else if (bulkItemIndTotal == indItemTotal)
            {
                Console.WriteLine("\r\nThe cost of 1 item in the bulk pack is ${0}, which is the same as the individual item with coupon, which is ${1}. Buy whichever you prefer!",
                    (bulkItemIndTotal).ToString("#,##0.00"), (indItemTotal).ToString("#,##0.00"));
            }
            else
            {
                Console.WriteLine("\r\nThe cost of 1 item using a coupon is ${0}, which is cheaper than the cost of the individual item from the bulk pack, which is ${1}. Buy the individual item and use the coupon!",
                    (indItemTotal).ToString("#,##0.00"), (bulkItemIndTotal).ToString("#,##0.00"));
            }

            /*
             * Added in an additional conditional to check if the statements were the same
             * TESTING
             * tested entering empty space in first prompt, returned You entered an invalid quantity, please enter the number of items in the bulk pack and press enter. (These should be whole quantities and above 0)
             * tested entering cat in first prompt, returned You entered an invalid quantity, please enter the number of items in the bulk pack and press enter. (These should be whole quantities and above 0)
             * tested entering spaces in first prompt, returned You entered an invalid quantity, please enter the number of items in the bulk pack and press enter. (These should be whole quantities and above 0)
             * tested entering -12 in first prompt, returned You entered an invalid quantity, please enter the number of items in the bulk pack and press enter. (These should be whole quantities and above 0)
             * tested entering 1 in first prompt, prompted for next value, moving to test for next area
             * tested entering empty space in this prompt, returned You entered an invalid cost. Please enter a valid cost above $0 and press enter.
             * tested entering cat in this prompt, returned You entered an invalid cost. Please enter a valid cost above $0 and press enter.
             * tested entering spaces in this prompt, returned You entered an invalid cost. Please enter a valid cost above $0 and press enter.
             * tested entering -12 in this prompt, returned You entered an invalid cost. Please enter a valid cost above $0 and press enter.
             * tested entering 1 in this prompt, prompted for next value, moving to test for next area
             * tested entering empty space in this prompt, returned You entered an invalid cost, please enter the cost of the individual item and press enter. (this should be a number above 0)
             * tested entering cat in this prompt, returned You entered an invalid cost, please enter the cost of the individual item and press enter. (this should be a number above 0)
             * tested entering spaces in this prompt, returned You entered an invalid cost, please enter the cost of the individual item and press enter. (this should be a number above 0)
             * tested entering -12 in this prompt, returned You entered an invalid cost, please enter the cost of the individual item and press enter. (this should be a number above 0)
             * tested entering 1 in this prompt, prompted for next value, moving to test for next area
             * tested entering empty space in this prompt, returned
                You entered an invalid response for coupon type. 
                Enter "P" if the coupon is percentage.
                Enter "D" if the coupon is dollar amount.
                After selection press enter.
             * tested entering cat in this prompt, returned
                You entered an invalid response for coupon type. 
                Enter "P" if the coupon is percentage.
                Enter "D" if the coupon is dollar amount.
                After selection press enter.
             * tested entering spaces in this prompt, returned
                You entered an invalid response for coupon type. 
                Enter "P" if the coupon is percentage.
                Enter "D" if the coupon is dollar amount.
                After selection press enter.
             * tested entering -12 in this prompt, returned
                You entered an invalid response for coupon type. 
                Enter "P" if the coupon is percentage.
                Enter "D" if the coupon is dollar amount.
                After selection press enter.
                tested entering p,P,d,D in this prompt, all prompted for next value, moving to test for next area
             * tested entering empty space in this prompt, returned You have entered an invalid value for the coupon. Please enter the dollar amount of your coupon and press enter. (this should be a number above 0)
             * tested entering cat in this prompt, returned You have entered an invalid value for the coupon. Please enter the dollar amount of your coupon and press enter. (this should be a number above 0)
             * tested entering spaces in this prompt, returned You have entered an invalid value for the coupon. Please enter the dollar amount of your coupon and press enter. (this should be a number above 0)
             * tested entering -12 in this prompt, returned You have entered an invalid value for the coupon. Please enter the dollar amount of your coupon and press enter. (this should be a number above 0)
             * tested 1 as value in this prompt for both P and D, moved to give total cost. Test finished.
             * TESTING VALUES
             * first prompt 50, second prompt 100, third prompt 4.5, fourth prompt d, fifth prompt 1, program output: The cost of 1 item in the bulk pack is $2.00, which is cheaper than the cost of the individual item with coupon, which is $3.50. Buy the bulk pack!
             * first prompt 20, second prompt, 80.5, third prompt 6.25, fourth prompt d, fifth prompt 2.25, program output: The cost of 1 item using a coupon is $4.00, which is cheaper than the cost of the individual item from the bulk pack, which is $4.03. Buy the individual item and use the coupon!
             * first prompt 100, second prompt 300, third prompt 4, fourth prompt p, fifth prompt 25, program output: The cost of 1 item in the bulk pack is $3.00, which is the same as the individual item with coupon, which is $3.00. Buy whichever you prefer!
             * first prompt 25, second prompt 40, third prompt 1.75, fourth prompt p, fifth prompt 20, program output: The cost of 1 item using a coupon is $1.40, which is cheaper than the cost of the individual item from the bulk pack, which is $1.60. Buy the individual item and use the coupon!
             */

            //
            // *********** End Problem #2: Let's Make a Deal
            //

            //
            // *********** Problem #3: Pumpkin Patch Pickers
            //

            // Created variables for use in the program
            decimal pumpCost;
            string stringPumpWeight;
            // used decimal for pumpkin weight as it wil be multiplying with a decimal. Did this way rather than later needing to convert it to decimal anyway
            decimal pumpWeight;

            //prompt user for pumpking weight input
            Console.WriteLine("\r\nThank you for using the pumpkin cost calculator!\r\nTo get started, please enter the weight of your pumpkin and press enter.");
            // record user response for pumpking weight
            stringPumpWeight = Console.ReadLine();

            // validate pumpkin weight response and convert to workable number
            while (!(decimal.TryParse(stringPumpWeight, out pumpWeight) && pumpWeight > 0))
            {
                // prompt user there was a problem with their response and ask for question again to be answered
                Console.WriteLine("You have entered an invalid weight. Please enter your pumpkins weight again, and press enter.");
                // record user response
                stringPumpWeight = Console.ReadLine();
            }

            //            Console.WriteLine("Pumpkin weight is: " + pumpWeight + " pumpkin weight * 2 is: " + pumpWeight * 2);

            // Conditional statement to calculate price based on weight. Up to signifies everything below. Since statement will run from top to bottom, no need for lower values, if below 5.5 that will run, if above that, but below 10.75, that will run, etc. 
            if (pumpWeight < (decimal)5.5)
            {
                pumpCost = 1 * pumpWeight;
            }
            else if (pumpWeight < (decimal)10.75)
            {
                pumpCost = (decimal).9 * pumpWeight;
            }
            else if (pumpWeight < 25)
            {
                pumpCost = (decimal).8 * pumpWeight;
            }
            else if (pumpWeight < 50)
            {
                pumpCost = (decimal).7 * pumpWeight;
            }
            else if (pumpWeight <= 100)

            {
                pumpCost = (decimal).6 * pumpWeight;
            }
            else
            {
                pumpCost = (decimal).5 * pumpWeight;
            }

            // output statement telling customer the price of their pumpkin -- used .toString to convert to two decimal places to match money standards
            Console.WriteLine("\r\nYour pumpkin of {0} lbs. costs ${1}.", pumpWeight, (pumpCost).ToString("#,##0.00"));

            /*
             * TESTING
             * tested entering empty space in first prompt, returned You have entered an invalid weight. Please enter your pumpkins weight again, and press enter.
             * tested entering cat in first prompt, returned You have entered an invalid weight. Please enter your pumpkins weight again, and press enter.
             * tested entering spaces in first prompt, returned You have entered an invalid weight. Please enter your pumpkins weight again, and press enter.
             * tested entering -12 in first prompt, returned You have entered an invalid weight. Please enter your pumpkins weight again, and press enter.
             * tested entering 5.5, expect 5.5 lbs to multiply by .8 and give answer of 8.6 program returned Your pumpkin of 10.75 lbs. costs $8.600.
             * tested entering 10.75, expect 10.75 lbs to multiply by .9 and give answer of 4.95 program returned Your pumpkin of 5.5 lbs. costs $4.95.
             * tested entering 4.5, program returned, Your pumpkin of 4.5 lbs. costs $4.50.
             * tested entering 10, program returned, Your pumpkin of 10 lbs. costs $9.00.
             * tested entering 20.75, program returned, Your pumpkin of 20.75 lbs. costs $16.60.
             * tested entering 40, program returned, Your pumpkin of 40 lbs. costs $28.00.
             * tested entering 100, program returned, Your pumpkin of 100 lbs. costs $60.00.
             * tested entering 150.3, program returned, Your pumpkin of 150.3 lbs. costs $75.15.
             */

            //
            // *********** End Problem #3: Pumpkin Patch Pickers
            //

            //
            // *********** Problem #4: Loyalty Card
            //

            // create variables to be used in the program
            string stringFirstItem;
            string stringSecondItem;
            decimal firstItem;
            decimal secondItem;
            string prefMember;
            decimal totalCost;

            // prompt user for cost of first item
            Console.WriteLine("\r\nThank you for using our Store calculator.\r\n\r\nPlease enter the cost of the first item and press enter");
            // record user response
            stringFirstItem = Console.ReadLine();

            // validate user response is a number and above 0 and output to decimal variable
            while (!(decimal.TryParse(stringFirstItem, out firstItem) && firstItem > 0))
            {
                // prompt user their response was invalid and ask again
                Console.WriteLine("You have entered an invalid value for your first item. Please enter the cost of your first item, and press enter");
                // record user response
                stringFirstItem = Console.ReadLine();
            }
            //            Console.WriteLine("The first item * 2 is: " + firstItem*2);

            // prompt user for cost of second item
            Console.WriteLine("\r\nPlease enter the cost of the second item and press enter");
            // record user response
            stringSecondItem = Console.ReadLine();

            // validate user response is a number and above 0 and output to decimal variable
            while (!(decimal.TryParse(stringSecondItem, out secondItem) && secondItem > 0))
            {
                // prompt user their response was invalid and ask again
                Console.WriteLine("You have entered an invalid value for your second item. Please enter the cost of your second item, and press enter");
                // record user response
                stringSecondItem = Console.ReadLine();
            }
            //            Console.WriteLine("The second item * 2 is : " + secondItem*2);

            // prompt user for preferred member status
            Console.WriteLine("\r\nAre you a Preferred Member?\r\nEnter \"Y\" for yes\r\nEnter \"N\" for no\r\nAfter your response, press enter.");
            // record user response
            prefMember = Console.ReadLine();

            // validate user response to equal either y or n corresponding to yes or no status as preferred member
            while (string.IsNullOrWhiteSpace(prefMember) || (!(prefMember.ToLower() == "y" || prefMember.ToLower() == "n")))
            {
                // prompt user their response was invalid and ask again
                Console.WriteLine("You have entered an invalid response to the question, please try again.\r\nEnter \"Y\" for yes\r\nEnter \"N\" for no\r\nAfter your response, press enter.");
                // record user input
                prefMember = Console.ReadLine();
            }

            // conditional statement for price total of products for member or not a member. Responses have already been validated.
            // first statement will apply membership discount if they answered yes to being a member, else it won't and just give total without the discount -- used .ToString to convert to money with 2 decimal places
            if (prefMember.ToLower() == "y")
            {
                totalCost = (firstItem + secondItem) * (decimal).85;
                Console.WriteLine("Your total purchase is ${0}, which includes your 15% discount.", (totalCost).ToString("#,##0.00"));
            }
            else
            {
                totalCost = firstItem + secondItem;
                Console.WriteLine("Your total purchase is ${0}.", (totalCost).ToString("#,##0.00"));
            }

            /*
             * TESTING
             * tested entering empty space in first/second prompt, returned You have entered an invalid value for your first/second item. Please enter the cost of your first/second item, and press enter
             * tested entering cat in first/second prompt, returned You have entered an invalid value for your first/second item. Please enter the cost of your first/second item, and press enter
             * tested entering spaces in first/second prompt, returned You have entered an invalid value for your first/second item. Please enter the cost of your first/second item, and press enter
             * tested entering -12 in first/second prompt, returned You have entered an invalid value for your first/second item. Please enter the cost of your first/second item, and press enter
             * tested entering 1 in first/second prompt, accepted and moved to next portion, moving to next test entered y,Y returned Your total purchase is $1.70, which includes your 15% discount.
             * tested entering 1 in first/second prompt, accepted and moved to next portion, moving to next test entered n,N returned Your total purchase is $2.00.
             * tested 45.5 first prompt, 75 second prompt, y third prompt, returned Your total purchase is $102.43, which includes your 15% discount.
             * tested 23 first prompt, 44.25 second prompt, y third prompt, returned Your total purchase is $57.16, which includes your 15% discount.
             * The pdf for data sets to test gives an incorrect value for the Results section for this test. It asks for preferred member status as a yes, but then gives the non preferred member status. Running the test without preferred member status as well for that result
             * tested 23 first prompt, 44.25 second prompt, n third prompt, returned Your total purchase is $67.25.
             * tested 73 for first prompt, 12.15 second prompt, y third prompt, returned Your total purchase is $72.38, which includes your 15% discount.
             */
        }
    }
}
