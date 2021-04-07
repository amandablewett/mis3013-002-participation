using System;
using System.Collections.Generic;

namespace P9_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of animal do you want?");
            string animal = Console.ReadLine().ToLower();
            Console.WriteLine($"A {animal} makes the sound {speak(animal)}!");
        }

        static String speak(string animal)
        {
            Dictionary<string, string> sounds = new Dictionary<string, string>();
            sounds.Add("dog", "Bark");
            sounds.Add("cat", "Meow");
            sounds.Add("bear", "Grrr");
            sounds.Add("snake", "Sssss");
            sounds.Add("lion", "Roar");
            sounds.Add("mouse", "Squeak");
            if (sounds.ContainsKey(animal))
            {
                return sounds[animal];
            }
            return "BOOYAH";
        }
    }
}
