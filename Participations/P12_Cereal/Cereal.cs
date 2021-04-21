using System;
using System.Collections.Generic;
using System.Text;

namespace P12_Cereal
{
    class Cereal
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }
        public Cereal()
        {
            Manufacturer = "";
            Name = "";
            Calories = 0;
            Cups = 0;
        }
        public Cereal(string manu, string name, double cal, double cup)
        {
            Manufacturer = manu;
            Name = name;
            Calories = cal;
            Cups = cup;
        }
        public override string ToString()
        {
            return $"Name: {Name}\tManufacturer: {Manufacturer}\tCalories: {Calories}\tCups: {Cups}";
        }
    }
}
