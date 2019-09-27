using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionInCsharp
{
    // Reflection is the ability in csharp to get information of a particular piece of code at runtime. 

    //// Program shows how to use Type to get information on a class
    //class Student
    //{
    //    // Defining the members
    //    public int id;
    //    public string name;

    //    public void Display()
    //    {
    //        Console.WriteLine("The ID is " + id);
    //        Console.WriteLine("The name is " + name);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stud1 = new Student();

    //        // Trying to get the type of object 
    //        Type myTypeObj = stud1.GetType();

    //        Console.WriteLine("The object is of Type " + myTypeObj);
    //        Console.Read();
    //    }
    //}

    // Program shows the way to use MethodInfo
    class Student
    {
        // Defining the members 
        public int id;
        public string name;

        public void Display()
        {
            Console.WriteLine("The ID is " + id);
            Console.WriteLine("The name is " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            // Trying to get the type of object 
            Type myTypeObj = s1.GetType();

            Console.WriteLine("The object is of Type" + myTypeObj);

            // Using reflection to get information about the Display method 
            MethodInfo myMethodInfo = myTypeObj.GetMethod("Display");

            Console.WriteLine("Is the method a static method " + myMethodInfo.IsStatic);
            Console.Read();
        }
    }
}

