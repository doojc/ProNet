using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with StreamWriter / StreamReader ***\n");

            // Get a StreamWriter and write string data.
            using(StreamWriter writer = File.CreateText(@"C:\Temp\reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + " ");
                }

                writer.WriteLine(writer.NewLine);
            }

            Console.WriteLine("Created file and wrote some thoughts...");

            // Now read data from file.
            Console.WriteLine("Here are your thoughts:\n");
            using (StreamReader reader = File.OpenText(@"C:\Temp\reminders.txt"))
            {
                string input = null;

                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            
            Console.ReadLine();
        }
    }
}
