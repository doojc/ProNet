﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Events ***\n");

            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers.
            //c1.AboutToBlow += CarIsAlmostDoomed;
            //c1.AboutToBlow += CarAboutToBlow;                      
            //c1.Exploded += CarExploded;

            c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
            c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };

            Console.WriteLine("Speeding up...");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //// Remove CarExploded method from invocation list.
            //c1.Exploded -= CarExploded;

            //Console.WriteLine("Speeding up");
            //for (int i = 0; i < 6; i++)
            //{
            //    c1.Accelerate(20);
            //}

            Console.ReadLine();
        }

        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            // Just to be safe, perform a runtime check before casting.
            if (sender is Car)
            {
                Car c = (Car)sender;
                Console.WriteLine("Critical message from {0}: {1}", c.PetName, e.msg);
            }
        }
           // Console.WriteLine("{0} says: {1}", sender, e.msg); }

        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        { Console.WriteLine("=> Critical Message from Car: {0}", e.msg); }

        public static void CarExploded(object sender, CarEventArgs e)
        { Console.WriteLine(e.msg); }
    }
}
