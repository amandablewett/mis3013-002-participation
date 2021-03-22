using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.5);

            Console.WriteLine("Do you want to add another student?");
            string answer = Console.ReadLine();

            if answer.ToLower()[0] == 'y')
            {
                Console.WriteLine("What is the student's ID? >>");
                string id = Console.ReadLine();
                Console.WriteLine("What is the student's GPA? >>");
                double gpa = Convert.ToDouble(Console.ReadLine());
                if (students.ContainsKey(id))
                {
                    Console.WriteLine("Already contains that key, we will update it for you.");

                }
                else
                {
                    students.Add(id, gpa);

                }
            }

            foreach(string id in students.Keys)
            {
                Console.WriteLine(id);
            }
        }
    }
}
