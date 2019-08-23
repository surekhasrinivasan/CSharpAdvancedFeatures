using System;
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

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
