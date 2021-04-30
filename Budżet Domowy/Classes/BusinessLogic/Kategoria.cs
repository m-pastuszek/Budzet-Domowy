using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes.BusinessLogic
{
    class Kategoria : XmlStorage<Kategoria>
    {
        private int m_iId;
        private string m_sNazwa;
        private string m_sOpis;
        private int m_iIdOperacji;

        public int ID
        {
            get => m_iId;
            set
            {
                if (value < 0)
                    throw new Exception("Wartosc pola <ID> nie może być mniejsza od 0!");
                m_iId = value;
            }
        }

        public string Nazwa
        {
            get => m_sNazwa;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Nazwa> nie może być puste!");
                m_sNazwa = value;
            }
        }

        public string Opis
        {
            get => m_sOpis;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Opis> nie może być puste!");
                m_sOpis = value;
            }
        }

        public int IdOperacji
        {
            get => m_iIdOperacji;
            set
            {
                if (value < 0)
                    throw new Exception("Wartosc pola <IdOperacji> nie może być mniejsza od 0!");
                m_iIdOperacji = value;
            }
        }
        public override bool InitializeFromObject(Kategoria Object)
        {
            this.ID = Object.ID;
            this.Nazwa = Object.Nazwa;
            this.Opis = Object.Opis;
            this.IdOperacji = Object.IdOperacji;

            return true;
        }
    }
}