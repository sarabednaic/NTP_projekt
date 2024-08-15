using System;
using System.Drawing;

namespace ntp_projekt
{
    internal class Korisnik
    {
        private string ime;
        private string prezime;
        private string korisnicko_ime;
        private string lozinka;
        private int jezik;
        private Image profilna;

 
        public Korisnik(string _ime, string _prezime, string _korisnicko_ime, string _lozinka)
        {
            ime = _ime;
            prezime = _prezime;
            korisnicko_ime = _korisnicko_ime;
            lozinka = _lozinka;
        }

        public Korisnik(string _korisnicko_ime, string _lozinka)
        {
            korisnicko_ime = _korisnicko_ime;
            lozinka = _lozinka;
        }

        public Korisnik(){}

        public string Ime
        {
            get { 
                return ime; 
            }

            set { 
                ime = value; 
            }
        }

        public string Prezime
        {
            get { 
                return prezime; 
            }

            set { 
                prezime = value; 
            }
        }

        public string KorisnickoIme
        {
            get { 
                return korisnicko_ime;
            }

            set { 
                korisnicko_ime = value; 
            }
        }

        public string Lozinka
        {
            get { 
                return lozinka; 
            }

            set { 
                lozinka = value; 
            }
        }

    }
}
