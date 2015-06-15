using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Overloaded Operators ***\n");

            // Make two points
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);

            Console.WriteLine("ptOne = {0} ", ptOne);
            Console.WriteLine("ptTwo = {0} ", ptTwo);

            // Add the points to make a bigger point?
            Console.WriteLine("ptOne + ptTwo = {0}", ptOne + ptTwo);

            // Subtract the points to make a smaller point.
            Console.WriteLine("ptOne - ptTwo = {0}", ptOne - ptTwo);

            // Prints [110, 110]. 
            Point biggerPoint = ptOne + 10; 
            Console.WriteLine("ptOne + 10 = {0}", biggerPoint);
  
            // Prints [120, 120]. 
            Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint); 
            Console.WriteLine(); 

            Console.ReadLine();
        }
    }
}
