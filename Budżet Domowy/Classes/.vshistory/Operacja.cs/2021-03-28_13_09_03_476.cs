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
        private DateT
        private int m_iIdOsoby;

        public int ID
        {
            get => m_iId;
            set;
        }

        public int RodzajOperacji
        {
            get => m_iRodzajOperacji;
            set;
        }

        public double WartoscOperacji
        {
            get => m_dWartoscOperacji;
            set;
        }

        public int IdOsoby
        {
            get => m_iIdOsoby;
            set;
        }
    }
}
