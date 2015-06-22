﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
    public partial class MainForm : Form
    {
        // A collection of Car objects
        List<Car> listCars = null;

        // Inventory information.
        DataTable inventoryTable = new DataTable();

        // View of the DataTable.
        DataView yugosOnlyView;

        public MainForm()
        {
            InitializeComponent();

            // Fill the list with some cars.
            listCars = new List<Car>
            {
                new Car { ID = 100, PetName = "Chucky", Make = "BMW", Color = "Green" },       
                new Car { ID = 101, PetName = "Tiny", Make = "Yugo", Color = "White" },       
                new Car { ID = 102, PetName = "Ami", Make = "Jeep", Color = "Tan" },       
                new Car { ID = 103, PetName = "Pain Inducer", Make = "Caravan", Color = "Pink" },       
                new Car { ID = 104, PetName = "Fred", Make = "BMW", Color = "Green" },       
                new Car { ID = 105, PetName = "Sidd", Make = "BMW", Color = "Black" },       
                new Car { ID = 106, PetName = "Mel", Make = "Firebird", Color = "Red" },       
                new Car { ID = 107, PetName = "Sarah", Make = "Colt", Color = "Black" },
            };

            // Make a data table.
            CreateDataTable();

            // Make a view.
            CreateDataView();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateDataTable()
        {
            // Create table schema.
            DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
            DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
            DataColumn carColorColumn = new DataColumn("Color", typeof(string));
            DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
            carPetNameColumn.Caption = "Pet Name";
            inventoryTable.Columns.AddRange(new DataColumn[] { carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn });

            // Iterate over the List<T> to make rows.
            foreach (Car c in listCars)
            {
                DataRow newRow = inventoryTable.NewRow();
                newRow["CarID"] = c.ID;
                newRow["Make"] = c.Make;
                newRow["Color"] = c.Color;
                newRow["PetName"] = c.PetName;
                inventoryTable.Rows.Add(newRow);
            }

            // Bind the DataTable to the carInventoryGridView.
            carInventoryGridView.DataSource = inventoryTable;
        }

        private void CreateDataView()
        {
            // Set the table that is used to construct this view.
            yugosOnlyView = new DataView(inventoryTable);

            // Now configure the views using a filter.
            yugosOnlyView.RowFilter = "Make = 'Yugo'";

            // Bind to the new grid.
            dataGridYugosView.DataSource = yugosOnlyView;
        }


        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the correct row to delete
                DataRow[] rowToDelete = inventoryTable.Select(
                    string.Format("ID = {0}", int.Parse(txtCarToRemove.Text)));

                rowToDelete[0].Delete();
                inventoryTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            // Build a filter based on user input.
            string filterStr = string.Format("Make='{0}'", txtMakeToView.Text);

            // Find all rows matching the filter.
            DataRow[] makes = inventoryTable.Select(filterStr, "PetName");

            if (makes.Length == 0)
                MessageBox.Show("Sorry, no cars...", "Selection error!");
            else
            {
                string strMake = "";
                for (int i = 0; i < makes.Length; i++)
                {
                    // From the current row, get the PetName value.
                    strMake += makes[i]["PetName"] + "\n";
                }

                // Show the names of call cars matching the specified Make.
                MessageBox.Show(strMake, string.Format("We have {0}s named:", txtMakeToView.Text));
            }
        }
    }
}
