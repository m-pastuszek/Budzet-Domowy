using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Operacja
    {
        private int m_iId;
        private int m_iRodzajOperacji;
        private double m_dWartoscOperacji;
        private int m_iIdOsoby;

        public int ID
        {
            get;
            set;
        }

        public int RodzajOperacji
        {
            get;
            set;
        }

        public double WartoscOperacji
        {
            get;
            set;
        }

        public int IdOsoby
        {
            get;
            set;
        }
    }
}
