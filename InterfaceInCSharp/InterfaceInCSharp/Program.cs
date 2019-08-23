﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCSharp
{
    // Program to demo Interface demo in csharp
    

    // Defining the interface
    public interface Marks
    {
        // Declaring the interface methods
        void DisplayMarks();
        int Calculate();
    }
    
    public class Student : Marks
    {
        public int StudentID;
        public string StudentName;
        public int marks1, marks2;

        // Defining the interface DisplayMarks method 
        public void DisplayMarks()
        {
            Console.WriteLine("The marks of subject 1 is " + marks1);
            Console.WriteLine("The marks of subject 2 is " + marks2);
        }

        // Defining the interface Calculate method
        public int Calculate()
        {
            return marks1 + marks2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
