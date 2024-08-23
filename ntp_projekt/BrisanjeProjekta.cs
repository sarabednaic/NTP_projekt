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
    public partial class BrisanjeProjekta : Form
    {
        public BrisanjeProjekta()
        {
            InitializeComponent();
            BrisanjeProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            BrisanjeProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }
      

        private void DodajProjektProfilPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrisanjeProjekta_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());
        }

        private void BrisanjeProjektaProfilPictureBox_Click(object sender, EventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeProjektaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeProjektaNatragButton_Click(object sender, EventArgs e)
        {

            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }


        private void BrisanjeProjektaIzbrisiProjektButton_Click(object sender, EventArgs e)
        {

            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }
    }
}
