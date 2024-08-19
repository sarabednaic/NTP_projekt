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
    public partial class PopisDokumentacije : Form
    {
        
        public PopisDokumentacije()
        {
            InitializeComponent();
            PopisDokumentacijeProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisDokumentacijeProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

       

        private void PopisDokumentacijeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void PopisDokumentacijeProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisDokumentacijeProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        
    }
}
