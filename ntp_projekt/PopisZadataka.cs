using dinamicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlProjektiLibrary;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ntp_projekt
{
    public partial class PopisZadataka : Form
    {
        Baza baza;
        public PopisZadataka()
        {
            InitializeComponent();
            PopisZadatakaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisZadatakaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();


            baza = new Baza(@"..\..\TeamPlan.mdb");
            string statusZadatka = @"..\..\statusZadatka.json";
            string User = Session.DohvatiKorisnika();
            List<List<string>> polje = baza.NaprednaBazaRead($"SELECT korisnik.ID , zadatak.ID , zadatak.naziv," +
                $" zadatak.opis , zadatak.vrijeme_pocetak , zadatak.vrijeme_kraj , clanovi_projekta.projekt_ID FROM (((korisnik " +
                $" inner join clanovi_projekta on korisnik.ID = clanovi_projekta.korisnik_ID)" +
                $" inner join clanovi_zadatka on clanovi_projekta.ID = clanovi_zadatka.clan_projekta_ID) " +
                $" inner join zadatak on zadatak.ID = clanovi_zadatka.zadatak_ID) " +
                $" WHERE korisnik.korisnicko_ime = \"{User}\";");



            Projekt trenutniProjekt = SessionProjekt.dohvatiTrenutniProjekt();

            if (polje != null)
            {
                foreach (List<string> row in polje)
                {
                    if (trenutniProjekt.Id == row[6].ToString())
                    {
                        PopisZadatkaControl PopisZadatakaControl = new PopisZadatkaControl();
                        PopisZadatakaControl.setNaslov = row[2].ToString();
                        PopisZadatakaControl.setOpis = row[3].ToString();
                        PopisZadatakaZadatciFlowLayoutPanel.Controls.Add(PopisZadatakaControl);

                        dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"C:\Users\sbednaic\Desktop\proba\proba\statusZadatka.json"));

                        foreach (var obj in jsonFile)
                        {
                            if ((string)obj["Zadatak_ID"] == row[1].ToString())
                            {
                                PopisZadatakaControl.setStatus = obj["Status"].ToString();
                                if (obj["Status"].ToString() == "zavrseno") { PopisZadatakaControl.setBoja = Color.Orange; }
                                else if (obj["Status"].ToString() == "nije zapoceto") { PopisZadatakaControl.setBoja = Color.Gray; }
                                else if (obj["Status"].ToString() == "problem") { PopisZadatakaControl.setBoja = Color.Red; }
                                else if (obj["Status"].ToString() == "u tijeku") { PopisZadatakaControl.setBoja = Color.Green; }
                                break;
                            }
                        }
                    }
                }
            }
            PopisZadatakaImeProjektaLabel.Text = trenutniProjekt.Naslov;
            PopisZadatakaOpisLabel.Text = trenutniProjekt.Opis;




        }

        private void PopisZadatakaReportButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisDokumentacije();
        }

        private void PopisZadatakaAddButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new DodajZadatak();
        }

        private void PopisZadatakaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaNatragButton_Click(object sender, EventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void PopisZadataka_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }
    }
}
