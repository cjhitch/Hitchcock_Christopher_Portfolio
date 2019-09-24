using System;

namespace hitchcock_christopher_finalProject
{
    public class Utility
    {
        public static void AnyKey(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}