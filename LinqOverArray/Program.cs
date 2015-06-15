using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with LINQ to Objects ***\n");
            //QueryOverStrings();
            QueryOverInts();
            
            Console.ReadLine();
        }

        static void QueryOverStrings()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3",
                                         "Daxter", "System Shock 2"};

            // Build a query expression to find the items in the array 
            // that have an embedded space.
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;

            //IEnumerable<string> subset = currentVideoGames
            //    .Where(x => x.Contains(" "))
            //    .OrderBy(x => x)
            //    .Select(x => x);

            ReflectOverQueryResults(subset);
            Console.WriteLine();

            // Print out the results.
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
                ReflectOverQueryResults(s);
                Console.WriteLine();
            }
        }

        static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine("*** Info about your query ***");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", 
                resultSet.GetType().Assembly.GetName().Name);
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Print only items less than 10.
            var subset = numbers.Where(x => (x < 10)).OrderBy(x => x).Select(x => x);
            
            foreach (var i in subset)
            {
                Console.WriteLine("Item: {0}", i);
            }

            ReflectOverQueryResults(subset);
        }
    }
}
