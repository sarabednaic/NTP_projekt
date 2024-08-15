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
            baza = new Baza(@"..\..\TeamPlan.mdb");
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
                string lozinkaKorisnika = baza.BazaRead($"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                string sol = baza.BazaRead($"SELECT sol FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                string hashiranaLozinka = Sha256.Sazimanje(PrijavaLozinkaTextBox.Text, sol);

                if (hashiranaLozinka == lozinkaKorisnika)
                {
                    //Session.PostaviPodatke(postojeciKorisnik.KorisnickoIme);
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