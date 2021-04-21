using System;

namespace P11_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox tb; ;
            Toy t;
            string user;
            string user2;
            do
            {
                tb = new ToyBox();
                Console.WriteLine("Who is the owner of the ToyBox?");
                tb.Owner = Console.ReadLine();
                Console.WriteLine("Where is the location of the ToyBox?");
                tb.Location = Console.ReadLine();
                do
                {
                    t = new Toy();
                    Console.WriteLine("What is the name of the toy?");
                    t.Name = Console.ReadLine();
                    Console.WriteLine("What is the manufacturer of the toy?");
                    t.Manufacturer = Console.ReadLine();
                    Console.WriteLine("What is the price of the toy?");
                    t.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What are the notes of the toy?");
                    t.AddNotes(Console.ReadLine());
                    tb.Toys.Add(t);
                    Console.WriteLine("Do you want to add another Toy to the ToyBox? Y or N only >>");
                    user2 = Console.ReadLine().ToLower();
                } while (user2 == "y");
                Console.WriteLine(tb);
                Console.WriteLine($"GetRandomToy: {tb.GetRandomToy()}");
                Console.WriteLine("Do you want to add another ToyBox? Y or N only >>");
                user = Console.ReadLine().ToLower();
            } while (user == "y");
            Console.WriteLine("Thank you!");
        }
    }
}
