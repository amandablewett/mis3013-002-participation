using System;

namespace P2_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Amanda Blewett";

            Console.WriteLine("Pick heads or tails >>");
            string coin = Console.ReadLine().ToLower();

            Random rand = new Random();
            int randomNumber = rand.Next(1,3);
            string random;
            if (randomNumber == 1)
            {
                random = "heads";
            }
            else
            {
                random = "tails";
            }

            if (coin == random)
            {
                Console.WriteLine($"Congrats! You were right! It was {random}!");
            }
            else
            {
                Console.WriteLine($"Sorry! You were wrong! It was actually {random}!");
            }

            Console.WriteLine($"The developer's name is {name}");

        }
    }
}
