using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.Exceptions
{
    class InvalidUserRoleException : Exception
    {
        public InvalidUserRoleException() :
            base($"Wybrana rola jest nieprawidłowa.")
        {
        }
    }
}
