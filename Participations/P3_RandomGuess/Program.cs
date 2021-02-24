using System;

namespace P3_RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a minimum value >>");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a maximum value >>");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int r = rand.Next(min, max + 1);
            int g = 0;
            string guess = "";
            while (g != r)
            {
                //int rand = (random.Next() % max) + min;
                //Console.WriteLine(r + " is the number");
                Console.WriteLine("Guess the random number >>");
                guess = Console.ReadLine();
                if (Int32.TryParse(guess, out g) == false)
                {
                    Console.WriteLine("Incorrect value. You must enter an integer.");
                }
            }

            Console.WriteLine("Congrats! You guessed it!");
        }
    }
}
