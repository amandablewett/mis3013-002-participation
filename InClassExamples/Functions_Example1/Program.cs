using System;
using System.Collections.Generic;

namespace Functions_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gpas = new List<double>();

            do
            {
                gpas.Add(ValidateDouble("Please enter a GPA >>"));
                
            } while (AskUserToContinue());

            List<double> itemPrices = new List<double>();

            do
            {
                itemPrices.Add(ValidateDouble("Please enter an item price >>"));
      
            } while (AskUserToContinue());
        }

        private static bool AskUserToContinue()
        {
            Console.WriteLine("Do you want to go again? Yes or No >>");
            string answer = Console.ReadLine().ToLower();
            while(answer != "yes" && answer != "no")
            {
                Console.WriteLine("Sorry, you should just answer yes or no");

                Console.WriteLine("Do you want to go again? Yes or No >>");
                answer = Console.ReadLine().ToLower();
            }
            if (answer == "yes")
            {
                return true;
            }
            return false;
        }

        static double ValidateDouble(string message)
        {
            double value;
            string answer;
            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();
            }while (!double.TryParse(answer, out value));

            return value;
        }
    }
}
