using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Make a Point by setting each prop manually.
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            p1.DisplayStatus();

            // Or make a Point via a custom constructor.
            Point p2 = new Point(20, 20);
            p2.DisplayStatus();

            // Or make a Point using object init syntax.
            Point p3 = new Point { X = 30, Y = 30 };
            p3.DisplayStatus();

            Console.ReadLine();
        }
    }
}
