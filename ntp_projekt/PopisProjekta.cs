﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class PopisProjekta : Form
    {
        Ini iniFile;

        public PopisProjekta()
        {
            InitializeComponent();
            PopisProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");
            PopisProjektaControl popis = new PopisProjektaControl();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Add(popis);
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
            
        }

        private void PopisProjektaProjektiFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}