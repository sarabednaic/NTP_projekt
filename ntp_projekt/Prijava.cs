using System;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


namespace ntp_projekt
{
    public partial class Prijava : Form
    {
        private Baza baza;

        public Prijava()
        {
            InitializeComponent();
            baza = new Baza(@"C:\\Users\\sbednaic\\Desktop\\TeamPlan.mdb");
        }

        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void PrijavaLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrijavaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaPrijavaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik postojeciKorisnik = new Korisnik();
                postojeciKorisnik.KorisnickoIme = PrijavaKorisImeTextBox.Text;
                string query = $"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";";
                postojeciKorisnik.Lozinka = baza.BazaRead(query);

                if (PrijavaLozinkaTextBox.Text == postojeciKorisnik.Lozinka)
                {
                    Session.PostaviPodatke(postojeciKorisnik.KorisnickoIme);
                    StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka je netočna!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom prijave: " + ex.Message);
            }
        }

        private void PrijavaRegistracijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Registracija();
        }
    }
}
