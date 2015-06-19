using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConnectedLayer;
using System.Configuration;
using System.Data;

namespace AutoLotCUIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** The AutoLot Console UI ***\n");

            // get connection string from App.config.
            string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            bool userDone = false;
            string userCommand = "";

            // Create our InventoryDAL object.
            InventoryDAL invDAL = new InventoryDAL();
            invDAL.OpenConnection(cnStr);

            // Keep asking for input untill user presses Q key.
            try
            {
                ShowInstructions();
                do
                {
                    Console.WriteLine("\nPlease enter your command: ");
                    userCommand = Console.ReadLine();
                    Console.WriteLine();

                    switch (userCommand.ToUpper())
                    {
                        case "I":
                            InsertNewCar(invDAL);
                            break;
                        case "U":
                            UpdateCarPetName(invDAL);
                            break;
                        case "D":
                            DeleteCar(invDAL);
                            break;
                        case "L":
                            ListInventory(invDAL);
                            break;
                        case "S":
                            ShowInstructions();
                            break;
                        case "P":
                            LookUpPetName(invDAL);
                            break;
                        case "Q":
                            userDone = true;
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                } while (!userDone);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            finally
            {
                invDAL.CloseConnection();
            }
        }

        private static void ShowInstructions() 
        { 
            Console.WriteLine("I: Inserts a new car."); 
            Console.WriteLine("U: Updates an existing car."); 
            Console.WriteLine("D: Deletes an existing car."); 
            Console.WriteLine("L: Lists current inventory."); 
            Console.WriteLine("S: Shows these instructions."); 
            Console.WriteLine("P: Looks up pet name."); 
            Console.WriteLine("Q: Quits program."); 
        }

        private static void ListInventory(InventoryDAL invDAL)
        {
            // Get the list of inventory
            DataTable dt = invDAL.GetAllInventoryAsDataTable();

            // Pass DataTable to helper function to display.
            DisplayTable(dt);
        }

        private static void DisplayTable(DataTable dt)
        {
            // Print out the column names.
            for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
            {
                Console.Write(dt.Columns[curCol].ColumnName + "\t");
            }

            Console.WriteLine("\n---------------------------------------");

            // Print the DataTable.
            for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
            {
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void DeleteCar(InventoryDAL invDAL)
        {
            // Get ID of car to delete.
            Console.Write("Enter ID of Car to delete: ");
            int id = int.Parse(Console.ReadLine());

            // Just in case you have a referential integrity violation
            try
            {
                invDAL.DeleteCar(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void InsertNewCar(InventoryDAL invDAL)
        {
            // First get user data.
            int newCarID;
            string newCarColor, newCarMake, newCarPetName;

            Console.Write("Enter Car ID: ");
            newCarID = int.Parse(Console.ReadLine());

            Console.Write("Enter Car Color: ");
            newCarColor = Console.ReadLine();

            Console.Write("Enter Car Make: ");
            newCarMake = Console.ReadLine();

            Console.Write("Enter Pet Name: ");
            newCarPetName = Console.ReadLine();

            // Now pass to data access library.
            //NewCar car = new NewCar();
            //car.CarID = newCarID;
            //car.Color = newCarColor;
            //car.Make = newCarMake;
            //car.PetName = newCarPetName;

            NewCar newCar = new NewCar(newCarID, newCarColor, newCarMake, newCarPetName);

            invDAL.InsertAuto(newCar);
        }

        private static void UpdateCarPetName(InventoryDAL invDAL)
        {
            // First get the user data.
            int carID;
            string newCarPetName;

            Console.Write("Enter Car ID: ");
            carID = int.Parse(Console.ReadLine());

            Console.Write("Enter New Pet Name: ");
            newCarPetName = Console.ReadLine();

            // Now pass to data acces library
            invDAL.UpdateCarPetName(carID, newCarPetName);
        }

        private static void LookUpPetName(InventoryDAL invDAL)
        {
            // Get ID of car to look up.
            int carID;

            Console.Write("Enter ID of Car to look up: ");
            carID = int.Parse(Console.ReadLine());

            Console.WriteLine("Petname of {0} is {1}.",
                carID, invDAL.LookUpPetName(carID).TrimEnd());
        }
    }
}
