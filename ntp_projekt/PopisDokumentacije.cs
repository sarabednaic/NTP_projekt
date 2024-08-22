using dinamicLib;
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
using System.IO;

namespace ntp_projekt
{
    public partial class PopisDokumentacije : Form
    {
        
        public PopisDokumentacije()
        {
            InitializeComponent();
            PopisDokumentacijeProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisDokumentacijeProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

       

        private void PopisDokumentacijeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void PopisDokumentacijeProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisDokumentacijeProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisDokumentacije_Load(object sender, EventArgs e)
        {
            Baza baza;
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());
            PopisDokumentacijeNaslovLabel.Text = SessionZadatak.Naslov;
            PopisDokumentacijeBazaClanoviLabel.Text = "";
            PopisDokumentacijeBazaOpisLabel.Text = SessionZadatak.Opis;
            PopisDokumentacijeBazaPeriodLabel.Text = SessionZadatak.Pocetak + " - " + SessionZadatak.Kraj;

            baza = new Baza(@"..\..\TeamPlan.mdb");

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));

            foreach (var obj in jsonFile)
            {
                if ((string)obj["Zadatak_ID"] == SessionZadatak.Id)
                {
                    PopisDokumentacijeBazaStatusLabel.Text = obj["Status"].ToString();
                    if (obj["Status"].ToString() == "zavrseno") { PopisDokumentacijeStatusButton.BackColor = Color.Orange; }
                    else if (obj["Status"].ToString() == "nije zapoceto") { PopisDokumentacijeStatusButton.BackColor = Color.Gray; }
                    else if (obj["Status"].ToString() == "problem") { PopisDokumentacijeStatusButton.BackColor = Color.Red; }
                    else if (obj["Status"].ToString() == "u tijeku") { PopisDokumentacijeStatusButton.BackColor = Color.Green; }
                    break;
                }
            }

            List<string> clanovi = baza.ListaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ImePrezime " +
                "FROM (korisnik \r\nINNER JOIN clanovi_projekta ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                "INNER JOIN clanovi_zadatka ON clanovi_projekta.ID = clanovi_zadatka.clan_projekta_ID " +
                "WHERE clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");

            foreach(string clan in clanovi)
            {
                PopisDokumentacijeBazaClanoviLabel.Text = PopisDokumentacijeBazaClanoviLabel.Text + Environment.NewLine + clan;
            }

        }
    }
}
