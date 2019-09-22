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

    // Program shows how to use Delegate with multiple methods 
    class Program
    {
        // This is the method which will be pointed to by the delegate function 
        public static void DisplayA()
        {
            Console.WriteLine("Hello World!!");
        }

        public static void DisplayB()
        {
            Console.WriteLine("Hello World again");
        }

        // Defining the delegate
        public delegate void Del();

        // the main function
        static void Main(string[] args)
        {
            // Assigning the method to the delegate
            Del handler = DisplayA;

            // Calling the method via the delegate
            handler();

            // Assigning the method to the delegate 
            handler = DisplayB;

            // Calling the method via the delegate
            handler();

            Console.Read();
        }
    }
}
