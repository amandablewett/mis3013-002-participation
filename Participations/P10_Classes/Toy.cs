using System;
using System.Collections.Generic;
using System.Text;

namespace P10_ClassToy
{
    class Toy
    {
        
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }
        public Toy()
        {
            Manufacturer = "Ibeco Toys";
            Name = "Bouncy Balls";
            Price = 5.99;
            Notes = "Comes with 6 balls";
        }
        public Toy (string manu, string name, double price, string notes)
        {
            Manufacturer = manu;
            Name = name;
            Price = price;
            Notes = notes;
        }
        public string GetAisle()
        {
            Random rand = new Random();
            return Manufacturer[0] + "" + rand.Next(1,24);

        }
        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}\tName: {Name}\tPrice: {Price}\tNotes: {Notes}";
        }
    }
}
