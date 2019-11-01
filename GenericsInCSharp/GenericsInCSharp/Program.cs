using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //// Program showcases the way to define multiple methods that achieve the same purpose
    //class Program
    //{
    //    // Display method for Integers
    //    public static void Display(int i)
    //    {
    //        Console.WriteLine("The value is " + i);
    //    }

    //    // Display method for double numbers
    //    public static void Display(double i)
    //    {
    //        Console.WriteLine("The value is " + i);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Display(1);
    //        Display(1.1);
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use the generic data type
    //class Program
    //{
    //    // Generic Display method
    //    public static void Display<T>(T i)
    //    {
    //        Console.WriteLine("The value is " + i);
    //    }

    //    // Main function 
    //    static void Main(string[] args)
    //    {
    //        // calling the generic with the data type 
    //        Display<int>(1);
    //        Display<double>(1.5);

    //        Console.Read();
    //    }
    //}

    // Program below showcases the way to use the generic class

    // Generic class
    public class GenericSet<T>
    {
        private T[] array;
        public GenericSet(int size)
        {
            array = new T[size + 1];
        }

        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class Program
    {

    }
}
