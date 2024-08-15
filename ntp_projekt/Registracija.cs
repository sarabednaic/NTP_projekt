
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class Registracija : Form
    {
        private Baza baza;

        public Registracija()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik noviKorisnik = new Korisnik(
                    RegistracijaImeTextBox.Text,
                    RegistracijaPrezimeTextBox.Text,
                    RegistracijaKorisnickoTextBox.Text,
                    RegistracijaLozinkaTextBox.Text
                );

                // Provera da li lozinke odgovaraju
                if (noviKorisnik.Lozinka != RegistracijaPonovnoLozinkaTextBox.Text)
                {
                    MessageBox.Show("Lozinke se ne podudaraju.");
                    return;
                }

                string sol = Sha256.NasumicnaSol();
                string hashiranaLozinka = Sha256.Sazimanje(noviKorisnik.Lozinka, sol);

                // Provera da li već postoji korisnik sa istim korisničkim imenom
                string rezultat = baza.BazaRead("SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = \"" + noviKorisnik.KorisnickoIme + "\";");

                if (rezultat == "0")
                {
                    // SQL upit za upis novog korisnika u bazu
                    string upit = "INSERT INTO korisnik (korisnicko_ime, ime, prezime, lozinka, sol) VALUES (\""
                        + noviKorisnik.KorisnickoIme + "\", \""
                        + noviKorisnik.Ime + "\", \""
                        + noviKorisnik.Prezime + "\", \""
                        + hashiranaLozinka + "\", \""
                        + sol + "\");";

                    int prijava = baza.BazaWrite(upit);

                    if (prijava > 0)
                    {
                        MessageBox.Show("Registracija uspješna!");

                        StartApk.MainFormManager.TrenutnaForma = new Prijava();
                    }

                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom registracije.");
                    }
                }
                else
                {
                    MessageBox.Show("Korisničko ime je već zauzeto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }
        }
    }
}
