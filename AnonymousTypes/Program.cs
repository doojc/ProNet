using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Anonymous Types ***\n");

            // Make an anonymous type representing a car.

        }

        static void BuildAnonType(string make, string color, int currSp)
        {
            // Build anon type using incoming args.
            var car = new { Make = make, Color = color, Speed = currSp };

            // Note you can now use this type to get the property data!
            Console.WriteLine("You have a {0} {1} going {2} MPH",
                car.Color, car.Make, car.Speed);

            // Anon types have custom implementations of each virtual method of System.Object.
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
    }
}
