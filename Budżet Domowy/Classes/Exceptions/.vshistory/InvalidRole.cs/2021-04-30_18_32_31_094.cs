using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.Exceptions
{
    class InvalidPersonSurname : Exception
    {
        public InvalidPersonSurname() : base("Nazwisko użytkownika jest nieprawidłowe.")
        {

        }
    }
}
