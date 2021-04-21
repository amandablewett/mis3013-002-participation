using System;
using System.Collections.Generic;
using System.Text;

namespace P11_ToyBox
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }
        public Toy(string manu, string name, double price, string notes)
        {
            Manufacturer = manu;
            Name = name;
            Price = price;
            Notes = notes;
        }
        public string GetAisle()
        {
            Random rand = new Random();
            return Manufacturer[0] + "" + rand.Next(1, 24);

        }
        public void AddNotes(string n)
        {
            Notes = n;
        }
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\tName: {Name}\tPrice: {Price.ToString("C2")}\tNotes: {Notes}";
        }
    }
}
