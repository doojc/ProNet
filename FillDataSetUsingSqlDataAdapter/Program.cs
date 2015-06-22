﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace FillDataSetUsingSqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Data Adapters ***\n");

            // Hard-coded connection string.
            string cnStr = @"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AutoLot";

            // Caller creates the DataSet object.
            DataSet ds = new DataSet("AutoLot");

            // Inform adapter of the Select command text and connection string.
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select * From Inventory", cnStr);

            // Fill our DataSet with a new table, named Inventory.
            dAdapt.Fill(ds, "Inventory");

            // Display contents of DataSet using helper method created earlier in this chapter.
            PrintDataSet(ds);
            Console.ReadLine();
        }

        static void PrintDataSet(DataSet ds) 
        {   
            // Print out the DataSet name, plus any extended properties.    
            Console.WriteLine("DataSet is named: {0}", ds.DataSetName);   
            foreach (System.Collections.DictionaryEntry de in ds.ExtendedProperties)   
            {     
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);   
            }   
            Console.WriteLine();  

            foreach (DataTable dt in ds.Tables)   
            {     
                Console.WriteLine("=> {0} Table:", dt.TableName);  
                // Print out the column names.     
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)     
                {       
                    Console.Write(dt.Columns[curCol].ColumnName.Trim() + "\t");     
                }     
                Console.WriteLine("\n----------------------------------");  
                // Call our new helper method.     
                PrintTable(dt);   
            } 
        }

        static void PrintTable(DataTable dt) 
        {  
            // Get the DataTableReader type.   
            DataTableReader dtReader = dt.CreateDataReader();
            // The DataTableReader works just like the DataReader.   
            while (dtReader.Read())   
            {     
                for (int i = 0; i < dtReader.FieldCount; i++)     
                {       
                    Console.Write("{0}\t", dtReader.GetValue(i).ToString().Trim());     
                }     
                Console.WriteLine();   
            }   
            dtReader.Close(); 
        }
    }
}
