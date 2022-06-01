using JsonExercises.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExercises.Utility
{
    internal class FileWriter
    {
        private const string FILE_PATH = @"..\..\..\Resources";

        public static void WriteSquad(Squad newSquad, string fileName)
        {
            var fullPath = Path.GetFullPath(FILE_PATH);
            var newJsonFile = Path.Combine(FILE_PATH, fileName);
            using (Stream stream = new FileStream(newJsonFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string toFile;
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    toFile = JsonConvert.SerializeObject(newSquad);
                    writer.Write(toFile);
                }
            }
        }

        public static void WriteSquads(List<Squad> newSquads, string fileName)
        {
            var fullPath = Path.GetFullPath(FILE_PATH);
            var newJsonFile = Path.Combine(FILE_PATH, fileName);
            using (Stream stream = new FileStream(newJsonFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string toFile;
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    toFile = JsonConvert.SerializeObject(newSquads);
                    writer.Write(toFile);
                }
            }
        }
    }
}
