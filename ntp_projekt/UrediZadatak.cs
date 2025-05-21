using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DinamicLibrary;


namespace ntp_projekt
{
    public partial class UrediZadatak : Form
    {
        private Baza baza;
        Dictionary<string, Boolean> trenutniParovi = new Dictionary<string, Boolean>();
        Dictionary<string, Boolean> noviParovi = new Dictionary<string, Boolean>();
        string status;

        public UrediZadatak()
        {
            InitializeComponent();
            baza = new Baza(@"C:\xampp\htdocs\TeamPlan\TeamPlan.mdb");
            

            UrediZadatakProfilLinkLabel.Text = Session.DohvatiPunoIme();
            UrediZadatakProfilPictureBox.Image = Session.DohvatiProfilnuSliku();

            UrediZadatakStatusComboBox.Items.Add("zavrseno");
            UrediZadatakStatusComboBox.Items.Add("nije zapoceto");
            UrediZadatakStatusComboBox.Items.Add("problem");
            UrediZadatakStatusComboBox.Items.Add("u tijeku");

            UrediZadatakStatusComboBox.SelectedValueChanged += new EventHandler(UrediZadatakStatusComboBox_SelectedValueChanged);
        }

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
            // Implementacija funkcionalnosti nije definirana
        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            Boolean isAdmin = false;
            Boolean test = false;

            if (UrediZadatakStatusComboBox.Text.Equals(status)) { test = true; }


            string admin = baza.BazaRead($"SELECT clanovi_projekta.admin FROM " +
             "(korisnik INNER JOIN clanovi_projekta ON clanovi_projekta.korisnik_ID = korisnik.ID) " +
             "INNER JOIN projekt ON projekt.ID = clanovi_projekta.projekt_ID WHERE projekt.naziv = '" + SessionProjekt.dohvatiTrenutniProjekt().Naslov +
             "' And korisnik.ID = " + Session.DohvatiKorisnikID() + ";");

            if(admin.Equals("True")) { isAdmin = true; }


