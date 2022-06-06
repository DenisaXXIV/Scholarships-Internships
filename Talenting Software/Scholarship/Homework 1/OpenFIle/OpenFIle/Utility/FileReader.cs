using OpenFIle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFIle.Utility
{
    public class FileReader
    {
        private readonly string FILE_PATH = "E:/Proiecte/Scholarships-Internships/Talenting Software/" +
            "Scholarship/OpenFIle/OpenFIle/Resources/file.txt";

        public MyFile LoadFile()
        {
            MyFile myFile = new();

            if (File.Exists(FILE_PATH))
            {
                using StreamReader sr = File.OpenText(FILE_PATH);

                string text = sr.ReadToEnd();

                if (text != null)
                {
                    myFile.Text = text;
                    myFile.FilePath = FILE_PATH;
                }
            }

            return myFile;
        }

        public MyFile LoadFileFrom()
        {
            MyFile myFile = new();

            Console.WriteLine("Enter your file's path: \n" +
                "(Path example : E:/MyFolder/file.txt)");

            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                using StreamReader sr = File.OpenText(path);

                string text = sr.ReadToEnd();

                if (text != null)
                {
                    myFile.Text = text;
                    myFile.FilePath = FILE_PATH;
                }
            }

            return myFile;

            Console.Clear();
        }
    }
}
