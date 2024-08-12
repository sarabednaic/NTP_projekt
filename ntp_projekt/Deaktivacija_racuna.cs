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
    public partial class Deaktivacija_racuna : Form
    {
        public Deaktivacija_racuna()
        {
            InitializeComponent();
        }

        private void PrijavaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaRegistracijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PrijavaLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrijavaPrijavaButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PrijavaKorisnickoImeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deaktivacija_racuna_Load(object sender, EventArgs e)
        {

        }

        private void DeaktivacijaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }
    }
}
