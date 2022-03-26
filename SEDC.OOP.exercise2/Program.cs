using System;
using SEDC.OOP.exercise2.models;
namespace SEDC.OOP.exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Name = "Garfield";
            dog.Race = "pitbull";
            dog.Color = "brown";
            Console.WriteLine(@"Enter the option you want to start: ""eat"", ""play"", ""chasetail""...  ");
            string input = Console.ReadLine();

            if(input!= "eat" && input !="play"&& input!= "chasetail")
            {
                Console.WriteLine("The input is not correct");
            }
            else
            {
                if (input == "eat")
                {
                    dog.Eat();
                }
                else if (input == "play")
                {
                    dog.Play();
                }
                else
                {
                    dog.ChaseTail();
                }
            }
            }

        }
    }

