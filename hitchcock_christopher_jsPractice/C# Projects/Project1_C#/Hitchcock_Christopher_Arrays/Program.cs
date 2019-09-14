using System;

namespace Hitchcock_Christopher_Arrays
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
            Arrays
            */

            int[] firstArray = new int[4];
            firstArray[0] = 34;
            firstArray[1] = 20;
            firstArray[2] = 91;
            firstArray[3] = 49;

            double[] secondArray = new double[4] { 42, 120.30, 210.20, 32.50 };

            //
            // Sum Of The Two Arrays
            //
            //Add all values of array together and console log to get total
            int sumArrayOne = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];
            //Get length of Array for division in next problem
            int arrayOneLength = firstArray.Length;
            Console.WriteLine("Sum of Array One: " + sumArrayOne);
            Console.WriteLine("Array One's Length: " + arrayOneLength);

            //Add all values of array together and console log to get total
            double sumArrayTwo = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];
            //Get length of Array for division in next problem
            int arrayTwoLength = secondArray.Length;
            Console.WriteLine("Sum of Array Two: " + sumArrayTwo);
            Console.WriteLine("Array Two's Length: " + arrayTwoLength);
            // Adding line breaks to give console a bit more readability
            Console.WriteLine("\r\n");

            //
            // Average of The Two Arrays
            //
            //Use variable of total and divide by array's length 
            double avgArrayOne = Convert.ToDouble(sumArrayOne) / arrayOneLength;
            Console.WriteLine("Average of Array One: " + avgArrayOne);

            //Use variable of total and divide by array's length
            double avgArrayTwo = sumArrayTwo / arrayTwoLength;
            Console.WriteLine("Average of Array Two: " + avgArrayTwo);
            // Adding line breaks to give console a bit more readability
            Console.WriteLine("\r\n");

            //
            // Combined Array
            //
            // Create new array and assign the value of each -- Each of firstarray must be converted to double so it can be added to the secondarray
            double[] newCombinedArray = new double[4] {Convert.ToDouble(firstArray[0])+secondArray[0], Convert.ToDouble(firstArray[1]) + secondArray[1], Convert.ToDouble(firstArray[2]) + secondArray[2], Convert.ToDouble(firstArray[3]) + secondArray[3] };
            //Console Write the values of each new array value
            Console.WriteLine("New Combined Array Value in Index 0: " + newCombinedArray[0]);
            Console.WriteLine("New Combined Array Value in Index 1: " + newCombinedArray[1]);
            Console.WriteLine("New Combined Array Value in Index 2: " + newCombinedArray[2]);
            Console.WriteLine("New Combined Array Value in Index 3: " + newCombinedArray[3]);
            // Adding line breaks to give console a bit more readability
            Console.WriteLine("\r\n");

            //Declare and Define The String Array
            string[] MixedUp = new string[] { "universe is winning.", "erse trying to produce bigger an", "between software engineers striving to build bigger ", "d better idiots. So far, the ", "Programming today is a race ", "and better idiot-proof programs, and the univ" };

            //New string using the array to reorder the sentence into correct order
            string fixedSentence = MixedUp[4] + MixedUp[2] + MixedUp[5] + MixedUp[1] + MixedUp[3] + MixedUp[0];
            Console.WriteLine(fixedSentence);

        }
    }
}
