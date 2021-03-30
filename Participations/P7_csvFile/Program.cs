using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace P7_csvFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sales_data_sample.csv");
            List<string[]> each = new List<string[]>();
            foreach (string line in lines)
            {
                each.Add(line.Split(','));
            }

            //double[] sales2003 = count(each);

            double[] yearsales = new double[3];
            double[] monthsales = new double[12];

            foreach (string[] item in each)
            {
                if (item[6] == "Shipped")
                {
                    if (item[9] == "2003")
                    {
                        yearsales[0] += Convert.ToDouble(item[4]);
                    }
                    if(item[9] == "2004")
                    {
                        yearsales[1] += Convert.ToDouble(item[4]);
                    }
                    else
                    {
                        yearsales[2] += Convert.ToDouble(item[4]);
                    }
                    monthsales[Convert.ToInt32(item[8]) - 1] += Convert.ToDouble(item[4]);
                }
            }

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] years = { "2003", "2004", "2005" };

            for (int y = 0; y < years.Length; y++)
            {
                Console.WriteLine($"{years[y]} sales total is {yearsales[y].ToString("C")}");
            }
            for (int x = 0; x < months.Length; x++)
            {
                Console.WriteLine($"{months[x]} sales total is {monthsales[x].ToString("C")}");
            }




        }
        
        /*
        private static void count (List<string[]> each)
        {
            double[] sales = new double[13];
            foreach (string[] item in each)
            {
                if (item[6] == "Shipped")
                {
                    if (item[9] == "2003")
                    {
                        yearsales[0] += Convert.ToInt32(item[4]);
                    }
                    sales[Convert.ToInt32(item[8])] += Convert.ToInt32(item[4]);
                }
            }
            //return sales;
        }
        */
    }
}
