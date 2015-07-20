﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDisconnectedLayer;

namespace InventoryDALDisconnectedGUI
{
    public partial class MainForm : Form
    {
        InventoryDALDisLayer dal = null;

        public MainForm()
        {
            InitializeComponent();

            string cnStr = @"Data Source=(local)\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AutoLot";

            // Create our data access object.
            dal = new InventoryDALDisLayer(cnStr);

            // Fill up our grid.
            inventoryGrid.DataSource = dal.GetAllInventory();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            // Get modified data from the grid.
            DataTable changedDT = (DataTable)inventoryGrid.DataSource;

            try
            {
                // Commit our changes
                dal.UpdateInventory(changedDT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
