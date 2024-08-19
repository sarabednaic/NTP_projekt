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
        string id;
        
        public PopisProjektaControl()
        {
            InitializeComponent();
        }
        
        public string setId { set { id = value; } }
        public string setNaslov { set { PopisProjektaControlNaslovProjektaLabel.Text = value;  } }
        public string setOpis { set { PopisProjektaControlOpisLabel.Text = value; } }
        public string setstatus { set { PopisProjektaControlStatusLabel.Text = value; } }
        public Color setBoja { set { button1.BackColor = value; } }


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
