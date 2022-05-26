using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFIle.Models
{
    public class MyFile
    {
        private string _filePath;
        private string _text;

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (value != null)
                {
                    _filePath = value;
                }
            }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                if (value != null)
                {
                    _text = value;
                }
            }
        }
    }
}
