using OpenFIle.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFIle.Utility
{
    public class FileManager
    {
        const string SEPARATORS = " \n,.?/!@#$%^&*()[]{}|\"':=+-_;<>~`";
        public int GetNumberOfWords(MyFile myFile)
        {
            int count = 0;
            StringBuilder word = new StringBuilder();

            foreach (char character in myFile.Text)
            {
                if (!SEPARATORS.Contains(character))
                {
                    word.Append(character);
                }

                if (SEPARATORS.Contains(character) && word.Length != 0)
                {
                    count++;
                    word.Clear();
                }
            }

            if (word.Length != 0)
            {
                count++;
            }

            return count;
        }

    }
}
