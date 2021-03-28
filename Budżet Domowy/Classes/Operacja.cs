﻿using System;
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
            set => m_iId = value;
        }

        public int RodzajOperacji
        {
            get => m_iRodzajOperacji;
            set => m_iRodzajOperacji = value;
        }

        public double WartoscOperacji
        {
            get => m_dWartoscOperacji;
            set => m_dWartoscOperacji = value;
        }

        public DateTime DataWykonaniaOperacji
        {
            get => m_dtDataWykonaniaOperacji;
            set => m_dtDataWykonaniaOperacji = value;
        }

        public int IdOsoby
        {
            get => m_iIdOsoby;
            set => m_iIdOsoby = value;
        }
    }
}
