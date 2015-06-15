using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void QueryStringWithOperators()
        {
            Console.WriteLine("*** Using Query Operators ***");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var subset = from game in currentVideoGames
                         where game.Contains(" ")
                         orderby game
                         select game;

            foreach (string g in subset)
                Console.WriteLine("Game: {0}", g);

            Console.WriteLine();
        }

        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("*** Using Enumerable / Lambda Expressions ***");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var subset = currentVideoGames
                .Where(game => game.Contains(" "))
                .OrderBy(game => game)
                .Select(game => game);

            foreach (string g in subset)
                Console.WriteLine("Game: {0}", g);

            Console.WriteLine();
        }
    }
}
