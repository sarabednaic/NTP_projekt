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
    public partial class DodajProjekt : Form
    {
        public DodajProjekt()
        {
            InitializeComponent();
        }

        private void DodajProjektClanoviListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjektOvlastiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjekt_Load(object sender, EventArgs e)
        {

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
            StartApk.MainFormManager.TrenutnaForma = new DodajProjekt();
        }
    }
}
