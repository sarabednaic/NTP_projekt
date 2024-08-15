using System;
using System.Drawing;
using ntp_projekt;

namespace ntp_projekt
{
    public static class Session
    {
        private static string ime;
        private static string prezime;
        private static string korisnicko_ime;

        public static string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }

        public static string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }


        public static string KorisnickoIme
        {
            get
            {
                return korisnicko_ime;
            }
            set
            {
                korisnicko_ime = value;
            }
        }

        public static void Podaci(string _ime, string _prezime, string _korisnicko_ime)
        {
            ime = _ime;
            prezime = _prezime;
            korisnicko_ime = _korisnicko_ime;
        }
    }
}
