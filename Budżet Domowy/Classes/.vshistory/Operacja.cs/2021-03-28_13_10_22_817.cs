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
        private DateTime m_dtDataWykonaniaOperacji;
        private int m_iIdOsoby;

        public int ID
        {
            get => m_iId;
            set => m_iId;
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

        public DateTime DataWykonaniaOperacji
        {
            get => m_dtDataWykonaniaOperacji;
            set;
        }

        public int IdOsoby
        {
            get => m_iIdOsoby;
            set;
        }
    }
}
