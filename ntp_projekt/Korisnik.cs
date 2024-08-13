using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

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
        public Korisnik(string _ime, string _prezime , string _korisnicko_ime , string _lozinka , int _jezik , Image _profilna) 
        {
            ime = _ime;
            prezime = _prezime;
            korisnicko_ime = _korisnicko_ime;
            lozinka = _lozinka;
            jezik = _jezik;
            
        }
    }
}
