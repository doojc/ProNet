﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace LinqToXmlWinApp
{
    class LinqToXmlObjectModel
    {
        public static XDocument GetXmlInventory()
        {
            try
            {
                XDocument inventoryDoc = XDocument.Load("Inventory.xml");
                return inventoryDoc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static XDocument InsertNewElement(string make, string color, string petName)
        {
            // Load current document.
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");

            // Generate a random number for the ID.
            Random r = new Random();

            // Make new XElement based on incoming parameters.
            XElement newElement = new XElement("Car", new XAttribute("ID", r.Next(50000)),                
                new XElement("Make", make),
                new XElement("Color", color),
                new XElement("PetName", petName));

            // Add to in-memory object.
            inventoryDoc.Descendants("Inventory").First().Add(newElement);

            // Save changes to disk.
            inventoryDoc.Save("Inventory.xml");

            return inventoryDoc;
        }

        public static void LookUpColorsForMake(string make)
        {
            // Load current document.
            XDocument inventoryDoc = XDocument.Load("Inventory.xml");

            // Find the colors for a given make.
            var makeInfo = from car in inventoryDoc.Descendants("Car")
                           where (string)car.Element("Make") == make
                           select car.Element("Color").Value;

            // Build a string representing each color.
            string data = string.Empty;
            foreach (var item in makeInfo)
            {
                data += string.Format("- {0}\n", item);
            }

            // Show colors.
            MessageBox.Show(data, string.Format("{0} colors:", make));
        }
    }
}
