using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Query Expressions ***\n");

            // This array will be the basis of you testing...
            ProductInfo[] itemsInStock = new[] {
                 new ProductInfo{ 
                     Name = "Mac's Coffee",                       
                     Description = "Coffee with TEETH",                       
                     NumberInStock = 24},     
                 new ProductInfo{ 
                     Name = "Milk Maid Milk",                       
                     Description = "Milk cow's love",                       
                     NumberInStock = 100},     
                 new ProductInfo{ 
                     Name = "Pure Silk Tofu",                       
                     Description = "Bland as Possible",                       
                     NumberInStock = 120},     
                 new ProductInfo{ 
                     Name = "Cruchy Pops",                       
                     Description = "Cheezy, peppery goodness",                       
                     NumberInStock = 2},     
                 new ProductInfo{ 
                     Name = "RipOff Water",                       
                     Description = "From the tap to your wallet",                       
                     NumberInStock = 100},     
                 new ProductInfo{ 
                     Name = "Classic Valpo Pizza",                       
                     Description = "Everyone loves pizza!",                       
                     NumberInStock = 73}
            };

            // We will call various methods here.

            SelectEverything(itemsInStock);
            Console.WriteLine();

            ListProductNames(itemsInStock);
            Console.WriteLine();

            GetOverstock(itemsInStock);
            Console.WriteLine();

            DisplayDiff();
            Console.WriteLine();

            DisplayIntersection();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void SelectEverything(ProductInfo[] products)
        {
            // Get everything!
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;
            var allProducts2 = products.OrderBy(x => x.Name).Select(x => x);

            foreach (var prod in allProducts2)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            // Now get only the names of the products.
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;
            var names2 = products.OrderBy(x => x.Name).Select(x => x.Name);

            foreach (var n in names2)
            {
                Console.WriteLine("Name: {0}", n);
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            // Get only products with over 25 items in stock
            var overstock = from p in products where p.NumberInStock > 25 select p;
            var overstock2 = products.Where(x => x.NumberInStock > 25).OrderBy(x => x.Name).Select(x => x);

            foreach (ProductInfo prod in overstock)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c)
                .Except(from c2 in yourCars select c2);
            
            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (var car in carDiff)
            {
                Console.WriteLine(car);
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            // Get common members.
            var carIntersect = (from c in myCars select c)
                .Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
                Console.WriteLine(s);
        }
    }
}
