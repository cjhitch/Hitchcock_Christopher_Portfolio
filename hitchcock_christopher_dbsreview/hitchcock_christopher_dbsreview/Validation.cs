using System;

namespace hitchcock_christopher_dbsreview
{
    public class Validation
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("This cannot be blank! \r\n" + message);
                input = Console.ReadLine();
            }
            return input;
        }
    }
}