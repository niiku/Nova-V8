using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaV8
{
    class DatabaseException : Exception
    {
        public DatabaseException() : base() { }

        public DatabaseException(String message) : base(message) { }

        public DatabaseException(String message, Exception innerException) : base(message, innerException) { }

    }
}
