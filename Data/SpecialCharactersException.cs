using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2EventDrivenAppAndExceptions.Data
{
    class SpecialCharactersException : ApplicationException
    {
        //parameterless constructor
        public SpecialCharactersException() : base() { }
        //constructor with parameters to overrwrite the paramaterless constructor w/ the exception message
        public SpecialCharactersException(string message) : base(message) { }
    }
}
