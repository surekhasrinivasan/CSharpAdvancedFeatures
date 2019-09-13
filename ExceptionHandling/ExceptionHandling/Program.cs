using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    // Program showcases the way to use the exception handling blocks
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[2];

            // Placing the code in the try block 
            try
            {
                // We are placing invalid code 
                i[3] = 3;
            }
        }
    }
}
