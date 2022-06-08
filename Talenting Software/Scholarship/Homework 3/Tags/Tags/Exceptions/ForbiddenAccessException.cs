using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags.Exceptions
{
    internal class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException()
        {
        }

        public ForbiddenAccessException(string message) : base(message)
        {
        }

        public ForbiddenAccessException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
