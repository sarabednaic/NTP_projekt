using System;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class Registracija : Form
    {
        private Baza baza;

        public Registracija()
        {
            InitializeComponent();
            baza = new Baza(@"C:\\Users\\sbednaic\\Desktop\\TeamPlan.mdb");
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string korisnicko_ime = RegistracijaKorisnickoTextBox.Text;
                string ime = RegistracijaImeTextBox.Text;
                string prezime = RegistracijaPrezimeTextBox.Text;
                string lozinka = RegistracijaLozinkaTextBox.Text;
                string ponovno_lozinka = RegistracijaPonovnoLozinkaTextBox.Text;

                
                string rezultat = baza.BazaRead("SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = \"{korisnicko_ime}\";");

                if (rezultat == "0" && lozinka == ponovno_lozinka)
                {
                    string queryInsert = "INSERT INTO korisnik (korisnicko_ime, ime, prezime, lozinka) VALUES (\"" + korisnicko_ime + "\", \"" + ime + "\", \"" + prezime + "\", \"" +  lozinka + "\")"; 
                    int prijava = baza.BazaWrite(queryInsert);

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
                else if (lozinka != ponovno_lozinka)
                {
                    MessageBox.Show("Lozinke se ne podudaraju.");
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
