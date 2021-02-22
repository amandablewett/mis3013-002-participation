using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWhileExample();
            ForLoopExample();
            WhileExample();
        }

        private static void WhileExample()
        {
            /* int i = 3;
             while (i <= 1000)
             {
                 Console.WriteLine(i);
                 i += 3;
             } */

            int favNum;
            Console.WriteLine("What's your favorite number?");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out favNum) == false)
            {
                Console.WriteLine("Incorrect value. You must enter an integer.>>");
                answer = Console.ReadLine();
            }
        }

        private static void DoWhileExample()
        {
            string userAnswer = "";
            do
            {
                Console.WriteLine("Knock knock. Who's there?");
                userAnswer = Console.ReadLine();
            } while (userAnswer.ToLower() != "banana");
        }

        private static void ForLoopExample()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " is a multiple of 3.");
                }
            }
        }
    }
}
