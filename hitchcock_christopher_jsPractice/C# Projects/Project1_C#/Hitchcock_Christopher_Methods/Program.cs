using System;

namespace Hitchcock_Christopher_Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // *************************************************************************************************************************************************************
            // Problem #1 - Currency Converter
            // *************************************************************************************************************************************************************

            // declare variables for program
            string stringEuroVal;
            decimal euroVal;

            // prompt user for value
            Console.WriteLine("Welcome to the currency converter. This program will convert your Euros to American Dollars.\r\nPlease enter the value of your Euros and press enter.");
            // record user response
            stringEuroVal = Console.ReadLine();

            // validation loop for currency and above 0
            while (!(decimal.TryParse(stringEuroVal, out euroVal) && euroVal > 0))
            {
                // prompt user they gave an invalid input and ask again for value
                Console.WriteLine("You have entered an invalid value for Euros. Please enter the value of your Euros and press enter. (This should be a number above 0)");
                stringEuroVal = Console.ReadLine();
                // record user response
            }
            // declaring variable to capture results from problem #1 function - this is also firing the function
            decimal currencyResults = CurrencyConverter(euroVal);
            // print out the results from running the function with the users' parameter - looked up the euro symbol on google for c#
            Console.WriteLine("\u20AC{0} euros converted to dollars is ${1}.", euroVal.ToString("#,##0.00"), currencyResults.ToString("#,##0.00"));


            /*
             * TESTING
             * tested entering cat, empty, spaces, 0, -12 for user prompt, returned You have entered an invalid value for Euros. Please enter the value of your Euros and press enter. (This should be a number above 0)
             * tested 5.5 for first user prompt, returned €5.50 euros converted to dollars is $6.38.
             * tested 15.32 for first user prompt, returned €15.32 euros converted to dollars is $17.77.
             * tested 35123456789 for first user prompt, returned €35,123,456,789.00 euros converted to dollars is $40,743,209,875.24.
             */

            // *************************************************************************************************************************************************************
            // End Problem #1 - Currency Converter
            // *************************************************************************************************************************************************************

            // *************************************************************************************************************************************************************
            // Problem #2 - Astronomical
            // *************************************************************************************************************************************************************

            // declare variables for problem
            string stringWeight;
            double weight;
            string stringPlanet;
            int planet;
            string[] planetNames = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };

            // welcome user and prompt for weight
            Console.WriteLine("\r\nLet's find out your weight on other planets!\r\nFirst enter your current weight on Earth and press enter.");
            // record users' weight
            stringWeight = Console.ReadLine();

            // validate user gave a number and is above 0
            while (!(double.TryParse(stringWeight, out weight) && weight > 0))
            {
                // prompt user they gave an invalid response
                Console.WriteLine("You have entered an invalid weight. Please enter your weight and press enter. (this should be a number above 0)");
                // capture user response
                stringWeight = Console.ReadLine();
            }

            // prompt user to find out what planet they want to know their weight on
            Console.WriteLine("To find out a what you weight on a specific planet:\r\nEnter \"1\" for Mercury\r\nEnter \"2\" for Venus\r\nEnter \"3\" for Earth\r\nEnter \"4\" for Mars\r\nEnter \"5\" for Jupiter\r\nEnter \"6\" for Saturn\r\nEnter \"7\" for Uranus\r\nEnter \"8\" for Neptune\r\nEnter \"9\" for Pluto (because everyone knows Pluto should still be classified as a planet)");
            // record user response
            stringPlanet = Console.ReadLine();

            // validate user response is a valid integer from 1-9
            while (!(int.TryParse(stringPlanet, out planet) && planet > 0 && planet < 10))
            {
                // prompt user invalid response and ask question again
                Console.WriteLine("You have given an invalid response to the planet picked. \r\nEnter \"1\" for Mercury\r\nEnter \"2\" for Venus\r\nEnter \"3\" for Earth\r\nEnter \"4\" for Mars\r\nEnter \"5\" for Jupiter\r\nEnter \"6\" for Saturn\r\nEnter \"7\" for Uranus\r\nEnter \"8\" for Neptune\r\nEnter \"9\" for Pluto (because everyone knows Pluto should still be classified as a planet)");
                // record user response
                stringPlanet = Console.ReadLine();
            }

            // record results from function in variable
            double planetResults = AstronomicalConverter(weight, planet);

            // conditional statement for results -- I wanted to check if the user was using Earth and give that result, and then a different result if anything else.
            if (planet == 3)
            {
                Console.WriteLine("You gave a weight of {0} lbs. and a planet of {1} which means you weight exactly the same, because you are on Earth!", weight, planetNames[planet - 1]);
            }
            else
            {
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", weight, planetNames[planet - 1], planetResults);
            }

            /*
             * TESTING
             * tested entering cat, empty, spaces, 0, -12 for first user prompt, returned You have entered an invalid weight. Please enter your weight and press enter. (this should be a number above 0)
             * tested entering cat, empty, spaces, 0, 10, -12 for first user prompt, returned
             *   You have given an invalid response to the planet picked. 
             *   Enter "1" for Mercury
             *   Enter "2" for Venus
             *   Enter "3" for Earth
             *   Enter "4" for Mars
             *   Enter "5" for Jupiter
             *   Enter "6" for Saturn
             *   Enter "7" for Uranus
             *   Enter "8" for Neptune
             *   Enter "9" for Pluto (because everyone knows Pluto should still be classified as a planet)
             * tested entering 160 for first prompt, 6 for second prompt, returned On Earth you weigh 160 lbs, but on Saturn you would weigh 148.8 lbs.
             * tested entering 210 for first prompt, 10 for second prompt *** This is different than the normal test variable -- I included Pluto which made 9 a valid response, so I went 1 higher to 10 *** returned,
             * You have given an invalid response to the planet picked. 
             * Enter "1" for Mercury
             * Enter "2" for Venus
             * Enter "3" for Earth
             * Enter "4" for Mars
             * Enter "5" for Jupiter
             * Enter "6" for Saturn
             * Enter "7" for Uranus
             * Enter "8" for Neptune
             * Enter "9" for Pluto (because everyone knows Pluto should still be classified as a planet)
             * after re-prompt entered 5 and program returned On Earth you weigh 210 lbs, but on Jupiter you would weigh 491.4 lbs.
             * Tested entering 645.23 for first prompt, 9 for next prompt, returned On Earth you weigh 645.23 lbs, but on Pluto you would weigh 38.7138 lbs.
             * Tested entering 120 for first prompt, 3 for next prompt, returned You gave a weight of 120 lbs. and a planet of Earth which means you weight exactly the same, because you are on Earth!
             */

            // *************************************************************************************************************************************************************
            // End Problem #2 - Astronomical
            // *************************************************************************************************************************************************************

            // *************************************************************************************************************************************************************
            // Problem #3 - Subtraction
            // *************************************************************************************************************************************************************

            // declare variables for program
            // variables for first test
            double[] array0 = new double[] { 4, 65, 32, 42, 12 };
            double[] array1 = new double[] { 1, 2, 5, 6, 9 };
            // variables for second test
            //            double[] array0 = new double[] {54,125,96,72,45,67};
            //            double[] array1 = new double[] {87,122,145,65,3,800};
            // variables for third test
            //            double[] array0 = new double[] {120,3480,1.2,70462,18,1.8,42,6432879,-1.3};
            //            double[] array1 = new double[] {120,3,43.67,182346,16.98,13,19.256,1248679,-3.6};
            // empty array for collection of functioned values
            double[] arrayFinal = new double[array0.Length];

            Console.WriteLine("\r\nThe final value of the subtraction of arrays is:");
            arrayFinal = ArraySubtraction(array0, array1);
            for (int i = 0; i < array0.Length; i++)
            {
                
                Console.WriteLine("{0}-{1} is {2}", array0[i], array1[i], arrayFinal[i]);
            }

            /*
             * Variables are in the problem above commented out for all except the initial test
             * 
             * ran first set of test variables, program returned :
             * The final value of the subtraction of arrays is:
             * 4-1 is 3
             * 65-2 is 63
             * 32-5 is 27
             * 42-6 is 36
             * 12-9 is 3
             * 
             * commented out the first set and uncommented second set, program returned :
             * The final value of the subtraction of arrays is:
             * 54-87 is -33
             * 125-122 is 3
             * 96-145 is -49
             * 72-65 is 7
             * 45-3 is 42
             * 67-800 is -733
             * 
             * commented out second set and uncommented third set, program returned :
             * 120-120 is 0
             * 3480-3 is 3477
             * 1.2-43.67 is -42.47
             * 70462-182346 is -111884
             * 18-16.98 is 1.02
             * 1.8-13 is -11.2
             * 42-19.256 is 22.744
             * 6432879-1248679 is 5184200
             * -1.3--3.6 is 2.3
             *
             * Tested values with calculator. Calculations are correct.
             */

            // *************************************************************************************************************************************************************
            // End Problem #3 - Subtraction
            // *************************************************************************************************************************************************************

        }

        // *****************************************************************************************************************************************************************
        // Function for Problem #1
        // *****************************************************************************************************************************************************************

        public static decimal CurrencyConverter(decimal val1)
        {
            decimal euroOutput = val1 * (decimal)1.16;
            return euroOutput;
        }

        // *****************************************************************************************************************************************************************
        // End Function for Problem #1
        // *****************************************************************************************************************************************************************

        // *****************************************************************************************************************************************************************
        // Function for Problem #2
        // *****************************************************************************************************************************************************************

        public static double AstronomicalConverter(double weight1, int planet)
        {
            double planetWeight;

            if (planet == 1)
            {
                planetWeight = weight1 * .38;
            }
            else if (planet == 2)
            {
                planetWeight = weight1 * .91;
            }
            else if (planet == 3)
            {
                planetWeight = weight1;
            }
            else if (planet == 4)
            {
                planetWeight = weight1 * .38;
            }
            else if (planet == 5)
            {
                planetWeight = weight1 * 2.34;
            }
            else if (planet == 6)
            {
                planetWeight = weight1 * .93;
            }
            else if (planet == 7)
            {
                planetWeight = weight1 * .92;
            }
            else if (planet == 8)
            {
                planetWeight = weight1 * 1.12;
            }
            else
            {
                planetWeight = weight1 * .06;
            }
            return planetWeight;
        }

        // *****************************************************************************************************************************************************************
        // End Function for Problem #2
        // *****************************************************************************************************************************************************************

        // *****************************************************************************************************************************************************************
        // Function for Problem #3
        // *****************************************************************************************************************************************************************

        public static double[] ArraySubtraction(double[] ar1, double[] ar2)
        {
            double[] arrayFinal = new double[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                arrayFinal[i] = ar1[i] - ar2[i];
            }

            return arrayFinal;
        }

        // *****************************************************************************************************************************************************************
        // Function for Problem #3
        // *****************************************************************************************************************************************************************
    }
}
