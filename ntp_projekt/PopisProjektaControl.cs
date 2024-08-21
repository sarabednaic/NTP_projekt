using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public partial class PopisProjektaControl : UserControl
    {
        string id;
        string naslov;
        string opis;
        string status;
        static Color boja;
        
        
        public PopisProjektaControl()
        {
            InitializeComponent();
            
        }

        public string Id { get { return id; } set { id = value; } }
        public string Naslov { get { return naslov; } set { naslov = value; PopisProjektaControlNaslovProjektaLabel.Text = value; } }
        public string Opis { get { return opis; } set { opis = value; PopisProjektaControlOpisLabel.Text = value; } }
        public string Status { get { return status; } set { status = value; PopisProjektaControlStatusLabel.Text = value; } }
        public void setBoja(string status){
            if (status.Equals("U tijeku")) {
                boja = Color.Yellow;
                button1.BackColor = boja;
            }
            else if (status.Equals("Završeno"))
            {
                boja = Color.Gray;
                button1.BackColor = boja;
            }
            else if (status.Equals("Otvoren problem"))
            {
                boja = Color.Red;
                button1.BackColor = boja;
            }
            else if (status.Equals("Nije započet"))
            {
                boja = Color.Green;
                button1.BackColor = boja;
            }
            else
            {
                boja = Color.Black;
                button1.BackColor = boja;
            }
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
            SessionProjekt.postaviTrenutniProjekt(Id, Naslov, Opis);
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();

        }
    }
}
