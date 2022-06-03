using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Exceptions
{
    internal class InvalidProgramException : Exception
    {
        public InvalidProgramException(string message) : base("Invalid Program! The company allow us to work in interval 8:00-18:00, with a lunch break of 45 minutes")
        {

        }

        public InvalidProgramException() : base("Invalid Program! The company allow us to work in interval 8:00-18:00, with a lunch break of 45 minutes")
        {

        }
    }
}
