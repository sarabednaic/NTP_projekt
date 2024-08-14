using System;
using System.Data.OleDb;
using System.Windows.Forms;

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
                string korisnicko_ime = PrijavaKorisImeTextBox.Text;
                string query = $"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{korisnicko_ime}\";";
                string lozinka = baza.BazaRead(query);

                if (PrijavaLozinkaTextBox.Text == lozinka)
                {
                    StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka je netočna!");
                }
            }
            catch (Exception ex)
            {
                // Obrada greške - prikaz poruke korisniku
                MessageBox.Show("Došlo je do greške prilikom prijave: " + ex.Message);
            }
        }

        private void PrijavaRegistracijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Registracija();
        }
    }
}
