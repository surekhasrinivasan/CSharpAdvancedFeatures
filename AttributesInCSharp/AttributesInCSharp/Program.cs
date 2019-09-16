using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    // Program shows the way to use attributes in c#
    [AttributeUsage(AttributeTargets.All)]
    public class TypeAttribute : System.Attribute
    {
        public readonly string Type;
        public string Subject // Topic is a named parameter
        {
            get
            {
                return Subject;
            }
            set
            {
                Subject = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
