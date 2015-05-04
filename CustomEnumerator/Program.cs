using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with IEnumerable / IEnumerator ***\n");
            Garage carlot = new Garage();

            foreach (Car c in carlot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                    c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();
        }
    }
}
