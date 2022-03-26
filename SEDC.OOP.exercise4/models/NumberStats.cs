using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.exercise4.models
{
    public class NumberStats
    {
        public double Number { get; set; }
        //public bool EvenOrNot { get; set; }
        //public bool PositiveOrNegative { get; set; }
        //public bool IntegetOrDecimal { get; set; }

        public NumberStats()
        {

        }
        public NumberStats( double number)
        {
            Number = number;
        }
       
        public void PrintStats()
        {
            
                Console.WriteLine(@$"Stats for number {Number}:  ");
                if (Number < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Positive");
                }

                if ((Number % 1) > 0)
                {
                    Console.WriteLine("Decimal");
                }
                else
                {
                    Console.WriteLine("Integer");
                }

                if (Number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }


        }
        
    }
}
