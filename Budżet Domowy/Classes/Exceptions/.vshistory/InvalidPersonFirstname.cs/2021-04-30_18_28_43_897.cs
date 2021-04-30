using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.Exceptions
{
    class InvalidPersonFirstname : Exception
    {
        public InvalidPersonFirstname() : base("Imię użytkownika jest nieprawidłowe.");
    }
}
