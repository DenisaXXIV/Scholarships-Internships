using JsonExercises.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonExercises.Utility
{
    public class FileReader
    {
        private const string JSON_FILE = "E:/Proiecte/Scholarships-Internships/Talenting Software/Scholarship/JsonExercises/JsonExercises/Resources/superheroes.json";

        public static Squad ReadSquad()
        {
            var result = new Squad();
            using (Stream stream = new FileStream(JSON_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                if (File.Exists(JSON_FILE) && stream.Length > 0)
                {
                    string fileContents;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        fileContents = reader.ReadToEnd();
                    }
                    result = JsonConvert.DeserializeObject<Squad>(fileContents);
                    return result;
                }

            }
            return result;
        }
    }
}
