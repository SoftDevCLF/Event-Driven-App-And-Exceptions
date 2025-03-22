using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2EventDrivenAppAndExceptions.Data
{
    class SpecialCharactersException : ApplicationException
    {
        public SpecialCharactersException() : base() { }

        public SpecialCharactersException(string message) : base(message) { }
    }
}
