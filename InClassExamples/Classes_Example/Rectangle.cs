using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Rectangle
    {
        /*private double Length;
        private double width;

        public double getLength()
        {
            return Length;
        }

        public void setLength(double length)
        {
            Length = length;
        }
        */

        public double Length { get; set; }
        public double Width { get; }

        public Rectangle()
        {
            Length = 7;
            Width = 7;
        }
        public Rectangle(double length, double Width)
        {
            Length = length;
            this.Width = Width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return (Length * 2) + (Width * 2);
        }
    }
}
