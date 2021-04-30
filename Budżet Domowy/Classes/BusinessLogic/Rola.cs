using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Rola : XmlStorage<Rola>
    {
        private int m_iId;
        private string m_sNazwa;
        private string m_sOpis;

        public int ID
        {
            get => m_iId;
            set => m_iId = value;
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

        public override bool InitializeFromObject(Rola Object)
        {
            this.ID = Object.ID;
            this.Nazwa = Object.Nazwa;
            this.Opis = Object.Opis;

            return true;
        }
    }
}