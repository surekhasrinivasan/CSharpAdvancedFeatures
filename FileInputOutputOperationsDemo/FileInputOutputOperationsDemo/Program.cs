using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutputOperationsDemo
{
    //// Program shows how to use the DriveInfo class

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DriveInfo[] allDrives = DriveInfo.GetDrives();

    //        foreach(DriveInfo d in allDrives)
    //        {
    //            Console.WriteLine("Drive {0}", d.Name);
    //            Console.WriteLine("Drivetype: {0}", d.DriveType);
    //        }
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use the DirectoryInfo class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DirectoryInfo di = new DirectoryInfo(@"C:\Project");
    //        Console.WriteLine("Does the directory exist " + di.Exists);
    //        Console.WriteLine("The creation time of the directory is " + di.CreationTime);

    //        Console.Read();
    //    }
    //}

    //// Program below showcases the way to use the FileInfo Class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        FileInfo fi = new FileInfo(@"C:\Surekha\Hello.html");
    //        Console.WriteLine("Does the file exist: " + fi.Exists);
    //        Console.WriteLine("The size of the file is: " + fi.CreationTime);
    //        Console.WriteLine("The size of the file is: " + fi.Length);
    //        Console.Read();
    //    }
    //}

    //// Program used to showcase the way to use the FileStream class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in read only mode
    //        FileStream src = new FileStream(@"C:\Surekha\Hello.html", FileMode.Open, FileAccess.Read);

    //        // Number of bytes in the file 
    //        int numBytes = (int)src.Length;

    //        // This will be used to get the number of bytes read
    //        int i = 0;

    //        // Storing the bytes in an array
    //        byte[] bytes = new byte[src.Length];

    //        Console.WriteLine("Number of bytes in the file " + numBytes);

    //        src.Read(bytes, i, numBytes);

    //        string result = System.Text.Encoding.UTF8.GetString(bytes);
    //        Console.WriteLine(result);
    //        Console.Read();
    //    }
    //}

    //// Program used to showcase the way to use the FileStream class to write contents to a file 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in read only mode 
    //        FileStream src = new FileStream(@"C:\Surekha\newHello.txt", FileMode.Open, FileAccess.Write);

    //        string str = "Hello World";

    //        // Converting the string to bytes to write 
    //        byte[] bytes = new byte[str.Length];
    //        bytes = System.Text.Encoding.UTF8.GetBytes(str);

    //        // This will be used to store the number of bytes written to the file 
    //        int i = 0;

    //        src.Write(bytes, 0, str.Length);
    //        Console.Read();
    //    }
    //}

    //// Program used to showcase the way to use the StreamReader class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in read only mode 
    //        StreamReader src = new StreamReader(@"C:\Surekha\newHello.html");

    //        // Displaying the first line of the file 
    //        Console.WriteLine(src.ReadLine());
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use the StreamReader class with the ReadtoEnd Function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in read only mode 
    //        StreamReader src = new StreamReader(@"C:\Surekha\newHello.html");

    //        // Displaying all the contents of the file 
    //        Console.WriteLine(src.ReadToEnd());
    //        Console.Read();
    //    }
    //}

    //// Program shows the way to use the StreamWriter class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in append mode 
    //        StreamWriter src = new StreamWriter(@"C:\Surekha\newFile.html");

    //        // writing the contents to the file 
    //        src.WriteLine("Hello Happy World");
    //        Console.Read();
    //    }
    //}

    //// Program shows how to use the StreamWriter class to append data
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Opening the file in append mode 
    //        StreamWriter src = new StreamWriter(@"C:\Surekha\newHello.html", true);

    //        // Writing the contents to the file 
    //        src.WriteLine("Hello Surekha");
    //        Console.Read();
    //    }
    //}

    // Program shows the way to use the StringReader Class
    class Program
    {

    }
}
