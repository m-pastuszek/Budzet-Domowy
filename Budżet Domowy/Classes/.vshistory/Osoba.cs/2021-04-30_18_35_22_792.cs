using System;
using System.Collections.Generic;
using System.Text;
using Budżet_Domowy.Classes.Exceptions;

namespace Budżet_Domowy.Classes
{
    public class Osoba : XmlStorage<Osoba>
    {
        private int m_iId;
        private string m_sLogin;
        private string m_sHaslo;
        private string m_sImie;
        private string m_sNazwisko;
        private int m_iRola;

        public int ID
        {
            get => m_iId;
            set => m_iId = value;
        }

        public string Login
        {
            get;
            set;
        }

        public string Haslo
        {
            get;
            set;
        }

        public string Imie
        {
            get => m_sImie;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidFieldContentException();

                m_sImie = value;
            }
        }

        public string Nazwisko
        {
            get => m_sNazwisko;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidFieldContentException();

                m_sNazwisko = value;
            }
        }

        public int Rola
        {
            get => m_iRola;
            set
            {
                m_iRola = value;
            }
        }

        public Osoba()
        {
            
        }

        public Osoba(int ID, string Imie, string Nazwisko, int Rola) : this()
        {
            this.ID = m_iId;
            this.Imie = m_sImie;
            this.Nazwisko = m_sNazwisko;
            this.Rola = m_iRola;
        }

        public override bool InitializeFromObject(Osoba Object)
        {
            this.Login = Object.Login;
            this.Haslo = Object.Haslo;

            return true;
        }
    }
}
