using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet_Domowy.Classes
{
    class User
    {
        private int m_iId;
        private string m_sImie;
        private string m_sNazwisko;
        private int m_iRola;

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

        public int Rola
        {
            get => m_iRola;
            set
            {
                // rola musi istnieć w rolach
                m_iRola = value;
            }
        }

}
