using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "APGang";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();

            Garage g = new Garage();
            g.MyAuto = c;

            
            // Ok, prints default value of zero
            Console.WriteLine("Number of Cars: {0}", g.NumberofCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}
