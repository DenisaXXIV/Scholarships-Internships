using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags_Events_Delegates_.Models;

namespace Tags_Events_Delegates_.Helpers
{
    public class FileHelper
    {
        public string JSON_FILE = "";

        public FileHelper()
        {
            JSON_FILE = Path.GetFullPath(@"..\..\..\Resources\Company.json").ToString();
        }

        public Company ReadFile()
        {
            var result = new Company();
            using (Stream stream = new FileStream(JSON_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                if (File.Exists(JSON_FILE) && stream.Length > 0)
                {
                    string fileContents;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        fileContents = reader.ReadToEnd();
                    }
                    result = JsonConvert.DeserializeObject<Company>(fileContents);
                    return result;
                }

            }
            return result;
        }

        public void WriteFile(Company company)
        {
            using (Stream stream = new FileStream(JSON_FILE, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string toFile;
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    toFile = JsonConvert.SerializeObject(company);
                    writer.Write(toFile);
                }
            }
        }
    }
}
