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
    public partial class BrisanjeZadatka : Form
    {
        public BrisanjeZadatka()
        {
            InitializeComponent();
            BrisanjeZadatkaProfilLinkLabel.Text = Session.DohvatiPunoIme();
        }

        private void BrisanjeProjektaUserButton_Click(object sender, EventArgs e)
        {

        }

        private void BriasnjeProjektaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaArrowButton_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaPFPButton_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void BrisanjeZadatkaIzbrisiZadatakButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeZadatkaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        
    }
}
