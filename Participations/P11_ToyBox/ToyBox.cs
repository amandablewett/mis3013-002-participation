using System;
using System.Collections.Generic;
using System.Text;

namespace P11_ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }

        public ToyBox(string owner, string loc)
        {
            Toys = new List<Toy>();
            Owner = owner;
            Location = loc;
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int index = rand.Next(0, Toys.Count);
            return Toys[index];
        }
        public override string ToString()
        {
            string output = $"{Owner}'s ToyBox located in {Location}: \n";
            foreach(Toy t in Toys)
            {
                output += $"{t} \n";
            }
            return output;
        }
    }
}
