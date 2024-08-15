using System;
using System.Drawing;
using ntp_projekt;

namespace ntp_projekt
{
    public static class Session
    {
        private static string korisnicko_ime;

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

        public static void PostaviPodatke(string _korisnicko_ime)
        {
            korisnicko_ime = _korisnicko_ime;
        }
    }
}
