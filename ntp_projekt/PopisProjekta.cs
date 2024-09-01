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
using System.Net.Http;
using SuperSimpleTcp;
using TCPServer;
using System.Runtime.CompilerServices;

namespace ntp_projekt
{
    public partial class PopisProjekta : Form
    {
        Ini iniFile;
        Baza baza;
        XmlOperator XmlOperator = new XmlOperator();
        static public tcpServer server;
        SimpleTcpClient client;

        public PopisProjekta()
        {

            InitializeComponent();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Clear();
            PopisProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");
            server = new tcpServer();
            
            client = new SimpleTcpClient("127.0.0.1:13001");
            client.Connect();
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;

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
                    PopisProjektaControl.Id = row[1].ToString();
                    PopisProjektaControl.Naslov = row[2].ToString();
                    PopisProjektaControl.Opis = row[3].ToString();
                    PopisProjektaControl.Status = XmlOperator.XmlRead(row[1].ToString());
                    PopisProjektaControl.setBoja(PopisProjektaControl.Status);
                    PopisProjektaControl.Admin = Convert.ToBoolean(row[4].ToString());
                    PopisProjektaControl.Check();
                    PopisProjektaProjektiFlowLayoutPanel.Controls.Add(PopisProjektaControl);

                }
            }

            
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            MessageBox.Show("Client disconnected");
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            MessageBox.Show("Client connected");
        }

        private void UrediZadatakNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopisProjektaProfilPictureBox_Click_1(object sender, EventArgs e)
        {
            server.Server.Stop();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Clear();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaProfilLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            server.Server.Stop();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Clear();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaAddButton_Click_1(object sender, EventArgs e)
        {
            server.Server.Stop();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Clear();
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

        private void PopisProjektaSearchButton_Click(object sender, EventArgs e)
        {
            //Provjerava da li je server aktivan i da li je klijent povezan
            if (server.Server.IsListening && client.IsConnected)
            {
                //ako text box za pretraživanje nije prazan onda šalje string u text boxu
                if (PopisProjektaSearchRichTextBox.Text != "")
                {
                    client.Send(PopisProjektaSearchRichTextBox.Text);
                }
                else 
                {
                    //Zaustavlja server i odspaja klijenta
                    server.Server.Stop();
                    client.Disconnect();
                    StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                }
            }
            
        }

        //Odgovora na paket koji je klijent primo od servera
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            byte[] dataArray = e.Data.ToArray();
            List<List<string>> polje = ListToBytes.pretvoriByteToList(dataArray);

            if (polje != null)
            {
                // Koristimo Invoke kako bi osigurali da UI ažuriranje se dogodi na UI threadu
                this.Invoke((MethodInvoker)delegate
                {
                    // Kreira HashSet IDa projekata od primljenog paketa za brži pregled
                    HashSet<string> receivedProjectIds = new HashSet<string>(polje.Select(row => row[0]));

                    // Kreira listu Controla koje trebamo maknuti iz Flow Layout panela
                    List<Control> controlsToRemove = new List<Control>();

                    // Pronalazi kontrole koje treba maknuti
                    foreach (Control control in PopisProjektaProjektiFlowLayoutPanel.Controls)
                    {
                        if (control is PopisProjektaControl ppc)
                        {
                            if (!receivedProjectIds.Contains(ppc.Id))
                            {
                                controlsToRemove.Add(control);
                            }
                        }
                    }

                    // Uklanja kontrole koje treba maknuti
                    foreach (Control control in controlsToRemove)
                    {
                        PopisProjektaProjektiFlowLayoutPanel.Controls.Remove(control);
                        control.Dispose(); // Oslobađa resurse
                    }

                    // Osvježava prikaz Flow Layout Panela
                    PopisProjektaProjektiFlowLayoutPanel.Refresh();
                });
            }
        }   
    }
}