using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your favorite # (whole numbers only) >>");
            string answer = Console.ReadLine();
            int luckynumber;
            bool isInt = int.TryParse(answer, out luckynumber);
            if (isInt == false)
            {
                Console.WriteLine($"{answer} is not a valid integer. Goodbye!");
                Environment.Exit(-1);
                //return; = another way to exit the application
            }
            //luckynumber = Convert.ToInt32(Console.ReadLine());

            if (luckynumber % 7 == 0)
            {
                Console.WriteLine($"{luckynumber} is a lucky number!");
            }
            else if (luckynumber % 13 == 0)
            {
                Console.WriteLine($"{luckynumber} is a really unlucky number!");
            }
            else
            {
                Console.WriteLine($"{luckynumber}");
            }

            Console.WriteLine("What is your favorite type of pet? >>");
            answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "dog":
                    Console.WriteLine("Cool me too!");
                    break;
                case "cat":
                    Console.WriteLine("If you say so...");
                    break;
                default:
                    Console.WriteLine($"Who would ever have a pet {answer}?!?");
                    break;
            }
        }
    }
}
