using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Directory(Info) ***\n");
            ShowWindowsDirectoryInfo();
            DisplayPDFFiles();
            ModifyAppDirectory();

            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            // Dump directory info.
            DirectoryInfo dir = new DirectoryInfo(@"C:\Temp");
            Console.WriteLine("*** Directory Info *** ");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
        }

        static void DisplayPDFFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Temp");
            
            // Get all files with a *.pdf extension.
            FileInfo[] pdfFiles = dir.GetFiles("*.pdf", SearchOption.AllDirectories);

            // How many were found?
            Console.WriteLine("Found {0} *.pdf files\n", pdfFiles.Length);

            // Now print out info for each file.
            foreach (FileInfo f in pdfFiles)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
                Console.WriteLine("********************");
            }
        }


        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Temp");

            // Create \MyFolder off application directory.
            dir.CreateSubdirectory("MyFolder");

            // Create \MyFolder2\Data off application directory.
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");

            // Prints path to ..\MyFolder2\Data.
            Console.WriteLine("New Folder is: {0}", myDataFolder);
        }

        static void FunWithDirectoryType()
        {
            // List all drives on current computer.
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("here are your drives:");
            foreach (string d in drives)
            {
                Console.WriteLine("--> {0} ", d);
            }

            // Delete what was created.
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\Temp\MyFolder");

                // The second parameter specifies whether you wishh to destroy any subdirectories.
                Directory.Delete(@"C:\Temp\MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);                
            }
        }
        
    }
}
