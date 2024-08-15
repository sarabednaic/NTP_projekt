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
    public partial class PopisProjekta : Form
    {
        private Baza baza;
        public PopisProjekta()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
            string user = Session.DohvatiKorisnika();
            string ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            PopisProjektaProfilLinkLabel.Text = ime + " " + prezime;
        }

        private void UrediZadatakNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopisProjektaProfilPictureBox_Click_1(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaProfilLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaAddButton_Click_1(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new DodajProjekt();
        }

        private void PopisProjektaListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopisProjekta_Load(object sender, EventArgs e)
        {
            PopisProjektaProfilLinkLabel.Text = Session.Ime + " " + Session.Prezime;
        }
    }
}