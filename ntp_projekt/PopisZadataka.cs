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
    public partial class PopisZadataka : Form
    {
        public PopisZadataka()
        {
            InitializeComponent();
            PopisZadatakaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisZadatakaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            PopisZadatkaControl popis = new PopisZadatkaControl();
            PopisZadatakaZadatciFlowLayoutPanel.Controls.Add(popis);
        }

        

        

        private void PopisZadatakaReportButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisDokumentacije();
        }

        private void PopisZadatakaAddButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new DodajZadatak();
        }

        private void PopisZadatakaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void PopisZadataka_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }
    }
}
