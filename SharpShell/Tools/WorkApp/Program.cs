using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            CreateFolder();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void CreateFolder()
        {
            // Specify a name for your top-level folder.
            string folderName = @"C:\Source\Razno\sharpshell\Tests\TestData\ContextMenus";

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
            string pathString = System.IO.Path.Combine(folderName, "Test Folder");

            try
            {
                System.IO.Directory.CreateDirectory(pathString);

            }
            catch (Exception exception)
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Greska prilikom kreiranja foldera {folderName}: {exception.Message}");
            }
        }
    }
}
