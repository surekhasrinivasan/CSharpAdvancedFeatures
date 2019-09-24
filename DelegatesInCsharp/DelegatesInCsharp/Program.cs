using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCsharp
{
    //// Program is used to show the way to use a delegate
    //class Program
    //{
    //    // This is the method which will be pointed to by the delegate function 
    //    public static void Display()
    //    {
    //        Console.WriteLine("Hello Happy World!!");
    //    }

    //    // Defining the delegate
    //    public delegate void Del();

    //    static void Main(string[] args)
    //    {
    //        // Assigning the method to the delegate
    //        Del handler = Display;

    //        // Calling the method via the delegate
    //        handler();
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use Delegate with multiple methods 
    //class Program
    //{
    //    // This is the method which will be pointed to by the delegate function 
    //    public static void DisplayA()
    //    {
    //        Console.WriteLine("Hello World!!");
    //    }

    //    public static void DisplayB()
    //    {
    //        Console.WriteLine("Hello World again");
    //    }

    //    // Defining the delegate
    //    public delegate void Del();

    //    // the main function
    //    static void Main(string[] args)
    //    {
    //        // Assigning the method to the delegate
    //        Del handler = DisplayA;

    //        // Calling the method via the delegate
    //        handler();

    //        // Assigning the method to the delegate 
    //        handler = DisplayB;

    //        // Calling the method via the delegate
    //        handler();

    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use a delegate with parameters 
    //class Program
    //{
    //    // This is the method which will be pointed to by the delegate function
    //    public static void DisplayA(int i)
    //    {
    //        Console.WriteLine("The integer value is " + i);
    //    }

    //    public static void DisplayB(int j)
    //    {
    //        Console.WriteLine("The integer value is " + j);
    //    }

    //    // Defining the delegate
    //    public delegate void Del(int i);

    //    // Main function 
    //    static void Main(string[] args)
    //    {
    //        // Assigning the method to the delegate 
    //        Del handler = DisplayA;

    //        // Calling the method via the delegate 
    //        handler(1);

    //        // Assigning the method to the delegate 
    //        handler = DisplayB;

    //        // Calling the method via the delegate
    //        handler(2);

    //        Console.Read();
    //    }
    //}

    // Program shows the way to use a delegate with class objects 
    class Student
    {
        // Defining the members 
        private int id;
        private string name;
        private int subjectID = 1;


        // Defining a read only property 
        public int SubjectID
        {
            get
            {
                return subjectID;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("The ID is " + id);
            Console.WriteLine("The name is " + name);
        }
    }

    class Program
    {
        // Defining the delegate 
        public delegate void Del();

        // main function 
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = 1;
            s1.Name = "Rob";

            // Assigning the method to the delegate 
            Del handler = s1.Display;

            // Calling the method via the delegate 
            handler();

            Console.Read();
        }
    }
}
