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
using DinamicLibrary;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ntp_projekt.TeamPlanDataSetTableAdapters;
using System.Net.Sockets;
using System.Net;
using System.Net.Http.Headers;
using TCPServerExe;
using UDPServer;


namespace ntp_projekt
{
    public partial class PopisZadataka : Form
    {
        Baza baza;
        public static udpServer server;
        public static IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
        public PopisZadataka()
        {
            InitializeComponent();
            PopisZadatakaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisZadatakaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            

            baza = new Baza(@"..\..\TeamPlan.mdb");
            
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
                        PopisZadatakaControl.Naslov = row[2].ToString();
                        PopisZadatakaControl.Opis = row[3].ToString();
                        PopisZadatakaZadatciFlowLayoutPanel.Controls.Add(PopisZadatakaControl);

                        dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));

                        foreach (var obj in jsonFile)
                        {
                            if ((string)obj["Zadatak_ID"] == row[1].ToString())
                            {
                                PopisZadatakaControl.Status = obj["Status"].ToString();
                                if (obj["Status"].ToString() == "zavrseno") { PopisZadatakaControl.Boja = Color.Orange; }
                                else if (obj["Status"].ToString() == "nije zapoceto") { PopisZadatakaControl.Boja = Color.Gray; }
                                else if (obj["Status"].ToString() == "problem") { PopisZadatakaControl.Boja = Color.Red; }
                                else if (obj["Status"].ToString() == "u tijeku") { PopisZadatakaControl.Boja = Color.Green; }
                                break;
                            }
                        }

                    }

                }
            }

            PopisZadatakaImeProjektaLabel.Text = trenutniProjekt.Naslov;
            PopisZadatakaOpisLabel.Text = trenutniProjekt.Opis;
        }

        

        private void PopisZadatakaAddButton_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            server.Dispose();
            
            StartApk.MainFormManager.TrenutnaForma = new DodajZadatak();
        }

        private void PopisZadatakaProfilPictureBox_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            server.Dispose();
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            server.ZaustaviServer();
            server.Dispose();
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisZadatakaNatragButton_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            server.Dispose();
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void PopisZadataka_Load(object sender, EventArgs e)
        {
            PopisZadatakaClanoviListBox.Items.Clear();
            PopisZadatakaAdminiListBox.Items.Clear();
            List<List<string>> clanovi = baza.NaprednaBazaRead("SELECT korisnik.ime & ' ' & korisnik.prezime AS ime_prezime, clanovi_projekta.admin FROM " +
             "(korisnik INNER JOIN clanovi_projekta ON clanovi_projekta.korisnik_ID = korisnik.ID) " +
             "INNER JOIN projekt ON projekt.ID = clanovi_projekta.projekt_ID WHERE projekt.naziv = '" + PopisZadatakaImeProjektaLabel.Text + "';");


            foreach (List<string> clan in clanovi)
            {
                PopisZadatakaClanoviListBox.Items.Add(clan[0]);
                if ((string)clan[1] == "True")
                {
                    PopisZadatakaAdminiListBox.Items.Add(clan[0]);
                }
            }
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

            //Kreira instancu servera i zapoćinje slušanje na predodređenom portu
            server = new udpServer();
            Task.Run(() => server.ZapocniServerAsinkrono());
        }

        private void PopisZadatakaImeProjektaLabel_Click(object sender, EventArgs e)
        {

        }

        private async void PopisZadatakaSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Gleda da li je upisan tekst u search area
                if (string.IsNullOrEmpty(PopisZadatakaSearchRichTextBox.Text))
                {
                    server.ZaustaviServer();
                    server.Dispose();
                    StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
                    return;
                }

                //Uspostavlja novi UDP klijent te šalje i stvara zahtjev
                using (var client = new UdpClient())
                {
                    var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                    client.Connect(serverEndPoint);

                    var zahtjev = Encoding.UTF8.GetBytes(PopisZadatakaSearchRichTextBox.Text);
                    await client.SendAsync(zahtjev, zahtjev.Length);

                    var receiveResult = await client.ReceiveAsync();
                    var responseData = receiveResult.Buffer;

                    var polje = ListToBytes.pretvoriByteToList(responseData);
                    if (polje != null && polje.Count > 0)
                    {
                        await PopisZadatakaOsvježiFlowLayout(polje);
                    }
                    else
                    {
                        MessageBox.Show("Nema rezultat ili je došlo do pogreške");
                    }
                }
            }
            catch (Exception ex)
            {
                //Baca error ako nema rezultata u bazi ili na listi
                MessageBox.Show($"Problem pri povezivanju UDP klijenta sa UDP serverom zadatak s tim nazivom ne postoji: {ex.Message}");
            }
        }

        //Postavlja novi sadržaj u Flow layout palen
        private async Task PopisZadatakaOsvježiFlowLayout(List<List<string>> polje)
        {
            //Izvršava zadatak koji je postavljen na Threadpool 
            await Task.Run(() =>
            {

                this.Invoke((MethodInvoker)delegate
                {
                    var receivedProjectIds = new HashSet<string>(polje.Select(row => row[1]));
                    var controlsToRemove = new List<Control>();

                    foreach (Control control in PopisZadatakaZadatciFlowLayoutPanel.Controls)
                    {
                        if (control is PopisZadatkaControl pzc && !receivedProjectIds.Contains(pzc.Naslov))
                        {
                            controlsToRemove.Add(control);
                        }
                    }

                    foreach (var control in controlsToRemove)
                    {
                        PopisZadatakaZadatciFlowLayoutPanel.Controls.Remove(control);
                        control.Dispose();
                    }

                    PopisZadatakaZadatciFlowLayoutPanel.Refresh();
                });
            });
        }
        
    }
}
