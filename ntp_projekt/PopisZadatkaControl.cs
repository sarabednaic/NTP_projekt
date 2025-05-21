using System;
using System.Drawing;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class PopisZadatkaControl : UserControl
    {
        Boolean admin;

        


        public string Naslov
        {
            set { PZControlNaslovLabel.Text = value; }
            get { return PZControlNaslovLabel.Text; }
        }

        public string Opis
        {
            set { PZControlOpisLabel.Text = value; }
            get { return PZControlOpisLabel.Text; }
        }

        public string Status
        {
            set { PZControlStatusLabel.Text = value; }
            get { return PZControlStatusLabel.Text; }
        }

        public Color Boja
        {
            set { PZControlStatusButton.BackColor = value; }
            get { return PZControlStatusButton.BackColor; }
        }

        public Boolean Admin { get { return admin; } set { admin = value; } }

        public void provjera() {
            if (!Admin)
            {
                PZControlDeleteButton.Enabled = false;
                PZControlDeleteButton.Hide();
            }
            else
            {
                PZControlDeleteButton.Enabled = true;
                PZControlDeleteButton.Show();

            }
        }

        public PopisZadatkaControl()
        {
            InitializeComponent();
        }

        private void PZControlDeleteButton_Click(object sender, EventArgs e)
        {
            PopisZadataka.server.ZaustaviServer();
            PopisZadataka.server.Dispose();
            SessionZadatak.ZadatakaInfo(Naslov, Opis);
            StartApk.MainFormManager.TrenutnaForma = new BrisanjeZadatka();
        }

        private void PZControlEditButton_Click(object sender, EventArgs e)
        {
            PopisZadataka.server.ZaustaviServer();
            PopisZadataka.server.Dispose();
            SessionZadatak.ZadatakaInfo(Naslov, Opis);
            StartApk.MainFormManager.TrenutnaForma = new UrediZadatak();
        }

        private void PZControlZadatakButton_Click(object sender, EventArgs e)
        {
            PopisZadataka.server.ZaustaviServer();
            PopisZadataka.server.Dispose();
            SessionZadatak.ZadatakaInfo(Naslov, Opis);
            StartApk.MainFormManager.TrenutnaForma = new PopisDokumentacije();
        }
    }
}
