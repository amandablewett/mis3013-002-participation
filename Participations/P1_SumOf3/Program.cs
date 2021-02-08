using System;

namespace P1_SumOf3
{
    class Program
    {
        //static double newVariable = 5;
        static void Main(string[] args)
        {
            const double constant = 7.777; //local constant variable


            Console.WriteLine($"Please enter a number >>");
            string answer1 = Console.ReadLine();
            double num1 = Convert.ToDouble(answer1);

            Console.WriteLine($"Please enter another number >>");
            string answer2 = Console.ReadLine();
            double num2 = Convert.ToDouble(answer2);

            Console.WriteLine($"Please enter one last number >>");
            string answer3 = Console.ReadLine();
            double num3 = Convert.ToDouble(answer3);

            double sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of your numbers is " + sum.ToString("N3"));

            double mult = sum * constant;
            Console.WriteLine($"The product of this sum and our constant value is " + mult.ToString("N3"));
        }
    }
}
