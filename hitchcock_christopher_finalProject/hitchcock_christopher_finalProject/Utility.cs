using System;

namespace hitchcock_christopher_finalProject
{
    public class Utility
    {
        public static void AnyKey(string message)
        {
            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }

        public static string ColorCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
            return message;
        }
        public static string ColorGrey(string message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(message);
            Console.ResetColor();
            return message;
        }
        
        public static string ColorBlue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
            return message;
        }
        public static string ColorRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
            return message;
        }
    }
}