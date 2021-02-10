using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const string developer = "Amanda Blewett";
            Random rand = new Random();
            int randomNum = rand.Next(1, 101);

            if (randomNum % 3 == 0 && randomNum % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (randomNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (randomNum % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else
            {
                Console.WriteLine(randomNum);
            }

            Console.WriteLine($"Developed by {developer}");
        }
    }
}
