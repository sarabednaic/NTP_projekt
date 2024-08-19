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

        public string setNaslov { set { PZControlNaslodLabel.Text = value; } }
        public string setOpis { set { PZControlPopisLabel.Text = value; } }
        public string setstatus { set { PZControlStatusLabel.Text = value; } }
        public Color setBoja { set { PZControlStatusButton.BackColor = value; } }

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
