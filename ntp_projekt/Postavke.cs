using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class Postavke : Form
    {
        Baza baza;
        Ini iniFile;

        public Postavke()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");

            string user = Session.DohvatiKorisnika();
            string ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{user}\";");

            PostavkeImeTextBox.Text = ime;
            PostavkePrezimeTextBox.Text = prezime;
            PostavkeKorisnickoImeTextBox.Text = user;
            PostavkeJezikComboBox.Items.Add("hrvatski");
            PostavkeJezikComboBox.Items.Add("english");
            PostavkeVelicinaFontaComboBox.Items.Add("S");
            PostavkeVelicinaFontaComboBox.Items.Add("M");
            PostavkeVelicinaFontaComboBox.Items.Add("L");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeOdjavaButton_Click(object sender, EventArgs e)
        {   
            Session.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }

        private void PostavkeDeaktivacijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Deaktivacija_racuna();
        }

        private void PostavkePromjenaButton_Click(object sender, EventArgs e)
        {
            iniFile.PostaviVrijednost("Postavke", "Jezik", PostavkeJezikComboBox.SelectedItem.ToString());
            iniFile.PostaviVrijednost("Postavke", "Font", PostavkeVelicinaFontaComboBox.SelectedItem.ToString());
            iniFile.SpremiDatoteku(@"..\..\postavke.ini");

            string jezik = iniFile.DohvatiVrijednost("Postavke", "Jezik", "hrvatski");
            string font = iniFile.DohvatiVrijednost("Postavke", "Font", "M");

            if (jezik == "english")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            else if (jezik == "hrvatski")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
            }

            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PostavkeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            string jezik = iniFile.DohvatiVrijednost("Postavke", "Jezik", "hrvatski");
            string font = iniFile.DohvatiVrijednost("Postavke", "Font", "M");

            PostavkeJezikComboBox.SelectedItem = jezik;
            PostavkeVelicinaFontaComboBox.SelectedItem = font;


            if (jezik == "english")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            else if (jezik == "hrvatski")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
            }

            MessageBox.Show("Load");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}