using System;
using SEDC.OOP.exercise1.models;
namespace SEDC.OOP.exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            Console.WriteLine("Enter your name: ");
            human.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your lastName: ");
            human.LastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            human.Age = int.Parse(Console.ReadLine());


            human.GetPersonStats();
        }
    }
}
