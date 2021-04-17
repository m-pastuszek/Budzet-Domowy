using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Obciazenie : Operacja
    {
        public Obciazenie(int m_iId, string m_sRodzajOperacji, double m_dWartoscOperacji, DateTime m_dtDataWykonaniaOperacji, int m_iIdOsoby)
        {
            ID = m_iId;
            RodzajOperacji = m_sRodzajOperacji;
            WartoscOperacji = m_dWartoscOperacji;
            DataWykonaniaOperacji = m_dtDataWykonaniaOperacji;
            IdOsoby = m_iIdOsoby;
        }
    }
}