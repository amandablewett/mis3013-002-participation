using System;

namespace ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentIds = new string[3];
            double[] studentGPAs = { 3.0, 4.0, 2.5 };

            studentIds[0] = "1";
            studentIds[1] = "2";
            studentIds[2] = "3";

            /* Console.WriteLine(studentIds);
            for (int i = 0; i < studentIds.Length; i++)
            {
                Console.Write($"{studentIds[i]}\t");
            }
            */
            foreach (string id in studentIds)
            {
                Console.Write($"{id}\t");

            }

            Console.WriteLine("Whose GPA do you want to see? >>");
            string user = Console.ReadLine();

            for (int i = 0; i < studentIds.Length; i++)
            {
                if(studentIds[i] == user)
                {
                    Console.WriteLine($"{user}'s GPA is {studentGPAs[i].ToString("n2")}");
                }
            }
        }
    }
}
