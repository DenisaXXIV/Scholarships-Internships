using OpenFIle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFIle.Utility
{
    internal class FileDisplayer
    {
        public void Display(MyFile myFile)
        {
            FileManager fileManager = new FileManager();

            Console.WriteLine(" ---> PATH:   " + myFile.FilePath + '\n');
            Console.WriteLine(" ---> TEXT:\n" + myFile.Text + '\n');
            Console.WriteLine(" ---> NUMBER OF WORDS:   " + fileManager.GetNumberOfWords(myFile));
        }

        public void DisplayFIrst()
        {
            string response;
            FileReader reader = new FileReader();
            MyFile myFile = new MyFile();

            Console.WriteLine("\n\n                                           Hello!\n\n\n");
            Console.WriteLine("                   Do you want to open a specific file-text?\n\n");
            Console.WriteLine("  (y)YES, open a specific file-text        (n)NO, i want to use the default file\n\n");

            response = Console.ReadLine();

            switch (response)
            {
                case "y":
                    myFile = reader.LoadFileFrom();
                    break;
                case "n":
                    myFile = reader.LoadFile();
                    break;
            }

            Console.Clear();

            Display(myFile);
        }
    }
}
