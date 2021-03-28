using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Rola
    {
        private int m_iId;
        private string m_sNazwa;
        private string m_sOpis;

        public int ID
        {
            get;
            set;
        }

        public string Nazwa
        {
            get;
            set;
        }

        public string Opis
        {
            get;
            set;
        }
    }
}
