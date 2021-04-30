using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.Exceptions
{
    class InvalidFieldContentException : Exception
    {
        public InvalidFieldContentException(string a_sNazwaPola) :
            base($"Pole <{a_sNazwaPola}> zawiera nieprawidłową wartość.")
        { 
        }
    }
}
