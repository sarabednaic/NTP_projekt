﻿using dinamicLib;
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
    public partial class DodajZadatak : Form
    {
        
        public DodajZadatak()
        {
            InitializeComponent(); 
            DodajZadatakProfilLinkLabel.Text = Session.DohvatiPunoIme();
            DodajZadatakProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajZadatakNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void DodajZadatakProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajZadatakProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajZadatakButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new DodajZadatak();
        }

        private void PopisProjektaPanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DodajZadatak_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }
    }
}
