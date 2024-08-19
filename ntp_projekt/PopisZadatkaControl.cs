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
    public partial class PopisZadatkaControl : UserControl
    {
        public PopisZadatkaControl()
        {
            InitializeComponent();
        }

        private void PZControlDeleteButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new BrisanjeZadatka();
        }

        private void PZControlEditButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new UrediZadatak();
        }

        private void PZControlZadatakButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisDokumentacije();
        }
    }
}
