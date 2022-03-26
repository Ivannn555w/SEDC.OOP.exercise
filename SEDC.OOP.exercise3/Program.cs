using System;
using SEDC.OOP.exercise3.models;
namespace SEDC.OOP.exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string[] arr = new string[5] { "Ivan", "Trajan", "Gorge", "Dracevo", "Petko" }; ;
            student.Array = arr;
            student.Group = "G3";
            student.Academy = "SEDC";

            string input = Console.ReadLine();
            
                switch (input)
                {

                case "ivan":
                        student.Print(input);
                        break;

                    case "trajan":
                        student.Print(input);
                        break;
                    case "gorge":
                        student.Print(input);
                        break;
                    case "dracevo":
                        student.Print(input);
                        break;
                    case "petko":
                        student.Print(input);
                        break;

                    default:
                        Console.WriteLine("Error message...");
                        break;
                
            }
            
        }
    }
}
