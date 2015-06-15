using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** LINQ Transformations ***\n");

            IEnumerable<string> subset = GetStringSubset();

            foreach (string item in subset)
            {
                Console.WriteLine(item);
            }

            foreach (string item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = {"Red", "Yellow", "Dark Red", 
                              "Light Red", "Blue", "Black"};

            IEnumerable<string> theRedColors = colors.Where(c => c.Contains("Red")).OrderBy(c => c).Select(c => c);

            return theRedColors;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = {"Red", "Yellow", "Dark Red", 
                              "Light Red", "Blue", "Black"};

            var theRedColors = colors.Where(c => c.Contains("Red")).OrderBy(c => c).Select(c => c);

            return theRedColors.ToArray();
        }
    }
}
