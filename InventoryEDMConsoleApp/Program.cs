using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace InventoryEDMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with ADO.NET EF ***\n");
            AddNewRecord();
            PrintAllInventory();
            RemoveRecord();

            Console.ReadLine();
        }

        private static void AddNewRecord()
        {
            // Add record to the Inventory table of the AutoLot database
            using (AutoLotEntities context = new AutoLotEntities())
            {
                try
                {
                    // Hard-code data for a new record for testing.
                    context.Cars.Add(new Car() { CarID = 2222, Make = "Yugo", Color = "Brown" });
                    context.SaveChanges();                                       
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);                   
                }
            }
        }

        private static void PrintAllInventory()
        {
            // Select all items from the Inventory
            using (AutoLotEntities context = new AutoLotEntities())
            {
                foreach ( Car c in context.Cars)
                    Console.WriteLine(c);
            }
        }

        private static void RemoveRecord()
        {
            // Find a car to delete by primary key.
            using (AutoLotEntities context = new AutoLotEntities())
            {
                // See if we have it, and delete it if we do.
                // var carToDelete = (from c in context.Cars where c.CarID == 2222 select c).FirstOrDefault();

                var carToDelete2 = (context.Cars.Where(x => x.CarID == 2222).Select(x => x)).FirstOrDefault();

                if (carToDelete2 != null)
                {
                    Console.WriteLine("Removing car 2222...");
                    context.Cars.Remove(carToDelete2);
                    context.SaveChanges();
                    Console.WriteLine("Car 2222 removed from database.");
                }


            }
        }
    }
}
