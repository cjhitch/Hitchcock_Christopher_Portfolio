using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClass
{
    class Box
    {
        // properties of the box class go here
        // variables for the box -- member variables typically start with m
        int mLength;
        int mWidth;
        int mHeight;
        string mColor;

        // constructor function -- (main method)
        // add parameters for the member variables
        public Box (int _length, int _width, int _height, string _color)
        {
            mLength = _length;
            mWidth = _width;
            mHeight = _height;
            mColor = _color;
        }
        
        // create getter method for the height of the cube
        // getter should always be public
        // create getter methods for each member variables
        public int GetHeight()
        {
            return mHeight;
        }

        public int GetLength()
        {
            return mLength;
        }

        public int GetWidth()
        {
            return mWidth;
        }

        public string GetColor()
        {
            return mColor;
        }

        public void SetHeight(int _height)
        {
            // add a condition to test if negative
            if (_height > 0)
            {
                // change the value of the member variable
                mHeight = _height;
            }
            else
            {
                // alert user
                Console.WriteLine("This value can not be negative \r\nPlease try again.");
            }
        }
        
        public void SetWidth(int _width)
        {
            // change the value of the member variable
            mWidth = _width;
        }
        
        public void SetLength(int _length)
        {
            // change the value of the member variable
            mLength = _length;
        }
        
        public void SetColor(string _color)
        {
            // change the value of the member variable
            mColor = _color;
        }
        
        // create a custom method
        public int BoxVolume()
        {
            
        }
        
    }
}