            if (!DodajZadatakNazivTextBox.Text.Equals(SessionZadatak.Naslov) ||
            !DodajZadatakOpisRichTextBox.Text.Equals (SessionZadatak.Opis) ||
            !DodajZadatakDateTimePicker1.Text.Equals( SessionZadatak.Pocetak) ||
            !DodajZadatakDateTimePicker2.Text.Equals(SessionZadatak.Kraj) ||
            test == false) 
            {
                string formatiraniPocetak = DodajZadatakDateTimePicker1.Value.ToString("MM/dd/yyyy");
                string formatiraniKraj = DodajZadatakDateTimePicker2.Value.ToString("MM/dd/yyyy");
                if (isAdmin)
                {
                    // Ažuriranje zapisa u bazi podataka s formatiranim datumima
                    int upis = baza.BazaWrite("UPDATE zadatak " +
                        "SET naziv = '" + DodajZadatakNazivTextBox.Text + "', " +
                        "opis = '" + DodajZadatakOpisRichTextBox.Text + "', " +
                        "vrijeme_pocetak = '" + formatiraniPocetak + "', " +
                        "vrijeme_kraj = '" + formatiraniKraj + "' " +
                        "WHERE ID = " + SessionZadatak.Id + ";");

                    //Dohvaća statuse zadataka iz json datoteke i mijenja ih po potrebi
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

                    //Brise članove zadatake ako su odkvačeni u listboxu
                    for (int i = 0; i < UrediZadatakClanoviListBox.Items.Count; i++)
                    {
                        if (UrediZadatakClanoviListBox.GetItemChecked(i) == false)
                        {
                            baza.BazaDelete("DELETE clanovi_zadatka.* " +
                                "FROM (clanovi_zadatka " +
                                "INNER JOIN clanovi_projekta ON clanovi_zadatka.clan_projekta_ID = clanovi_projekta.ID) " +
                                "INNER JOIN korisnik ON clanovi_projekta.korisnik_ID = korisnik.ID " +
                                "WHERE korisnik.ime & ' ' & korisnik.prezime = '" + UrediZadatakClanoviListBox.Items[i] + "' " +
                                "AND clanovi_projekta.projekt_ID = "+ SessionProjekt.dohvatiTrenutniProjekt().Id + "" +
                                "AND clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");
                        }
                        else if (UrediZadatakClanoviListBox.GetItemChecked(i) == true) 
                        {
                            Boolean Check = false;

                            List<List<string>> provjera = baza.NaprednaBazaRead("SELECT clanovi_zadatka.clan_projekta_ID , clanovi_zadatka.zadatak_ID " +
                            "FROM (clanovi_zadatka " +
                            "INNER JOIN clanovi_projekta ON clanovi_zadatka.clan_projekta_ID = clanovi_projekta.ID) " +
                            "INNER JOIN korisnik ON clanovi_projekta.korisnik_ID = korisnik.ID " +
                            "WHERE korisnik.ime & ' ' & korisnik.prezime = '" + UrediZadatakClanoviListBox.Items[i] + "' " +
                            "AND clanovi_projekta.projekt_ID = " + SessionProjekt.dohvatiTrenutniProjekt().Id + "" +
                            "AND clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");

                            if(provjera.Count == 0) Check = true;

                            if (Check) {
                                string clan_projekta_ID = baza.BazaRead("SELECT clanovi_projekta.ID FROM (clanovi_projekta INNER JOIN korisnik ON korisnik.ID = clanovi_projekta.korisnik_ID) "+
                                                                        "WHERE korisnik.ime & ' ' & korisnik.prezime = '"+ UrediZadatakClanoviListBox.Items[i] +"' AND clanovi_projekta.projekt_ID = "+ SessionProjekt.dohvatiTrenutniProjekt().Id +";");
                                baza.BazaWrite("INSERT INTO clanovi_zadatka (clan_projekta_ID,zadatak_ID) VALUES (," + SessionZadatak.Id + ")");
                            }
                            
                        };
                    }
                    TaskHistory newTask = new TaskHistory(Session.DohvatiKorisnikID(), DateTime.Now.ToString(), "zadatak uređen", SessionZadatak.Id);
                    TaskHistory.saveHistory(newTask);
                }
                else if (!isAdmin) {
                    string zadatakXMLputanja = @"C:\xampp\htdocs\TeamPlan\Zadatak.xml";
                    string zadatakNodes = "/Zadatci/Zadatak";

                    // Pretpostavimo da Access očekuje format datuma 'dd.MM.yyyy'


                    List<List<string>> clanovi = baza.NaprednaBazaRead("SELECT clanovi_projekta.korisnik_ID, clanovi_projekta.admin FROM " +
                     "(korisnik INNER JOIN clanovi_projekta ON clanovi_projekta.korisnik_ID = korisnik.ID) " +
                     "INNER JOIN projekt ON projekt.ID = clanovi_projekta.projekt_ID WHERE projekt.naziv = '" + SessionProjekt.dohvatiTrenutniProjekt().Naslov + "';");

                    string adminID = null;
                    foreach (List<string> clan in clanovi)
                    {
                        if ((string)clan[1] == "True")
                        {
                            adminID = clan[0].ToString();
                        }
                    }

                    for (int i = 0; i < UrediZadatakClanoviListBox.Items.Count; i++)
                    {
                        if (UrediZadatakClanoviListBox.GetItemCheckState(i).ToString().Equals("Checked"))
                        {
                            noviParovi.Add(UrediZadatakClanoviListBox.Items[i].ToString(), true);
                        }
                        else
                        {
                            noviParovi.Add(UrediZadatakClanoviListBox.Items[i].ToString(), false);
                        }
                    }

                    List<string> dodani = new List<string>();
                    List<string> izbrisani = new List<string>();

                    foreach (KeyValuePair<string, bool> entry1 in noviParovi)
                    {
                        foreach (KeyValuePair<string, bool> entry2 in trenutniParovi)
                        {
                            if (entry1.Key.Equals(entry2.Key) && !entry1.Value.Equals(entry2.Value))
                            {
                                if (entry1.Value.Equals(true) && entry2.Value.Equals(false)) dodani.Add(entry2.Key);
                                else if (entry1.Value.Equals(false) && entry2.Value.Equals(true)) izbrisani.Add(entry2.Key);
                            }
                        }
                    }

                    List<string> idDodani = new List<string>();
                    List<string> idIzbrisani = new List<string>();

                    foreach (string imeDodani in dodani)
                    {
                        string id = baza.BazaRead("SELECT korisnik_ID FROM clanovi_projekta WHERE korisnik_ID in" +
                                                    "(SELECT ID FROM korisnik where korisnik.ime & ' ' & korisnik.prezime = '" + imeDodani + "')" +
                                                    " and projekt_ID in (SELECT ID from projekt where projekt.naziv = '" + SessionProjekt.dohvatiTrenutniProjekt().Naslov + "');");
                        idDodani.Add(id);
                    }

                    foreach (string imeIzbrisani in izbrisani)
                    {
                        string id = baza.BazaRead("SELECT korisnik_ID FROM clanovi_projekta WHERE korisnik_ID in" +
                                                    "(SELECT ID FROM korisnik where korisnik.ime & ' ' & korisnik.prezime = '" + imeIzbrisani + "')" +
                                                    " and projekt_ID in (SELECT ID from projekt where projekt.naziv = '" + SessionProjekt.dohvatiTrenutniProjekt().Naslov + "');");
                        idIzbrisani.Add(id);
                    }


                    if (!string.IsNullOrEmpty(SessionZadatak.Id))
                    {
                        XmlOperator.XmlZadatakAdd(SessionZadatak.Id, adminID, DodajZadatakNazivTextBox.Text, DodajZadatakOpisRichTextBox.Text, formatiraniPocetak, formatiraniKraj, idDodani, idIzbrisani, zadatakXMLputanja, zadatakNodes);
                    }

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

                }
                
                StartApk.MainFormManager.TrenutnaForma = new UrediZadatak();
            }
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
            
