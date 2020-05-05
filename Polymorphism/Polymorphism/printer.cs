using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class printerWindows
    {
        public virtual void show()
        {
           
        }

        public virtual void Print()
        {
            
        }
    }

    public class Epson : printerWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11 ");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing.....");
        }

    }

    public class Canon : printerWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12 ");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing......");
        }

    }

    public class LaserJet : printerWindows
    {
        public override void show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12 ");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing......");
        }
    }
}
