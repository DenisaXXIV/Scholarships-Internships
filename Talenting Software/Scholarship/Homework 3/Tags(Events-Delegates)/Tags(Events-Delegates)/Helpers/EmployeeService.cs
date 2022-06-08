using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tags_Events_Delegates_.Models;

namespace Tags_Events_Delegates_.Helpers
{
    public class EmployeeService
    {
        private readonly TagValidator _tagValidator;
        private readonly FileHelper _fileHelper;
        public delegate void EmployeeServiceDelegate(object source, EventArgs Args);
        public event EmployeeServiceDelegate EmployeeServiceEvent;

        public EmployeeService(TagValidator tagValidator, FileHelper fileHelper)
        {
            _tagValidator = tagValidator;
            _fileHelper = fileHelper;
        }

        public void AnEmployeeService()
        {
            Console.WriteLine("User registered");
            if (EmployeeServiceEvent != null)
            {
                EmployeeServiceEvent(this, EventArgs.Empty);
            }
        }

        public EmployeeService()
        {
            _tagValidator = new TagValidator();
            _fileHelper = new FileHelper();
        }

        public string GenerateTag()
        {
            char[] Chars = new char[]
            {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            string String = string.Empty;
            Random Random = new Random();

            for (byte index = 0; index < 5; index++)
            {
                String += Chars[Random.Next(0, Chars.Length - 1)];
            };

            return (String);
        }
    }
}
