using System;
using System.Collections.Generic;

namespace P10_ClassToy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();
            Toy t1 = new Toy("Build-A-Bear", "Stuffed Animal", 30.99, "Brown Cat");
            Toy t2 = new Toy("Mattel", "Barbie Doll", 12.89, "Purple fairy from Rainbow Magic Movie");
            Toy t3 = new Toy();
            toys.Add(t1);
            toys.Add(t2);
            toys.Add(t3);

            foreach(Toy t in toys)
            {
                Console.WriteLine($"{t}\nAisle: {t.GetAisle()}");

            }

        }
    }
}
