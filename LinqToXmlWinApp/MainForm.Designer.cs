﻿namespace LinqToXmlWinApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
            this.btnLookUpColors = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(13, 13);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInventory.Size = new System.Drawing.Size(309, 293);
            this.txtInventory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Controls.Add(this.txtPetName);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(329, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Inventory Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet Name";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(70, 33);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(242, 20);
            this.txtMake.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(70, 65);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(242, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(70, 95);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(242, 20);
            this.txtPetName.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(179, 122);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(133, 23);
            this.btnAddNewItem.TabIndex = 6;
            this.btnAddNewItem.Text = "Add";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLookUpColors);
            this.groupBox2.Controls.Add(this.txtMakeToLookUp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(329, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up Colors for Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Make to look Up";
            // 
            // txtMakeToLookUp
            // 
            this.txtMakeToLookUp.Location = new System.Drawing.Point(99, 29);
            this.txtMakeToLookUp.Name = "txtMakeToLookUp";
            this.txtMakeToLookUp.Size = new System.Drawing.Size(213, 20);
            this.txtMakeToLookUp.TabIndex = 4;
            // 
            // btnLookUpColors
            // 
            this.btnLookUpColors.Location = new System.Drawing.Point(179, 55);
            this.btnLookUpColors.Name = "btnLookUpColors";
            this.btnLookUpColors.Size = new System.Drawing.Size(133, 23);
            this.btnLookUpColors.TabIndex = 7;
            this.btnLookUpColors.Text = "Look Up Colors";
            this.btnLookUpColors.UseVisualStyleBackColor = true;
            this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInventory);
            this.Name = "MainForm";
            this.Text = "Fun with LINQ to Xml";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLookUpColors;
        private System.Windows.Forms.TextBox txtMakeToLookUp;
        private System.Windows.Forms.Label label4;
    }
}

