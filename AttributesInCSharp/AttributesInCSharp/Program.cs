using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    //// Program shows the way to use attributes in c#
    //[AttributeUsage(AttributeTargets.All)]
    //public class TypeAttribute : System.Attribute
    //{
    //    public readonly string Type;
    //    public string Subject // Topic is a named parameter
    //    {
    //        get
    //        {
    //            return Subject;
    //        }
    //        set
    //        {
    //            Subject = value;
    //        }
    //    }

    //    public TypeAttribute(string type)  // type is a positional parameter
    //    {
    //        this.Type = type;
    //    }
    //}

    //[TypeAttribute("Student")]
    //class Person
    //{
    //    public int ID;
    //    public string name;

    //    void Display()
    //    {
    //        Console.WriteLine("The ID of the student is " + ID);
    //        Console.WriteLine("The Name of the student is " + name);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}

    // Program shows another way to use attributes in c#
   
    public class CustomAttribute : Attribute
    {
        // Private fields 
        private string name;

        public CustomAttribute(string name)
        {
            this.name = name;
        }

        // Define Name property
        // This is a read-only attribute

        public virtual string Name
        {
            get { return name; }
        }
    }

    [Custom("John")]
    class Person
    {
        public int ID;
        public string name;

        void Display()
        {
            Console.WriteLine("The ID of the student is "+ ID);
            Console.WriteLine("The Name of the student is " + name);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Person);
            CustomAttribute MyAttribute = (CustomAttribute)Attribute.GetCustomAttribute(t, typeof(CustomAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("The attribute was not found");
            }
            else
            {
                // Get the Name value
                Console.WriteLine("The Name Attribute is " + MyAttribute.Name);
            }
            Console.ReadKey();
        }
    }
}

