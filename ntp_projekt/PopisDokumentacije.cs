using dinamicLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing; 
using System.IO;
using System.Windows.Forms;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


namespace ntp_projekt
{
    public partial class PopisDokumentacije : Form
    {
        public PopisDokumentacije()
        {
            InitializeComponent();
            //bez licence nece raditi
            QuestPDF.Settings.License = LicenseType.Community;
            PopisDokumentacijeProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisDokumentacijeProfilPictureBox.Image = (System.Drawing.Image)Session.DohvatiProfilnuSliku(); 
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
            PanelLogo.BackgroundImage = System.Drawing.Image.FromFile(Logo.LogoFoto()); 
            PopisDokumentacijeNaslovLabel.Text = SessionZadatak.Naslov;
            PopisDokumentacijeBazaClanoviLabel.Text = "";
            PopisDokumentacijeBazaOpisLabel.Text = SessionZadatak.Opis;
            PopisDokumentacijeBazaPeriodLabel.Text = SessionZadatak.Pocetak + ". - " + SessionZadatak.Kraj + ".";

            baza = new Baza(@"c:\TeamPlan.mdb");

            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));

            foreach (var obj in jsonFile)
            {
                if ((string)obj["Zadatak_ID"] == SessionZadatak.Id)
                {
                    PopisDokumentacijeBazaStatusLabel.Text = obj["Status"].ToString();
                    // treba ici system drawings jer colors postoji u ovom PDF lib
                    if (obj["Status"].ToString() == "zavrseno") { PopisDokumentacijeStatusButton.BackColor = System.Drawing.Color.Orange; }
                    else if (obj["Status"].ToString() == "nije zapoceto") { PopisDokumentacijeStatusButton.BackColor = System.Drawing.Color.Gray; }
                    else if (obj["Status"].ToString() == "problem") { PopisDokumentacijeStatusButton.BackColor = System.Drawing.Color.Red; }
                    else if (obj["Status"].ToString() == "u tijeku") { PopisDokumentacijeStatusButton.BackColor = System.Drawing.Color.Green; }
                    break;
                }
            }

            List<string> clanovi = baza.ListaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ImePrezime " +
                "FROM (korisnik \r\nINNER JOIN clanovi_projekta ON korisnik.ID = clanovi_projekta.korisnik_ID) " +
                "INNER JOIN clanovi_zadatka ON clanovi_projekta.ID = clanovi_zadatka.clan_projekta_ID " +
                "WHERE clanovi_zadatka.zadatak_ID = " + SessionZadatak.Id + ";");

            foreach (string clan in clanovi)
            {
                PopisDokumentacijeBazaClanoviLabel.Text = PopisDokumentacijeBazaClanoviLabel.Text + Environment.NewLine + clan;
            }
        }

        private void PopisDokumentacijeReportButton_Click(object sender, EventArgs e)
        {
            string naslov = PopisDokumentacijeNaslovLabel.Text;
            string opis = PopisDokumentacijeBazaOpisLabel.Text;
            string period = PopisDokumentacijeBazaPeriodLabel.Text;
            string status = PopisDokumentacijeBazaStatusLabel.Text;
            string clanovi = PopisDokumentacijeBazaClanoviLabel.Text;

            var pdfDocument = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(2, Unit.Centimetre);
                    page.Size(210, 297, Unit.Millimetre);

                    page.Header().Text(naslov)
                        .FontSize(24)
                        .SemiBold()
                        .AlignCenter()
                        .FontColor(QuestPDF.Helpers.Colors.Black); 

                    page.Content().PaddingVertical(1, Unit.Centimetre).Column(column =>
                    {
                        column.Item().Text("Opis zadatka:")
                            .FontSize(18)
                            .Bold();

                        column.Item().Text(opis)
                            .FontSize(14);

                        column.Item().PaddingBottom(0.5f, Unit.Centimetre); 

                        column.Item().Text("Period:")
                            .FontSize(18)
                            .Bold();

                        column.Item().Text(period)
                            .FontSize(14);

                        column.Item().PaddingBottom(0.5f, Unit.Centimetre); 

                        column.Item().Text("Status zadatka:")
                            .FontSize(18)
                            .Bold();

                        column.Item().Text(status)
                            .FontSize(14);

                        column.Item().PaddingBottom(0.5f, Unit.Centimetre); 

                        column.Item().Text("Članovi tima:")
                            .FontSize(18)
                            .Bold();

                        column.Item().Text(clanovi)
                            .FontSize(14);

                        column.Item().PaddingBottom(0.5f, Unit.Centimetre); 
                    });
                });
            });

            string download = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            string filePath = Path.Combine(download, SessionZadatak.Naslov + ".pdf");

            pdfDocument.GeneratePdf(filePath);

            
            MessageBox.Show("PDF dokument je uspješno generiran na lokaciji: " + filePath);
        }
    }
}
