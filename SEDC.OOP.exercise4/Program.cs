using System;
using SEDC.OOP.exercise4.models;
namespace SEDC.OOP.exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberStats numberstats = new NumberStats();
            //string num = Console.ReadLine();
            //double parsedNum = double.Parse(num);
            //numberstats.Number = parsedNum;
            //parsedDouble[i] = double.Parse(arr[i]);

            string[] arr = new string[5];
            double[] parsedDouble = new double[5];
            
            for (int i = 0; i < 5; i++)
            {
                
                arr[i] = Console.ReadLine();
                double number;
                bool succes = double.TryParse(arr[i], out number);
                if (succes)
                {
                        numberstats.Number = number;
                        numberstats.PrintStats();
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter valid number...");
                    break;
                }

                
            }

        }
    }
}
