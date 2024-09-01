using dinamicLib;
using Newtonsoft.Json;
using ntp_projekt.TeamPlanDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ntp_projekt
{
    public partial class DodajZadatak : Form
    {
        private Baza baza;
        public DodajZadatak()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");

            DodajZadatakProfilLinkLabel.Text = Session.DohvatiPunoIme();
            DodajZadatakProfilPictureBox.Image = Session.DohvatiProfilnuSliku();

            //članovi
            List<List<string>> clanovi = baza.NaprednaBazaRead("SELECT clanovi_projekta.ID, korisnik.ime, korisnik.prezime, clanovi_projekta.admin " +
                                                               "FROM (clanovi_projekta " +
                                                               "INNER JOIN korisnik ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                                                               "WHERE clanovi_projekta.projekt_ID = " + SessionProjekt.dohvatiTrenutniProjekt().Id + ";");

            foreach (List<string> clan in clanovi)
            {
                DodajZadatakClanoviListBox.Items.Add(clan[1] + " " + clan[2]);
            }

            DodajZadatakStatusComboBox.Items.Add("zavrseno");
            DodajZadatakStatusComboBox.Items.Add("nije zapoceto");
            DodajZadatakStatusComboBox.Items.Add("problem");
            DodajZadatakStatusComboBox.Items.Add("u tijeku");

            DodajZadatakStatusComboBox.SelectedValueChanged += new EventHandler(DodajZadatakStatusComboBox_SelectedValueChanged);

        }

        //kada se dogodi promjena statusa automatski se mijenja boja
        public void DodajZadatakStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = DodajZadatakStatusComboBox.SelectedItem.ToString();

            if (selectedValue == "zavrseno")
            {
                DodajZadatakStatusButton.BackColor = Color.Orange;
            }
            else if (selectedValue == "nije zapoceto")
            {
                DodajZadatakStatusButton.BackColor = Color.Gray;
            }
            else if (selectedValue == "problem")
            {
                DodajZadatakStatusButton.BackColor = Color.Red;
            }
            else if (selectedValue == "u tijeku")
            {
                DodajZadatakStatusButton.BackColor = Color.Green;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DodajZadatakNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void DodajZadatakProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajZadatakProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajZadatakButton_Click(object sender, EventArgs e)
        {
            string formatiraniPocetak = DodajZadatakDateTimePicker1.Value.ToString("dd.MM.yyyy");
            string formatiraniKraj = DodajZadatakDateTimePicker2.Value.ToString("dd.MM.yyyy");

            //dodavanje zadatka u bazu podataka
            int upis = baza.BazaWrite("INSERT INTO zadatak (naziv, opis, vrijeme_pocetak, vrijeme_kraj) " +
                                      "VALUES ('" + DodajZadatakNazivTextBox.Text + "', '" + DodajZadatakOpisRichTextBox.Text + "', '" +
                                      formatiraniPocetak + "', '" + formatiraniKraj + "');");

            //dohvaca zadnji ID tj dodanog zadatka
            string zadatak_ID = baza.BazaRead("SELECT MAX(zadatak.id) FROM zadatak");

            //povezivanje članova sa zadatkom o ID-u zadatka
            foreach (var item in DodajZadatakClanoviListBox.CheckedItems)
            {
                string imePrezime = item.ToString();
                List<List<string>> clan = baza.NaprednaBazaRead("SELECT clanovi_projekta.ID FROM (clanovi_projekta " +
                                                "INNER JOIN korisnik ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                                                "WHERE (korisnik.ime & ' ' & korisnik.prezime) = '" + imePrezime + "' " +
                                                "AND clanovi_projekta.projekt_ID = " + SessionProjekt.dohvatiTrenutniProjekt().Id + ";");


                if (clan.Count > 0)
                {
                    int clan_projekta_ID = int.Parse(clan[0][0]);

                    int upisClanoviZadatka = baza.BazaWrite("INSERT INTO clanovi_zadatka (clan_projekta_ID, zadatak_ID) " +
                                                            "VALUES (" + clan_projekta_ID + ", " + zadatak_ID + ");");
                }
            }

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));

            //zadatkam s početnim statusom "nije zapoceto"
            var noviZadatak = new
            {
                Zadatak_ID = int.Parse(zadatak_ID),
                Status = "nije zapoceto"
            };

            //dodavanje zadatka
            jsonFile.Add(JObject.FromObject(noviZadatak));

            //spremi JSON
            File.WriteAllText(@"..\..\statusZadatka.json", JsonConvert.SerializeObject(jsonFile, Formatting.Indented));

            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }


        private void PopisProjektaPanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void DodajZadatak_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

            //HTTP klijent koji kaze trenutno vrijeme kako bi ravnali vrijeme projekta
            using (HttpClient client = new HttpClient())
            {
                string url = "http://worldtimeapi.org/api/timezone/Europe/Zagreb";

                HttpResponseMessage zahtjev = await client.GetAsync(url);

                if (zahtjev.IsSuccessStatusCode)
                {
                    string odgovor = await zahtjev.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(odgovor);
                    string currentTime = json["datetime"].ToString();
                    DodajZadatakTrenutnoVrijemeLabel.Text = currentTime;
                }
                else
                {
                    DodajZadatakTrenutnoVrijemeLabel.Text = "Pogreška pri dohvaćanju podataka o vremenu.";
                }
            }

        }

        private void DodajZadatakProfilPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
