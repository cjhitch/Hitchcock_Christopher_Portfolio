using System;

namespace CustomClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create our first box
            // call constructor function
            Box firstBox = new Box(5,5,5,"red");
            
            Box secondBox = new Box(6,7,8,"blue");
            
            // can we access the member variables directly?
            /* NOPE!!!!!!!!!!!!!!
            Console.WriteLine(firstBox.mLength);
            */
            
            // access the information about the box
            // getter method
            // create this in the custom class file
            Console.WriteLine("The height of our first box is: "+firstBox.GetHeight());
            Console.WriteLine("The width of our first box is: "+firstBox.GetWidth());
            Console.WriteLine("The length of our first box is: "+firstBox.GetLength());
            Console.WriteLine("The color of our first box is: "+firstBox.GetColor().ToUpper());
            
            Console.WriteLine("The height of our second box is: "+secondBox.GetHeight());
            Console.WriteLine("The width of our second box is: "+secondBox.GetWidth());
            Console.WriteLine("The length of our second box is: "+secondBox.GetLength());
            Console.WriteLine("The color of our second box is: "+secondBox.GetColor().ToUpper());
            
            firstBox.SetHeight(10);
            
            Console.WriteLine("\r\nThe height of our first box after the setter is: "+firstBox.GetHeight());
            
            // change the value of the height of our second box
            
            secondBox.SetHeight(-12);
            
            Console.WriteLine("The height of our second box after the setter is: "+secondBox.GetHeight());
            
            firstBox.SetWidth(8);
            firstBox.SetLength(4);
            firstBox.SetColor("orange");
            
            Console.WriteLine("The width of our first box after the setter is: "+firstBox.GetWidth());
            Console.WriteLine("The length of our first box after the setter is: "+firstBox.GetLength());
            Console.WriteLine("The color of our first box after the setter is: "+firstBox.GetColor());
            
        }
    }
}
