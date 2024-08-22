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
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public partial class DodajProjekt : Form
    {
        
        public DodajProjekt()
        {
            InitializeComponent();
            
            DodajProjektProfilLinkLabel.Text = Session.DohvatiPunoIme();
            DodajProjektProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

        private void DodajProjektClanoviListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjektOvlastiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjekt_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }

        private void DodajProjektNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void DodajProjektProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajProjektProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                //Projekt projekt = new Projekt(,DodajProjektNazivTextBox.Text,DodajProjektOpisRichTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju projekta: " + ex.Message);
            }
            StartApk.MainFormManager.TrenutnaForma = new DodajProjekt();
        }
    }
}
