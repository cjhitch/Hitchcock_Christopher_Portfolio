using System;

namespace Hitchcock_Christopher_LogicLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            //  Problem #1 - Logical Operators: Making the Grade
            //

            // Create variables for program -- set initializer to index 0
            string[] stringUserGrade = new string[2];
            double[] userGrade = new double[2];

            // prompt user for first grade
            Console.WriteLine("Use this program to find out whether you are passing or not\r\nEnter your first grade and press enter.");
            // record users response
            stringUserGrade[0] = Console.ReadLine();
            
            // validate user gave a number response from 0 to 100 and output in double form 
            while (!(double.TryParse(stringUserGrade[0], out userGrade[0]) && userGrade[0] >= 0 && userGrade[0] <= 100))
            {
                // prompt user they entered an incorrect response and ask again for grade
                Console.WriteLine("You have entered an invalid grade. Please enter your first grade and press enter. (a valid grade is from 0 to 100)");
                // record user response
                stringUserGrade[0] = Console.ReadLine();
            }
            
            // prompt user for second grade
            Console.WriteLine("\r\nEnter your second grade and press enter.");
            // record user response
            stringUserGrade[1] = Console.ReadLine();

            // validate user gave a number response from 0 to 100 and output in double form
            while (!(double.TryParse(stringUserGrade[1], out userGrade[1]) && userGrade[1] >= 0 && userGrade[1] <= 100 ))
            {
                // prompt user they entered an incorrect response and ask again for grade
                Console.WriteLine("You have entered an invalid grade. Please enter your second grade and press enter. (a valid grade is from 0 to 100)");
                // record user response
                stringUserGrade[1] = Console.ReadLine();
            }

            // conditional to check whether grade 1 and grade 2 are at least 70. if they are give them passing console, if either is below, give failing console
            if ((userGrade[0] >= 70) && (userGrade[1] >= 70))
            {
                Console.WriteLine("Congrats, both grades are passing!");
            }
            else
            {
                Console.WriteLine("One or more grades are failing, try harder next time!");
            }
            

            //
            //  End Problem #1 - Logical Operators: Making the Grade
            //
            
            /*
             * TESTING
             * tested entering cat, spaces, empty, -12, 101 for both first and second grade, returned You have entered an invalid grade. Please enter your first/second grade and press enter. (a valid grade is from 0 to 100)
             * tested 95 for first prompt, 85 for second prompt, program returned Congrats, both grades are passing!
             * tested 82 for first prompt, 68 for second prompt, program returned One or more grades are failing, try harder next time!
             * tested Eighty for first prompt, program returned You have entered an invalid grade. Please enter your first grade and press enter. (a valid grade is from 0 to 100), entered numeric 80, 91 for second prompt, program returned Congrats, both grades are passing!
             * tested 70 for first prompt, 70 for second prompt, program returned Congrats, both grades are passing!
             */

        }
    }
}
