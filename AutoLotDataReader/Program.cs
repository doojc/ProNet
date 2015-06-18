using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Data Readers ***\n");

            // Create and open a connection.
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AutoLot";
                cn.Open();

                // Create a SQL command object
                string strSQL = "Select * From Inventory";
                SqlCommand myCommand = new SqlCommand(strSQL, cn);

                // Obtain a data reader a la ExecuteReader().
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    // Loop over the results.
                    while (myDataReader.Read())
                    {
                        Console.WriteLine("*** Record ***");
                        for (int i = 0; i < myDataReader.FieldCount; i++)
                        {
                            Console.WriteLine("{0} = {1} ",
                                myDataReader.GetName(i),
                                myDataReader.GetValue(i).ToString());
                        }

                        Console.WriteLine();
                        //Console.WriteLine("-> Make: {0}, PetName: {1}, Color: {2}.",
                        //    myDataReader["Make"].ToString(), 
                        //    myDataReader["PetName"].ToString(), 
                        //    myDataReader["Color"].ToString());
                    }
                }

                cn.Close();
            }

            Console.ReadLine();
        }
    }
}
