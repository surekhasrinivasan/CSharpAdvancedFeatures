﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCsharp
{
    // Program below shows how to use fields in a class

    class Student
    {
        private int ID;
        private string name;

        // Method used to input the value of ID and name 
        public void Input(int pid, string pname)
        {
            ID = pid;
            name = pname;
        }

        // Method used to display the value of ID and name 
        public void Display()
        {
            Console.WriteLine("The ID of the student is " + ID);
            Console.WriteLine("The name of the student is " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
