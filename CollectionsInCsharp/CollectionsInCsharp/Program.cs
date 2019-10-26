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

    //// Program to show how to use count property. 
    //class Program
    //{
    //    // Main function
    //    static void Main(string[] args)
    //    {
    //        // Defining the ArrayList
    //        ArrayList arrayList = new ArrayList();

    //        // Adding the elements to the array list 
    //        arrayList.Add(1);
    //        arrayList.Add(2);
    //        arrayList.Add(3);
    //        arrayList.Add(4);
    //        arrayList.Add(5);

    //        // Displaying the size of the array list or the count of elements in the array list 
    //        Console.WriteLine("The size of the array list is : " + arrayList.Count);

    //        Console.Read();
    //    }
    //}

    //// Program to show how to use clear method
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Array List
    //        ArrayList ar1 = new ArrayList();

    //        // Adding the elements to array list 
    //        ar1.Add(1);
    //        ar1.Add(2);
    //        ar1.Add(3);

    //        // Display the size of the array before using clear method
    //        Console.WriteLine("The size of the array before clear method is : " + ar1.Count);

    //        // Clearing all the elements of the array list 
    //        ar1.Clear();

    //        Console.WriteLine("The size of the array after clear method is : " + ar1.Count);
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use contains method 
    //class Program
    //{
    //    static void Main(string[] argsf)
    //    {
    //        // Defining the Array List 
    //        ArrayList ar = new ArrayList();

    //        // Adding the elements to the array list 
    //        ar.Add(1);
    //        ar.Add(2);
    //        ar.Add(3);

    //        Console.WriteLine("Does the array contain the value 3 : " + ar.Contains(3));

    //        Console.Read();
    //    }
    //}

    //// Program shows how to use IndexOfmethod
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the ArrayList
    //        ArrayList ar1 = new ArrayList();

    //        // Adding elements to the array list
    //        ar1.Add(1);
    //        ar1.Add(2);
    //        ar1.Add(3);

    //        Console.WriteLine("The index of value 3 is " + ar1.IndexOf(3));
    //        Console.Read();
    //    }
    //}

    //// Program below showcases the insert method
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the ArrayList
    //        ArrayList ar1 = new ArrayList();

    //        // Adding elements to the array list
    //        ar1.Add(1);
    //        ar1.Add(2);
    //        ar1.Add(3);

    //        Console.WriteLine("The index of value 3 is " + ar1.IndexOf(3));

    //        // Inserting the value 4 at Index position 2
    //        ar1.Insert(2, 4);

    //        Console.WriteLine("The index of value 3 is " + ar1.IndexOf(3));

    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use Remove method
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the array list
    //        ArrayList arrayList = new ArrayList();

    //        // adding elements to array list
    //        arrayList.Add(1);
    //        arrayList.Add(2);
    //        arrayList.Add(3);

    //        Console.WriteLine("The value at position 1 is " + arrayList[1]);

    //        // Removing a value
    //        arrayList.Remove(2);

    //        Console.WriteLine("The value at position 1 is " + arrayList[1]);

    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use RemoveAt method 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the array list 
    //        ArrayList ar1 = new ArrayList();

    //        // Adding elements to the array list 
    //        ar1.Add(1);
    //        ar1.Add(2);
    //        ar1.Add(3);

    //        Console.WriteLine("The value at position 1 is " + ar1[1]);

    //        // Removing a value
    //        ar1.RemoveAt(1);

    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.Read();
    //    }
    //}

    //// Program showcases the reverse method 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // defining the array list 
    //        ArrayList ar1 = new ArrayList();

    //        // Adding elements to the arraylist 
    //        ar1.Add(1);
    //        ar1.Add(2);
    //        ar1.Add(3);

    //        Console.WriteLine("Array before reverse method: ");
    //        Console.WriteLine("The value at position 0 is " + ar1[0]);
    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.WriteLine("The value at position 2 is " + ar1[2]);
    //        Console.WriteLine();

    //        // Reversing the list 
    //        ar1.Reverse();
    //        Console.WriteLine("Array after reverse method: ");

    //        Console.WriteLine("The value at position 0 is " + ar1[0]);
    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.WriteLine("The value at position 2 is " + ar1[2]);

    //        Console.Read();
    //    }
    //}

    //// Program to showcase the sort method 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // defining the array list
    //        ArrayList ar1 = new ArrayList();

    //        // adding elements to the array list 
    //        ar1.Add(5);
    //        ar1.Add(2);
    //        ar1.Add(3);
    //        ar1.Add(4);
    //        ar1.Add(1);   

    //        Console.WriteLine("Array before sort method: ");
    //        Console.WriteLine();
    //        Console.WriteLine("The value at position 0 is " + ar1[0]);
    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.WriteLine("The value at position 2 is " + ar1[2]);
    //        Console.WriteLine("The value at position 3 is " + ar1[3]);
    //        Console.WriteLine("The value at position 4 is " + ar1[4]);
    //        Console.WriteLine();

    //        ar1.Sort();

    //        Console.WriteLine("Array after sort method: ");
    //        Console.WriteLine();
    //        Console.WriteLine("The value at position 0 is " + ar1[0]);
    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.WriteLine("The value at position 2 is " + ar1[2]);
    //        Console.WriteLine("The value at position 3 is " + ar1[3]);
    //        Console.WriteLine("The value at position 4 is " + ar1[4]);
    //        Console.WriteLine();
    //    }
    //}

    //// Program shows how to use GetRange method 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // defining the array list 
    //        ArrayList arrayList = new ArrayList();

    //        // adding elements to the array list 
    //        arrayList.Add(1);
    //        arrayList.Add(2);
    //        arrayList.Add(3);
    //        arrayList.Add(4);

    //        // creating a new array list
    //        ArrayList ar1 = new ArrayList();
    //        ar1 = arrayList.GetRange(0, 2);

    //        Console.WriteLine("The value at position 0 is " + ar1[0]);
    //        Console.WriteLine("The value at position 1 is " + ar1[1]);
    //        Console.Read();

    //    }
    //}

    //// Program showcases the way to use stacks
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack
    //        Stack ar = new Stack();

    //        // Adding elements to the Stack
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        // Displaying the elements 
    //        Console.WriteLine("The first element is " + ar.Pop());
    //        Console.WriteLine("The second element is " + ar.Pop());
    //        Console.WriteLine("The third element is " + ar.Pop());

    //        Console.Read();
    //    }
    //}

    //// Program to showcase the clear function 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack
    //        Stack ar = new Stack();

    //        // Adding elements to the stack 
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        Console.WriteLine("The number of elements on the stack is " + ar.Count);

    //        // Clearing the Stack
    //        ar.Clear();

    //        Console.WriteLine("The number of elements on the Stack is " + ar.Count);
    //        Console.Read();
    //    }
    //}

    //// Program showcase the way to use the pop function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack
    //        Stack ar = new Stack();

    //        // Adding elements to the Stack
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        Console.WriteLine("Popping an element from the stack " + ar.Pop());
    //        Console.WriteLine("Popping an element from the stack " + ar.Pop());
    //        Console.Read();
    //    }
    //}

    //// Program showcase the way to use the peek function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack
    //        Stack ar = new Stack();

    //        // adding elements to the stack 
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        Console.WriteLine("The element at the top of the stack is " + ar.Peek());
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use ToArray Function 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack
    //        Stack ar = new Stack();
    //        object[] ar1 = new object[3];

    //        // adding elements to the stack 
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        // Transferring the elements to an array 
    //        ar1 = ar.ToArray();

    //        Console.WriteLine("The first element is " + ar1[0].ToString());
    //        Console.WriteLine("The second element is " + ar1[1].ToString());
    //        Console.WriteLine("The third element is " + ar1[2].ToString());
    //        Console.Read();
    //    }
    //}

    //// Program to showcase the Contains function 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Stack 
    //        Stack ar = new Stack();

    //        // adding elements to Stack 
    //        ar.Push(1);
    //        ar.Push(2);
    //        ar.Push(3);

    //        // usage of Contains function
    //        Console.WriteLine("Does Stack contains the element 2 ?" + ar.Contains(3));
    //        Console.Read();
    //    }
    //}

    //// Program to showcase the way to use Queues
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();

    //        // Adding elements to the Queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);

    //        Console.Read();
    //    }
    //}

    //// Program to showcase the Count property
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();

    //        // adding elements to the Queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);
    //        ar.Enqueue(4);

    //        Console.WriteLine("The number of elements in the queue is " + ar.Count);
    //        Console.Read();
    //    }
    //}

    //// Program to show how to use the DeQueue function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();

    //        // adding elements to the queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);

    //        Console.WriteLine("The first element out of the queue is " + ar.Dequeue());
    //        Console.WriteLine("The second element out of the queue is " + ar.Dequeue());
    //        Console.WriteLine("The third element out of the queue is " + ar.Dequeue());
    //        Console.Read();
    //    }
    //}

    //// Program to show how to use the clear function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();

    //        // Adding the elements to the queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);

    //        Console.WriteLine("The number of elements in the Queue is " + ar.Count);

    //        // Clearing the queue
    //        ar.Clear();

    //        Console.WriteLine("The number of elements in the Queue is " + ar.Count);
    //        Console.Read();
    //    }
    //}

    //// Program showcases the contains function in Queue
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();

    //        // Adding the elements to the Queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);
    //        ar.Enqueue(4);

    //        Console.WriteLine("Does the queue contain the element 2 " + ar.Contains(2));
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use the ToArray function 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the Queue
    //        Queue ar = new Queue();
    //        Object[] ar1 = new Object[3];

    //        // Adding elements to the Queue
    //        ar.Enqueue(1);
    //        ar.Enqueue(2);
    //        ar.Enqueue(3);

    //        ar1 = ar.ToArray();

    //        Console.WriteLine("The first element of the array is " + ar1[0].ToString());
    //        Console.WriteLine("The second element of the array is " + ar1[1].ToString());
    //        Console.WriteLine("The third element of the array is " + ar1[2].ToString());
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use SortedList
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the SortedList
    //        SortedList ar = new SortedList();

    //        // Adding elements to the SortedList
    //        ar.Add(1, "One");
    //        ar.Add(2, "Two");
    //        ar.Add(3, "Three");

    //        // Displaying the values of each element in the SortedList
    //        Console.WriteLine("The first value of the SortedList is " + ar[1].ToString());
    //        Console.WriteLine("The second value of the SortedList is " + ar[2].ToString());
    //        Console.WriteLine("The third value of the SortedList is " + ar[3].ToString());
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use the count property in SortedList
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the SortedList
    //        SortedList ar = new SortedList();

    //        // Adding elements to the SortedList
    //        ar.Add(1, "One");
    //        ar.Add(2, "Two");
    //        ar.Add(3, "Three");
    //        ar.Add(4, "Four");
    //        ar.Add(5, "Five");

    //        Console.WriteLine("The number of elements in the SortedList is " + ar.Count);
    //        Console.Read();
    //    }
    //}

    //// Program showcases the clears function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the SortedList
    //        SortedList ar = new SortedList();

    //        // Adding elements to the SortedList
    //        ar.Add(1, "One");
    //        ar.Add(2, "Two");
    //        ar.Add(3, "Three");
    //        ar.Add(4, "Four");

    //        Console.WriteLine("The number of elements in the SortedList before clear method is " + ar.Count);

    //        // Clearing all the elements of the List 
    //        ar.Clear();

    //        Console.WriteLine("The number of elements in the SortedList after clear method is " + ar.Count);
    //        Console.Read();
    //    }
    //}

    //// Program to show how to use the ContainsKey function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Defining the SortedList
    //        SortedList ar = new SortedList();

    //        // Adding elements to the SortedList
    //        ar.Add(10, "Ten");
    //        ar.Add(20, "Twenty");
    //        ar.Add(30, "Thirty");

    //        Console.WriteLine("Does the SortedList contain the key 30 " + ar.ContainsKey(30));
    //        Console.Read();
    //    }
    //}

    // Program to show how to use ContainsValue function
    class Program
    {
        static void Main(string[] args)
        {
            // Defining the SortedList
            SortedList ar = new SortedList();

            // Adding elements to the SortedList
            ar.Add(1, "One");
            ar.Add(2, "Two");
            ar.Add(3, "Three");            
        }
    }
}