using dinamicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    
    public partial class Deaktivacija_racuna : Form
    {
        private Baza baza = new Baza(@"C:\xampp\htdocs\TeamPlan\TeamPlan.mdb");
        public Deaktivacija_racuna()
        {
            
            InitializeComponent();
            DeaktivacijaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            DeaktivacijaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

        private void PrijavaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaRegistracijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PrijavaLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrijavaPrijavaButton_Click(object sender, EventArgs e)
        {
            string user = Session.DohvatiKorisnika();
            string lozinkaKorisnika = baza.BazaRead($"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string sol = baza.BazaRead($"SELECT sol FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string hashiranaLozinka = Sha256.Sazimanje(DeaktivacijaLozinkaTextBox.Text, sol);
            if (DeaktivacijaLozinkaTextBox.Text.Length != 0 && DeaktivacijaPonovnoLozinkaTextBox.Text.Length != 0)
            {
                if (hashiranaLozinka == lozinkaKorisnika) {
                    if (DeaktivacijaLozinkaTextBox.Text == DeaktivacijaPonovnoLozinkaTextBox.Text)
                    {
                        Session.DeaktivirajRacun();
                        Session.CleanSession();
                        StartApk.MainFormManager.TrenutnaForma = new Prijava();
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne podudaraju.Pokušajte ponovno!");
                    }
                }          
            }
            else 
            {
                MessageBox.Show("Polja ne smiju biti prazna!");
            }
        }

        private void PrijavaKorisnickoImeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deaktivacija_racuna_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }

        private void DeaktivacijaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }
    }
}
