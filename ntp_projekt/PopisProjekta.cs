using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlProjektiLibrary;
using dinamicLib;

namespace ntp_projekt
{
    public partial class PopisProjekta : Form
    {
        Ini iniFile;
        Baza baza;
        static Dictionary<string, Projekt> projektiLista = new Dictionary<string, Projekt>();  

        public PopisProjekta()
        {
            InitializeComponent();
            PopisProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");


            baza = new Baza(@"..\..\TeamPlan.mdb");
            string User = Session.DohvatiKorisnika();
            List<List<string>> polje = baza.NaprednaBazaRead($"SELECT korisnik.ID , projekt.ID , projekt.naziv, projekt.opis," +
                $" clanovi_projekta.admin FROM (korisnik inner join clanovi_projekta on korisnik.ID = clanovi_projekta.korisnik_ID)" +
                $" inner join projekt on clanovi_projekta.projekt_ID = projekt.id WHERE korisnik.korisnicko_ime = \"{User}\";");

            if (polje != null)
            {
                foreach (List<string> row in polje)
                {
                    PopisProjektaControl PopisProjektaControl = new PopisProjektaControl();
                    PopisProjektaControl.setNaslov = row[2].ToString();
                    PopisProjektaControl.setOpis = row[3].ToString();
                    PopisProjektaProjektiFlowLayoutPanel.Controls.Add(PopisProjektaControl);

                    
                }
            }
            
            

        }

        private void UrediZadatakNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopisProjektaProfilPictureBox_Click_1(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaProfilLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaAddButton_Click_1(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new DodajProjekt();
        }

        private void PopisProjektaListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopisProjekta_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());
        }

        private void PopisProjektaProjektiFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopisProjektaPanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}