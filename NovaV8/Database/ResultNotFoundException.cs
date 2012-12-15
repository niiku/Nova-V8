using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaV8
{
    class ResultNotFoundException : Exception
    {
        public ResultNotFoundException() : base() { }

        public ResultNotFoundException(String message) : base(message) { }

        public ResultNotFoundException(String message, Exception innerException) : base(message, innerException) { }
    }
}
