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

    // Program below showcases the way to use the FileInfo Class
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"C:\Hello.html");
            Console.WriteLine("Does the file exist" + fi.Exists);
        }
    }
}
