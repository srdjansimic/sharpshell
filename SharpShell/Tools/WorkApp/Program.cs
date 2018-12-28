using System;
using System.Text;

namespace WorkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            const string currentFolder = @"C:\Source\Razno\sharpshell\Tests\TestData\ContextMenus";
            var currentDate = GetCurrentDate();
            string pathString = System.IO.Path.Combine(currentFolder, currentDate);

            CreateFolder(pathString);

            Console.WriteLine("Press any key...");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static string GetCurrentDate()
        {
            var currentDate = DateTime.Today;
            return currentDate.ToString("yyyy-MM-dd");
        }


        private static void CreateFolder(string pathString)
        {
            try
            {
                System.IO.Directory.CreateDirectory(pathString);

            }
            catch (Exception exception)
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Greska prilikom kreiranja foldera {pathString}: {exception.Message}");
            }
        }
    }
}
