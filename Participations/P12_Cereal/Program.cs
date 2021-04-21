using System;
using System.Collections.Generic;
using System.IO;

namespace P12_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            Cereal c;
            List<Cereal> cereals = new List<Cereal>();
            string[] sp;
            for(int x = 1; x < lines.Length;x++)
            {
                sp = lines[x].Split("|");
                c = new Cereal(sp[1],sp[0],Convert.ToDouble(sp[2]),Convert.ToDouble(sp[3]));
                cereals.Add(c);
            }
            Console.WriteLine("\nCereals with a serving size >= 1 cup:\n");
            foreach(Cereal cereal in cereals)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);
                }
            }
            Console.WriteLine("\nCereals with calories <= 100:\n");
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine(cereal);
                }
            }
        }
    }
}
