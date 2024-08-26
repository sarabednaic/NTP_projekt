using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public partial class UrediZadatak : Form
    {
        private Baza baza;

        public UrediZadatak()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");

            UrediZadatakProfilLinkLabel.Text = Session.DohvatiPunoIme();
            UrediZadatakProfilPictureBox.Image = Session.DohvatiProfilnuSliku();

            UrediZadatakStatusComboBox.Items.Add("zavrseno");
            UrediZadatakStatusComboBox.Items.Add("nije zapoceto");
            UrediZadatakStatusComboBox.Items.Add("problem");
            UrediZadatakStatusComboBox.Items.Add("u tijeku");

            UrediZadatakStatusComboBox.SelectedValueChanged += new EventHandler(UrediZadatakStatusComboBox_SelectedValueChanged);
        }

        // Metoda koja se poziva kada se promijeni vrijednost u ComboBox-u
        public void UrediZadatakStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = UrediZadatakStatusComboBox.SelectedItem.ToString();

            if (selectedValue == "zavrseno")
            {
                UrediZadatakStatusButton.BackColor = Color.Orange;
            }
            else if (selectedValue == "nije zapoceto")
            {
                UrediZadatakStatusButton.BackColor = Color.Gray;
            }
            else if (selectedValue == "problem")
            {
                UrediZadatakStatusButton.BackColor = Color.Red;
            }
            else if (selectedValue == "u tijeku")
            {
                UrediZadatakStatusButton.BackColor = Color.Green;
            }

        }

        private void UrediProjektArrowButton_Click(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void BriasnjeProjektaNaslovLabel_Click(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }

        private void UrediZadatakImeProjektaTextBox_TextChanged(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
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
            // Implementacija funkcionalnosti nije definirana
        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            // Pretpostavimo da Access očekuje format datuma 'dd.MM.yyyy'
            string formatiraniPocetak = DodajZadatakDateTimePicker1.Value.ToString("dd.MM.yyyy");
            string formatiraniKraj = DodajZadatakDateTimePicker2.Value.ToString("dd.MM.yyyy");

            // Ažuriranje zapisa u bazi podataka s formatiranim datumima
            int upis = baza.BazaWrite("UPDATE zadatak " +
                "SET naziv = '" + DodajZadatakNazivTextBox.Text + "', " +
                "opis = '" + DodajZadatakOpisRichTextBox.Text + "', " +
                "vrijeme_pocetak = '" + formatiraniPocetak + "', " +
                "vrijeme_kraj = '" + formatiraniKraj + "' " +
                "WHERE ID = " + SessionZadatak.Id + ";");


            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));
            foreach (var obj in jsonFile)
            {
                if ((string)obj["Zadatak_ID"] == SessionZadatak.Id)
                {
                    obj["Status"] = UrediZadatakStatusComboBox.SelectedItem.ToString();
                    break;
                }
            }
            File.WriteAllText(@"..\..\statusZadatka.json", JsonConvert.SerializeObject(jsonFile, Formatting.Indented));

            for (int i = 0; i < UrediZadatakClanoviListBox.Items.Count; i++)
            {
                if (UrediZadatakClanoviListBox.GetItemChecked(i) == false)
                {
                    baza.BazaDelete("DELETE clanovi_zadatka.* " +
                        "FROM (clanovi_zadatka " +
                        "INNER JOIN clanovi_projekta ON clanovi_zadatka.clan_projekta_ID = clanovi_projekta.ID) " +
                        "INNER JOIN korisnik ON clanovi_projekta.korisnik_ID = korisnik.ID " +
                        "WHERE korisnik.ime & ' ' & korisnik.prezime = '" + UrediZadatakClanoviListBox.Items[i] + "' " +
                        "AND clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");
                };
            }

            StartApk.MainFormManager.TrenutnaForma = new UrediZadatak();
        }

        private void UrediZadatak_Load(object sender, EventArgs e)
        {
            // Provjerite je li SessionZadatak.Id postavljen prije nego što se upišu ostali podaci
            if (string.IsNullOrEmpty(SessionZadatak.Id))
            {
                MessageBox.Show("ID zadatka nije postavljen.");
                return;
            }

            SessionZadatak.ZadatakaInfoById(SessionZadatak.Id);


            List<string> clanovi = baza.ListaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ImePrezime " +
                "FROM ((korisnik INNER JOIN clanovi_projekta ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                "INNER JOIN clanovi_zadatka ON clanovi_projekta.ID = clanovi_zadatka.clan_projekta_ID) " +
                "WHERE clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");

            foreach (string clan in clanovi)
            {
                UrediZadatakClanoviListBox.Items.Add(clan);
            }

            for (int i = 0; i < clanovi.Count; i++)
            {
                UrediZadatakClanoviListBox.SetItemChecked(i, true);
            }            

            DodajZadatakNazivTextBox.Text = SessionZadatak.Naslov;
            DodajZadatakOpisRichTextBox.Text = SessionZadatak.Opis;
            DodajZadatakDateTimePicker1.Text = SessionZadatak.Pocetak;
            DodajZadatakDateTimePicker2.Text = SessionZadatak.Kraj;

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



        private void DodajZadatakClanoviListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementacija funkcionalnosti nije definirana
        }
    }
}

