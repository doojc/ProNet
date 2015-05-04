using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** A frist look at interfaces ***\n");

            string myStr = "hello";

            CloneMe(myStr);

            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}",
                theClone.GetType().Name);
        }
    }
}
