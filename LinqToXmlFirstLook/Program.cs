using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlFirstLook
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildXmlDocWithDOM();

            BuildXmlDocWithLINQToXml();

            MakeXElementFromArray();

            Console.ReadLine();
        }

        private static void BuildXmlDocWithDOM()
        {      
            // Make a new XML document in memory.
            XmlDocument doc = new XmlDocument();

            // Fill this document with a root element named <Inventory>
            XmlElement inventory = doc.CreateElement("Inventory");

            // Now, make a subelement named <Car> with an ID attribute.
            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("ID", "1000");

            // Build the data within the <Car> element.
            XmlElement name = doc.CreateElement("PetName");
            name.InnerText = "Jimbo";
            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Red";
            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "Ford";

            // Add <PetName>, <Color> and <Make> to the <Car> element
            car.AppendChild(name);
            car.AppendChild(color);
            car.AppendChild(make);

            // Add the <Car> element to the <Inventory> element.
            inventory.AppendChild(car);

            // Insert the complete XML into the XmlDocument object and save to file.
            doc.AppendChild(inventory);
            doc.Save("Inventory.xml");

            string str = File.ReadAllText("Inventory.xml");
            Console.WriteLine(str);
        }

        private static void BuildXmlDocWithLINQToXml()
        {
            // Create an XML document in a more "functional" manner.
            XElement doc =
                new XElement("Inventory",
                    new XElement("Car", new XAttribute("ID", "100"),
                        new XElement("PetName", "Jimbo"),
                        new XElement("Color", "Red"),
                        new XElement("Make", "Ford")
                    )
                );

            // Save to file.
            doc.Save("InventoryWithLINQ.xml");

            string str = File.ReadAllText("InventoryWithLINQ.xml");
            Console.WriteLine(str);
        }

        static void MakeXElementFromArray()
        {
            // Create an anonymous array of annonymous types.
            var people = new[] {
                new { FirstName = "Mandy", Age = 32},
                new { FirstName = "Andrew", Age = 40},
                new { FirstName = "Dave", Age = 41}
            };

            XElement peopleDoc =
                new XElement("People",
                    from p in people
                    select new XElement("Person", new XAttribute("Age", p.Age),
                                                   new XElement("FirstName", p.FirstName)));

            Console.WriteLine(peopleDoc);
        }

        static void ParseAndLoadExistingXml()
        {
            // Build an XElement from string.
            string myElement = 
                @"<Car ID ='3'>       
                    <Color>Yellow</Color>       
                    <Make>Yugo</Make>     
                </Car>";

            XElement newElement = XElement.Parse(myElement);
            Console.WriteLine(newElement);
            Console.WriteLine();

            // Load the InventoryWithLINQ.xml
            XDocument myDoc = XDocument.Load("InventoryWithLINQ.xml");
            Console.WriteLine(myDoc);
        }
    }
}
