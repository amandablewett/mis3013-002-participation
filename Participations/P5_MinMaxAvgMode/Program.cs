using System;
using System.Collections.Generic;

namespace P5_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            string more = "yes";
            List<double> grades = new List<double>();
            

            do
            {
                Console.WriteLine("Please enter an exam grade >>");
                grades.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Do you have another exam grade you need to submit?");
                more = Console.ReadLine().ToLower();
            } while (more[0] == 'y');

            double sum = 0;
            double avg;
            double min = 200;
            double max = 0;
            double mode = 0;
            int count;
            int maxCount = 0;
            List<double> modes = new List<double>();

            for (int i = 0; i < grades.Count; i++)
            {
                double num = grades[i];
                sum += num;
                if(num > max)
                {
                    max = num;
                }
                if(num < min)
                {
                    min = num;
                }
                count = 0;
                for (int x = 0; x < grades.Count; x++)
                {
                    if(grades[x] == num)
                    {
                        count++;
                    }
                }
                if (count>maxCount)
                {
                    maxCount = count;
                    mode = num;
                }
            }
            avg = sum / grades.Count;
            Console.WriteLine($"Your minimum score was {min}\nYour maximum score was {max}\nYour average score was {avg.ToString("n2")}\nAnd your mode score was {mode}");
        }
    }
}
