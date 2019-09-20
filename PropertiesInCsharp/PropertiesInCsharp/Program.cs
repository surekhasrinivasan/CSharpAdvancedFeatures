using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCsharp
{
    //// Program below shows how to use fields in a class

    //class Student
    //{
    //    private int ID;
    //    private string name;

    //    // Method used to input the value of ID and name 
    //    public void Input(int pid, string pname)
    //    {
    //        ID = pid;
    //        name = pname;
    //    }

    //    // Method used to display the value of ID and name 
    //    public void Display()
    //    {
    //        Console.WriteLine("The ID of the student is " + ID);
    //        Console.WriteLine("The name of the student is " + name);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student s1 = new Student();
    //        s1.Input(10, "John");
    //        s1.Display();
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use properties in a class
    //class Student
    //{
    //    // Defining the members
    //    private int id;
    //    private string name;

    //    // Defining the properties
    //    public int ID
    //    {
    //        get
    //        {
    //            return id;
    //        }
    //        set
    //        {
    //            id = value;
    //        }
    //    }

    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stud1 = new Student();
    //        stud1.ID = 1;
    //        stud1.Name = "George";

    //        Console.WriteLine("The ID of the student is " + stud1.ID);
    //        Console.WriteLine("The name of the student is " + stud1.Name);
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use properties in an abstract class
    //public abstract class Person
    //{
    //    public abstract int ID
    //    {
    //        get;
    //        set;
    //    }

    //    public abstract string Name
    //    {
    //        get;
    //        set;
    //    }
    //}

    //class Student : Person
    //{
    //    // Defining the members 
    //    private int id;
    //    private string name;

    //    // Defining the properties 
    //    // 
    //    // In order to ensure that the derived class uses the abstract class 
    //    // properties we need to mention the 'override' keyword with the property
    //    public override int ID
    //    {
    //        get
    //        {
    //            return id;
    //        }
    //        set
    //        {
    //            id = value;
    //        }
    //    }

    //    public override string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student stud1 = new Student();
    //        stud1.ID = 1;
    //        stud1.Name = "Tom";

    //        Console.WriteLine("The ID of the student is " + stud1.ID);
    //        Console.WriteLine("The name of the student is " + stud1.Name);
    //        Console.Read();
    //    }
    //}

    // Program below showcases how to use read only properties 
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.ID = 1;
            stud1.Name = "Rob";

            Console.WriteLine("The ID of the student is " + stud1.ID);
            Console.WriteLine("The name of the student is " + stud1.Name);
            Console.WriteLine("The SubjectID is " + stud1.SubjectID);
            Console.Read();
        }
    }
}
