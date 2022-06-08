using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tags.Exceptions
{
    internal class BlockedAccessException : Exception
    {
        public BlockedAccessException()
        {
        }

        public BlockedAccessException(string message) : base(message)
        {

        }

        public BlockedAccessException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
