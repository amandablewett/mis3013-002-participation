using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 3;
        }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
