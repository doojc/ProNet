using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XmlReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string _sourceLocation;

            try
            {
                string jobXml = File.ReadAllText("C:\\Users\\edin.dujso.API\\Documents\\Visual Studio 2013\\Projects\\Pro.Net\\XmlReader\\Job.xml");

                XElement jobConfiguration = XElement.Parse(jobXml);

                if (jobConfiguration == null)
                    throw new ArgumentException("Job configuration is null or not initialized.");

                if (jobConfiguration.XPathSelectElement("Job/Configuration/BuildConfiguration/SourceUnc") == null)
                    throw new Exception("Required task configuration element was not found.");
                else
                    _sourceLocation = jobConfiguration.XPathSelectElement("BuildConfiguration/SourceUnc").Value.Trim();

                Console.WriteLine("Source location: {0}", _sourceLocation);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            Console.ReadLine();
        }
    }
}
