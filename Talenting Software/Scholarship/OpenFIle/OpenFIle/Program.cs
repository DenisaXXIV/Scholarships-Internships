using OpenFIle.Models;
using OpenFIle.Utility;

namespace OpenFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            FileDisplayer fileDisplayer = new FileDisplayer();

            fileDisplayer.DisplayFIrst();
        }
    }
}

