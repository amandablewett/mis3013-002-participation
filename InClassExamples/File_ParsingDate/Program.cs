using System;
using System.Collections.Generic;
using System.IO;

namespace File_ParsingDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");

            List<string> regions = new List<string>();
            List<double> soccer = new List<double>();
            List<double> football = new List<double>();

            for (int i = 3; i < lines.Length; i++)
            {
                //"North Dakota,12%,88%"
                string line = lines[i];
                //"North Dakota", "12%", "88%"
                string[] pieces = line.Split(',');
                regions.Add(pieces[0]);
                //"12%"
                soccer.Add(Convert.ToDouble(pieces[1].Trim('%'))/100);
                football.Add(Convert.ToDouble(pieces[2].Trim('%')) / 100);
            }

            for (int i = 0; i < regions.Count; i++)
            {
                if(soccer[i] > football[i])
                {
                    Console.WriteLine(regions[i]);
                }
            }

        }
    }
}
