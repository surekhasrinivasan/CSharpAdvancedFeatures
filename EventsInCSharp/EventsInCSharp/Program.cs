using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    // Program to showcase the way to work with Events

    public delegate string newDel(string str);

    class EventClass
    {
        event newDel MyEvent;
        public void TriggerEvent()
        {
            this.MyEvent += new newDel(this.mymethod);
        }

        public string mymethod(string var)
        {
            return "Hello" + var;
        }
    }
}
