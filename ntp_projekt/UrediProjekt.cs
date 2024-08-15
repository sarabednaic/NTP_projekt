﻿using System;
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
    public partial class UrediProjekt : Form
    {
        public UrediProjekt()
        {
            InitializeComponent();
            UrediProjektProfilLinkLabel.Text = Session.DohvatiPunoIme();
        }

        private void UrediProjektArrowButton_Click(object sender, EventArgs e)
        {

        }

        private void UrediZadatakNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeaktivacijaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void DeaktivacijaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new UrediProjekt();
        }

        private void DodajProjektNazivTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
