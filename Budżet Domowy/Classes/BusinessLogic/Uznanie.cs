using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.BusinessLogic
{
    class Uznanie : Operacja
    {
        public Uznanie(int m_iId, string m_sKategoriaOperacji, double m_dWartoscOperacji, DateTime m_dtDataWykonaniaOperacji, int m_iIdOsoby)
        {
            ID = m_iId;
            KategoriaOperacji = m_sKategoriaOperacji;
            WartoscOperacji = m_dWartoscOperacji;
            DataWykonaniaOperacji = m_dtDataWykonaniaOperacji;
            IdOsoby = m_iIdOsoby;
        }
    }
}