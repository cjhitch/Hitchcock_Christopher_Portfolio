using System;

namespace hitchcock_christopher_finalProject
{
    public class Validation
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("This cannot be blank!\r\n");
                Console.ResetColor();
                Console.Write(message);
                input = Console.ReadLine();
            }
            return input;
        }
        // validate for a yes or no response
        public static string GetString(string message, bool yesNo)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(input) && (input != "y" || input != "n"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("This cannot be blank, and must be either \"Y\" or \"N\".\r\n");
                Console.ResetColor();
                Console.Write(message);
                input = Console.ReadLine();
            }
            return input;
        }
        public static decimal GetDecimal(string message, int min)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            decimal output = -1;
            while (!((decimal.TryParse(input, out output)) && output >= min))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You have entered an invalid value, must be a number and greater than 0.\r\n");
                Console.ResetColor();
                Console.Write(message);
                input = Console.ReadLine();
            }
            return output;
        }
    }
}