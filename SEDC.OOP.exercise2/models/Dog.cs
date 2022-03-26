using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.exercise2.models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public Dog()
        {
        }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} which race is {Race} and color {Color} is now eating.");
        }
        public void Play()
        {
            Console.WriteLine($"The dog {Name} which race is {Race} and color {Color} is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} which race is {Race} and color {Color} is now chasing its tail.");
        }
    }
}
