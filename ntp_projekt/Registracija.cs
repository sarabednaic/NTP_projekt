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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }

        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }
    }
}
