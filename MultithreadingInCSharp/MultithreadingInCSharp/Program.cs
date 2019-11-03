using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
    
}
