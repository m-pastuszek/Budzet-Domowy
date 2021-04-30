using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Operacja : XmlStorage<Operacja>
    {
        private int m_iId;
        private string m_sKategoriaOperacji;
        private double m_dWartoscOperacji;
        private DateTime m_dtDataWykonaniaOperacji;
        private int m_iIdOsoby;

        public int ID
        {
            get => m_iId;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wartosc pola <ID> nie może być mniejsza od 0!");
                }
                m_iId = value;
            }
        }

        public string KategoriaOperacji
        {
            get => m_sKategoriaOperacji;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <RodzajOperacji> nie może być puste!");

                m_sKategoriaOperacji = value;
            }
        }

        public double WartoscOperacji
        {
            get => m_dWartoscOperacji;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wartosc pola <WartoscOperacji> nie może być mniejsza od 0!");
                }
                m_dWartoscOperacji = value;
            }
        }

        public DateTime DataWykonaniaOperacji
        {
            get => m_dtDataWykonaniaOperacji;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("Pole <DataWykonaniaOperacji> nie może być puste!");
                }
                m_dtDataWykonaniaOperacji = value;
            }
        }

        public int IdOsoby
        {
            get => m_iIdOsoby;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wartosc pola <IdOsoby> nie może być mniejsza od 0!");
                }
                m_iIdOsoby = value;
            }
        }

        public override bool InitializeFromObject(Operacja Object)
        {
            this.ID = Object.ID;
            this.KategoriaOperacji = Object.KategoriaOperacji;
            this.WartoscOperacji = Object.WartoscOperacji;
            this.DataWykonaniaOperacji = Object.DataWykonaniaOperacji;
            this.IdOsoby = Object.IdOsoby;

            return true;
        }
    }
}