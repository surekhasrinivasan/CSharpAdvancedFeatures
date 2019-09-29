using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInCsharp
{
    //// Program to show the way to use array lists
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the ArrayList 
    //        ArrayList ar = new ArrayList();

    //        // Adding elements to the array list 
    //        ar.Add(1);
    //        ar.Add(2);
    //        ar.Add(3);

    //        // Displaying the elements of the array 
    //        Console.WriteLine("The first element of the array is " + ar[0]);
    //        Console.WriteLine("The second element of the array is " + ar[1]);
    //        Console.WriteLine("The third element of the array is " + ar[2]);
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use array lists of strings 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the ArrayList
    //        ArrayList ar1 = new ArrayList();

    //        // Adding elements to the array list 
    //        ar1.Add("Hello");
    //        ar1.Add("Happy");
    //        ar1.Add("World");
    //        ar1.Add("Again");


    //        // Displaying the elements of the array
    //        Console.WriteLine("The first element of the array is : " + ar1[0]);
    //        Console.WriteLine("The second element of the array is : " + ar1[1]);
    //        Console.WriteLine("The third element of the array is : " + ar1[2]);
    //        Console.WriteLine("The fourth element of the array is : " + ar1[3]);
            
    //        Console.Read();
    //    }
    //}

    // Program to show how to use count property. 
    class Program
    {
        // Main function
        static void Main(string[] args)
        {
            // Defining the ArrayList
            ArrayList arrayList = new ArrayList();

            // Adding the elements to the array list 
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

            // Displaying the size of the array list or the count of elements in the array list 
            Console.WriteLine("The size of the array list is : " + arrayList.Count);

            Console.Read();
        }
    }
}
