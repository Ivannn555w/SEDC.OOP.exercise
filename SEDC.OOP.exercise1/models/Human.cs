using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.exercise1.models
{
   public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  int Age { get; set; }

        public Human()
        {
        }
        public Human(string name, string surname, int year)
        {
            FirstName = name;
            LastName = surname;
            Age = year;

        }

        public void GetPersonStats()
        {
            Console.WriteLine($"The person name is {FirstName}{LastName} and he/she is {Age} years old");
        }
    }
}