            List<string> sviClanovi = baza.ListaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ime_prezime FROM " +
             "(korisnik INNER JOIN clanovi_projekta ON clanovi_projekta.korisnik_ID = korisnik.ID) " +
             "INNER JOIN projekt ON projekt.ID = clanovi_projekta.projekt_ID WHERE projekt.naziv = '" + SessionProjekt.dohvatiTrenutniProjekt().Naslov + " ';");


            List<string> clanovi = baza.ListaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ImePrezime " +
                "FROM ((korisnik INNER JOIN clanovi_projekta ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                "INNER JOIN clanovi_zadatka ON clanovi_projekta.ID = clanovi_zadatka.clan_projekta_ID) " +
                "WHERE clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");

            

            foreach (string clan in sviClanovi)
            {
                UrediZadatakClanoviListBox.Items.Add(clan);
            }

            for (int i = 0; i < clanovi.Count; i++)
            {
                for (int j = 0; j < sviClanovi.Count; j++) 
                {
                    if (clanovi[i].Equals(sviClanovi[j])) {
                        UrediZadatakClanoviListBox.SetItemChecked(j,true);
                    }
                }
            }

            for (int i = 0; i < UrediZadatakClanoviListBox.Items.Count; i++) {
                if (UrediZadatakClanoviListBox.GetItemCheckState(i).ToString().Equals("Checked"))
                {
                    trenutniParovi.Add(UrediZadatakClanoviListBox.Items[i].ToString(), true);
                }
                else 
                {
                    trenutniParovi.Add(UrediZadatakClanoviListBox.Items[i].ToString(), false);
                }
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

            status = UrediZadatakStatusComboBox.Text;
        }



        private void DodajZadatakClanoviListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

