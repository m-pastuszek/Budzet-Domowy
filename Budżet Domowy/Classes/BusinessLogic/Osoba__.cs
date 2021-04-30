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
        private DateTime m_dtDataUtworzenia;
        private DateTime m_dtDataModyfikacji;

        public int ID
        {
            get => m_iId;
            set => m_iId = value;
        }

        public string Login
        {
            get => m_sLogin;
            set => m_sLogin = value;
        }

        public string Haslo
        {
            get => m_sHaslo;
            set => m_sHaslo = value;
        }

        public string Imie
        {
            get => m_sImie;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidFieldContentException("Imie");

                m_sImie = value;
            }
        }

        public string Nazwisko
        {
            get => m_sNazwisko;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidFieldContentException("Nazwisko");

                m_sNazwisko = value;
            }
        }

        public DateTime DataUtworzenia
        {
            get => m_dtDataUtworzenia;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new InvalidFieldContentException("Data utworzenia");
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
                    throw new InvalidFieldContentException("Data modyfikacji");
                }
                m_dtDataModyfikacji = value;
            }
        }

        public int Rola
        {
            get => m_iRola;
            set
            {
                if (string.IsNullOrEmpty(value.ToString())) // dodać: && rola nie istnieje w klasie Rola()
                    throw new InvalidUserRoleException();
                else
                    m_iRola = value;                 
            }
        }

        public Osoba()
        {
            
        }

        public Osoba(int ID, string Imie, string Nazwisko, string Login, string Haslo, DateTime DataUtworzenia, DateTime DataModyfikacji, int Rola) : this()
        {
            this.ID = m_iId;
            this.Imie = m_sImie;
            this.Nazwisko = m_sNazwisko;
            this.Login = m_sLogin;
            this.Haslo = m_sHaslo;
            this.DataUtworzenia = m_dtDataUtworzenia;
            this.DataModyfikacji = m_dtDataModyfikacji;
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
