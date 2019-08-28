using NameA;
using NameB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// One namespace
//namespace NameA
//{
//    public class ClassA
//    {
//        public void FunctionA()
//        {
//            Console.WriteLine("This is namespace A");
//        }
//    }
//}

//// Second namespace
//namespace NameB
//{
//    public class ClassB
//    {
//        public void FunctionA()
//        {
//            Console.WriteLine("This is namespace B");
//        }
//    }
//}

//// Program to demo the use of namespaces
//namespace NamespaceDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Using the namespaces
//            NameA.ClassA clsA = new NameA.ClassA();
//            clsA.FunctionA();

//            NameB.ClassB clsB = new NameB.ClassB();
//            clsB.FunctionA();

//            Console.Read();
//        }
//    }
//}

    // Program to showcase how to use the using clause for namespaces

    // One namespace
    namespace NameA
    {
        public class ClassA
        {
            public void FunctionA()
            {
                Console.WriteLine("This is namespace A");
            }
        }
    }

    // Second namespace
    namespace NameB
    {
        public class ClassB
        {
            public void FunctionA()
            {
                Console.WriteLine("This is namespace B");
            }
        }
    }

    namespace Demo
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Using the namespaces
                ClassA clsA = new ClassA();
                clsA.FunctionA();

                ClassB clsB = new ClassB();
                clsB.FunctionA();

                Console.Read();
            }
        }
    }
