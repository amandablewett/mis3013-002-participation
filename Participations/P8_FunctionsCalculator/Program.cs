using System;

namespace P8_FunctionsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Amanda Blewett", "MIS 3013", "03/31/2021");
            double one, two;
            double res = 0.0;
            do
            {
                Console.WriteLine("Would you like to perform a new calculation (1) or use your previous result in a follow-up calculation? (2)");
                int ans = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What type of calculation would you like to perform? Type in a number>> \t1)Add\t2)Subtract\t3)Multiply\t4)Divide");
                int calc = Convert.ToInt32(Console.ReadLine());
                
                if (ans == 1)
                {
                    Console.WriteLine("What is your first number?");
                    one = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is your second number?");
                    two = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    one = res;
                    Console.WriteLine("What is your second number?");
                    two = Convert.ToInt32(Console.ReadLine());
                }
                res = result(calc, one, two);
                Console.WriteLine($"Your result is {res}.");
            } while (YorN());
            Console.WriteLine("Thank you for using my service!");
        }

        static void DeveloperInformation(string developerName, string className, string date)
        {
            Console.WriteLine($"{developerName} from the {className} class wrote this application on {date}.");
        }

        static double Add (double one, double two)
        {
            return one + two;
        }
        static double Subtract (double one, double two)
        {
            return one - two;
        }
        static double Multiply (double one, double two)
        {
            return one * two;
        }
        static double Divide (double one, double two)
        {
            return one / two;
        }
        static bool YorN()
        {
            Console.WriteLine("Do you want to continue? Please type Yes or No >>");
            string ans = Console.ReadLine().ToLower();
            if (ans[0] == 'y')
            {
                return true;
            }
            return false;
        }

        static double result(int calc, double one, double two)
        {
            if(calc == 1)
            {
                return Add(one,two);
            }
            if(calc == 2)
            {
                return Subtract(one, two);
            }
            if (calc == 3)
            {
                return Multiply(one, two);
            }
            return Divide(one, two);

        }
    }
}
