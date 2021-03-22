using System;
using System.Collections.Generic;

namespace AllCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] C = courses();

            List<double> G = grades();

            Dictionary<string, List<double>> all = new Dictionary<string, List<double>>();
            all.Add("MIS3013", new List<double>());
            all["MIS3013"].Add(0.9);
            all["MIS3013"].Add(0.8);
            all["MIS3013"].Add(0.75);
            all.Add("MKT3033", new List<double>());
            all["MKT3033"].Add(0.95);
            all["MKT3033"].Add(0.65);
            all["MKT3033"].Add(0.8);
            all.Add("MIS3053", new List<double>());
            all["MIS3053"].Add(0.97);
            all["MIS3053"].Add(0.83);
            all["MIS3053"].Add(0.9);
            foreach (string course in all.Keys)
            {
                double sum = 0;
                foreach (double grade in all[course])
                {
                    sum += grade;
                }
                Console.WriteLine($"The average of grades in {course} is {(sum / 3).ToString("P2")}");
            }
           

        }

        private static string[,] courses()
        {
            string[,] courses = new string[3, 2];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("What course subject name?");
                courses[i, 0] = Console.ReadLine();
                Console.WriteLine("What course number is it?");
                courses[i, 1] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(courses[i, 0] + courses[i, 1]);
            }
            return courses;
        }

        private static List<double> grades()
        {
            string ans = "";
            List<double> grades = new List<double>();
            do
            {
                Console.WriteLine("What grade do you want to put in?");
                grades.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Do you have another grade to put in?");
                ans = Console.ReadLine();
            } while (ans[0] == 'y');
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            double avg = sum / grades.Count;
            Console.WriteLine($"Your average grade is {avg.ToString("P2")}.");
            return grades;
        }
    }
}
