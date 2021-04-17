using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class Osoba : XmlStorage<Osoba>
    {
        private int m_iId;
        private string m_sImie;
        private string m_sNazwisko;
        private double m_iStanKonta;
        private DateTime m_dtDataUtworzenia;
        private DateTime m_dtDataModyfikacji;
        private int m_iRolaID;

        public int ID
        {
            get => m_iId;
            set => m_iId = value;
        }
        public string Imie
        {
            get => m_sImie;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Imie> nie może być puste!");

                m_sImie = value;
            }
        }

        public string Nazwisko
        {
            get => m_sNazwisko;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Nazwisko> nie może być puste!");

                m_sNazwisko = value;
            }
        }

        public double StanKonta
        {
            get => m_iStanKonta;
            set
            {
                if (value < 0)
                    throw new Exception("Wartość pola <StanKonta> nie może być mniejsza od 0!");
                m_iStanKonta = value;
            }
        }
        public DateTime DataUtworzenia
        {
            get => m_dtDataUtworzenia;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("Pole <DataUtworzenia> nie może być puste!");
                }
                m_dtDataUtworzenia = value;
            }
        }
        public DateTime DataModyfikacji
        {
            get => m_dtDataModyfikacji;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("Pole <DataModyfikacji> nie może być puste!");
                }
                m_dtDataModyfikacji = value;
            }
        }

        public int RolaID
        {
            get => m_iRolaID;
            set
            {
                // rola musi istnieć w rolach
                // if (rola nie istnieje)
                // throw new Exception("...");
                if (value < 0)
                    throw new Exception("Niepoprawna wartość pola <RolaID>!");
                m_iRolaID = value;
            }
        }

        public Osoba()
        {

        }

        public Osoba(int ID, string Imie, string Nazwisko, double StanKonta, DateTime DataUtworzenia, DateTime DataModyfikacji, int RolaID) : this()
        {
            this.ID = m_iId;
            this.Imie = m_sImie;
            this.Nazwisko = m_sNazwisko;
            this.StanKonta = m_iStanKonta;
            this.DataUtworzenia = m_dtDataUtworzenia;
            this.DataModyfikacji = m_dtDataModyfikacji;
            this.RolaID = m_iRolaID;
        }
        //public void UpdateAccount(string Imie, string Nazwisko)
        //{
        //    if (string.IsNullOrWhiteSpace(Imie))
        //    {
        //        throw new Exception("Pole <Imie> nie może być puste!");
        //    }
        //    else if (string.IsNullOrWhiteSpace(Nazwisko))
        //    {
        //        throw new Exception("Pole <Nazwisko> nie może być puste!");
        //    }

        //    Imie = m_sImie;
        //    Nazwisko = m_sNazwisko;
        //    DataModyfikacji = DateTime.Now;
        //}

        public override bool InitializeFromObject(Osoba Object)
        {
            this.ID = Object.ID;
            this.Imie = Object.Imie;
            this.Nazwisko = Object.Nazwisko;
            this.DataUtworzenia = Object.DataUtworzenia;
            this.DataModyfikacji = Object.DataModyfikacji;
            this.RolaID = Object.RolaID;

            return true;
        }
    }
}