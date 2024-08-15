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
    public partial class Postavke : Form
    {
        Baza baza;
        public Postavke()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
            string user = Session.DohvatiKorisnika();
            string ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            PostavkeImeTextBox.Text = ime;
            PostavkePrezimeTextBox.Text = prezime;
            PostavkeKorisnickoImeTextBox.Text = user;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeOdjavaButton_Click(object sender, EventArgs e)
        {   
            Session.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }

        private void PostavkeDeaktivacijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Deaktivacija_racuna();
        }

        private void PostavkePromjenaButton_Click(object sender, EventArgs e)
        {
            


            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PostavkeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}