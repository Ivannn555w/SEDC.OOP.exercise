using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.exercise3.models
{
    public class Student
    {
        public string []Array{get;set;}
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student()
        {

        }
        public Student (string []array ,string academy = "SEDC", string group= "G3")
        {
            Array = array;
            Academy = academy;
            Group = group;

        }
        public void Print( string arr)
        {
            Console.WriteLine($"Student name is {arr}, he/she is styding at {Academy} in {Group} group.");
        }

    }
}
