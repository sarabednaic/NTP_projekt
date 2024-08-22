using Newtonsoft.Json;
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
using System.IO;

namespace ntp_projekt
{
    public partial class UrediZadatak : Form
    {
        public UrediZadatak()
        {
            InitializeComponent();
            Baza baza;
            baza = new Baza(@"..\..\TeamPlan.mdb");
            List<string> projekti = baza.ListaBazaRead("SELECT projekt.naziv FROM projekt");
            UrediZadatakProfilLinkLabel.Text = Session.DohvatiPunoIme();
            UrediZadatakProfilPictureBox.Image = Session.DohvatiProfilnuSliku();

            foreach (string projekt in projekti)
            {
                DodajZadatakProjektComboBox.Items.Add(projekt);
            }
        }

        private void UrediProjektArrowButton_Click(object sender, EventArgs e)
        {

        }

        private void BriasnjeProjektaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrediZadatakImeProjektaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeaktivacijaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void DeaktivacijaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajZadatakDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new UrediZadatak();
        }

        private void UrediZadatak_Load(object sender, EventArgs e)
        {
            //DodajZadatakProjektComboBox.Text = SessionZadatak.;
            DodajZadatakNazivTextBox.Text = SessionZadatak.Naslov;
            DodajZadatakOpisRichTextBox.Text = SessionZadatak.Opis;

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));

            foreach (var obj in jsonFile)
            {
                if ((string)obj["Zadatak_ID"] == SessionZadatak.Id)
                {
                    UrediZadatakStatusComboBox.Text = obj["Status"].ToString();
                    if (obj["Status"].ToString() == "zavrseno") { UrediZadatakStatusButton.BackColor = Color.Orange; }
                    else if (obj["Status"].ToString() == "nije zapoceto") { UrediZadatakStatusButton.BackColor = Color.Gray; }
                    else if (obj["Status"].ToString() == "problem") { UrediZadatakStatusButton.BackColor = Color.Red; }
                    else if (obj["Status"].ToString() == "u tijeku") { UrediZadatakStatusButton.BackColor = Color.Green; }
                    break;
                }
            }


        }
    }
}
