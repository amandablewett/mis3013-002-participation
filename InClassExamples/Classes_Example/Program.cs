using System;

namespace Classes_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 5;
            //rect.Width = 7;
            double area = rect.CalculateArea();
            Rectangle rect1 = new Rectangle(8, 9);
            double per = rect1.CalculatePerimeter();
            Console.WriteLine($"Rectangle 1: W: {rect.Width}, L: {rect.Length}, A: {area}, P: {rect.CalculatePerimeter()}");
            Console.WriteLine($"Rectangle 2: W: {rect1.Width}, L: {rect1.Length}, A: {rect1.CalculateArea()}, P: {per}");


        }
    }
}
