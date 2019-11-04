using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingInCSharp
{
    // Program to show how to create a thread 
    class Program
    {
        // This method will be called by the thread
        public static void ThreadModule()
        {
            Console.WriteLine("The thread is starting");
        }

        // Main function
        static void Main(string[] args)
        {
            // Making a reference to the ThreadModule
            ThreadStart start = new ThreadStart(ThreadModule);

            // Creating a new thread
            Thread thd = new Thread(start);

            // Starting the thread
            thd.Start();

            Console.Read();
        }
    }
    
}
