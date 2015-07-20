using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToXmlWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            // Add new item to doc.
            txtInventory.Text = LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text).ToString();
        }

        private void btnLookUpColors_Click(object sender, EventArgs e)
        {
            // Lookup colors for given make
            LinqToXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // Display current XML inventory document in TextBox control.
            txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
        }
    }
}
