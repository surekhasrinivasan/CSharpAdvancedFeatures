using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCSharp
{
    // Program to demo Interface demo in csharp


    //// Defining the interface
    //public interface Marks
    //{
    //    // Declaring the interface methods
    //    void DisplayMarks();
    //    int Calculate();
    //}

    //public class Student : Marks
    //{
    //    public int StudentID;
    //    public string StudentName;
    //    public int marks1, marks2;

    //    // Defining the interface DisplayMarks method 
    //    public void DisplayMarks()
    //    {
    //        Console.WriteLine("The marks of subject 1 is " + marks1);
    //        Console.WriteLine("The marks of subject 2 is " + marks2);
    //    }

    //    // Defining the interface Calculate method
    //    public int Calculate()
    //    {
    //        return marks1 + marks2;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stud1 = new Student();

    //        stud1.StudentName = "John";
    //        stud1.StudentID = 1;
    //        stud1.marks1 = 10;
    //        stud1.marks2 = 20;

    //        stud1.DisplayMarks();
    //        Console.WriteLine("The Total marks is: " + stud1.Calculate());

    //        Console.Read();
    //    }
    //}

    //// Program to demo Multiple interfaces 

    //// Defining the multiple interfaces
    //public interface Marks
    //{
    //    // Declaring the interface methods
    //    void DisplayMarks();
    //    int Calculate();
    //}

    //public interface Location
    //{
    //    // Declaring the interface methods 
    //    void InputCity(string city);
    //    void DisplayCity();
    //}

    //public class Student : Marks, Location
    //{
    //    public int StudentID;
    //    public string StudentName;
    //    public int marks1, marks2;
    //    private string city;
        
    //    // Defining the interface InputCity method
    //    public void InputCity(string pcity)
    //    {
    //        city = pcity;
    //    }

    //    // Defining the interface DisplayCity method
    //    public void DisplayCity()
    //    {
    //        Console.WriteLine("City is : " + city);
    //    }

    //    // Defining the interface DisplayMarks method 
    //    public void DisplayMarks()
    //    {
    //        Console.WriteLine("The marks of subject 1 is : " + marks1);
    //        Console.WriteLine("The marks of subject 2 is : " + marks2);
    //    }

    //    // Defining the interface Calculate method
    //    public int Calculate()
    //    {
    //        return marks1 + marks2;
    //    }

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Student stud1 = new Student();

    //            stud1.StudentName = "John";
    //            stud1.StudentID = 1;
    //            stud1.marks1 = 10;
    //            stud1.marks2 = 20;

    //            stud1.DisplayMarks();
    //            Console.WriteLine("The Total marks is : " + stud1.Calculate());

    //            stud1.InputCity("New York");
    //            stud1.DisplayCity();

    //            Console.Read();
    //        }
    //    }
    //}

    // Program to demo the use of properties in Interfaces

    // Defining the Marks interface
    public interface Marks
    {
        // Read write property
        int marks
        {
            get;
            set;
        }
        // Read write property
        string Subject
        {
            get;
            set;
        }
        // Read only property
        int SubjectID
        {
            get;
        }
    }

}