using System;

namespace P4_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string back ="";
            string sent = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sent);
            Console.WriteLine("What do you want to replace? >>");
            string old = Console.ReadLine();
            Console.WriteLine("What do you want to replace \"" + old + "\" with? >>");
            string news = Console.ReadLine();

            if (sent.IndexOf(old) < 0)
            {
                Console.WriteLine($"Sorry, I could not find your word {old}.");
                for (int i = old.Length - 1; i >= 0; i--)
                {
                    back += old[i];
                }
                Console.WriteLine(back);
            }
            else
            {
                string newSent = sent.Replace(old, news);
                Console.WriteLine(newSent);
            }

        }
    }
}
