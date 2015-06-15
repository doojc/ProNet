using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                 new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},     
                 new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},     
                 new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},     
                 new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},     
                 new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };

            GetFastCars(myCars);

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            // Find all Car objects in the List<>, where Speed is greater than 55.
            var fastCars = myCars.Where(x => ((x.Speed > 95) && (x.Make.Equals("BMW")))).OrderBy(x => x.PetName).Select(x => x);

            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
    }
}
