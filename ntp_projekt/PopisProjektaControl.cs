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
    public partial class PopisProjektaControl : UserControl
    {
        public PopisProjektaControl()
        {
            InitializeComponent();
        }

        private void PopisProjektaControlEditButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new UrediProjekt();
        }

        private void PopisProjektaControlDeleteButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new BrisanjeProjekta();
        }

        private void PopisProjektaControlProjektButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }
    }
}
