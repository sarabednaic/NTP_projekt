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
using DinamicLibrary;
using dinamicLib;
using System.Net.Http;
using SuperSimpleTcp;
using TCPServerExe;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace ntp_projekt
{
    public partial class PopisProjekta : Form
    {
        Ini iniFile;
        Baza baza;
        XmlOperator XmlOperator = new XmlOperator();
        //static public tcpServer server;
        public static Process server;
        SimpleTcpClient client;
        string PutanjaXMLProjekt = @"..\..\..\DinamicLibrary\XMLPopisProjekta.xml";
        string nodes = "/projekti/projekt";

        string adminXMLputanja = @"c:\admini.xml";
        string adminNodes = "/Admini/Admin";




        public PopisProjekta()
        {

            InitializeComponent();
            PopisProjektaProjektiFlowLayoutPanel.Controls.Clear();
            PopisProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            PopisProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");
            
            
            //pretraga projekata po nazivu preko servera
            client = new SimpleTcpClient("127.0.0.1:13001");
            
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;

            baza = new Baza(@"C:\xampp\htdocs\TeamPlan\TeamPlan.mdb");
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
                    PopisProjektaControl.Status = XmlOperator.XmlRead(row[1].ToString(), PutanjaXMLProjekt, nodes);
                    PopisProjektaControl.setBoja(PopisProjektaControl.Status);
                    PopisProjektaControl.Admin = Convert.ToBoolean(row[4].ToString());
                    PopisProjektaControl.Check();
                    PopisProjektaProjektiFlowLayoutPanel.Controls.Add(PopisProjektaControl);

                }
            }
            
            List<List<string>> tablica = baza.NaprednaBazaRead($"SELECT korisnik.ID , korisnik.ime , korisnik.prezime , korisnik.korisnicko_ime , korisnik.lozinka, korisnik.sol, projekt_ID FROM " +
                    $"korisnik inner join clanovi_projekta on korisnik.ID = clanovi_projekta.korisnik_ID WHERE clanovi_projekta.admin = True;");

            if (tablica != null)
            {
                foreach (List<string> row in tablica)
                {
                    XmlOperator.XmlAdminAdd(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), adminXMLputanja, adminNodes);
                }
            }


            /*Dictionary<int, string[]> Mapa = new Dictionary<int, string[]>();
            string[] projekti = null;
            int count = 1;
            int i = 0;
            if (tablica != null )
            {
                do
                {
                    foreach (List<string> redak in tablica)
                    {
                        if (count.ToString() == redak[0].ToString())
                        {
                            projekti.Append(redak[4].ToString());
                        }
                        
                    }
                    
                    Mapa.Add(count, projekti);
                    count++;
                    projekti = null;
                }while ();
                
            }
            count = 0;*/

        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            //MessageBox.Show("Klijent nije povezan.");
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            //MessageBox.Show("Klijent povezan.");
        }

        private void UrediZadatakNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PopisProjektaProfilPictureBox_Click_1(object sender, EventArgs e)
        {
            
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaProfilLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PopisProjektaAddButton_Click_1(object sender, EventArgs e)
        {
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
            server = Process.Start(@"..\..\..\TCPServerExe\bin\Debug\TCPServerExe.exe");
            client.Connect();
            //Provjerava da li je server aktivan i da li je klijent povezan
            if (client.IsConnected)
            {
                server.Refresh();
                //ako text box za pretraživanje nije prazan onda šalje string u text boxu
                if (PopisProjektaSearchRichTextBox.Text != "")
                {
                    client.Send(PopisProjektaSearchRichTextBox.Text);
                }
                else
                {
                    //Zaustavlja server i odspaja klijenta

                    server.Kill();
                    client.Disconnect();
                    StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                }
            }

        }

        //Odgovora na paket koji je klijent primo od servera
        private void Events_DataReceived(object sender, SuperSimpleTcp.DataReceivedEventArgs e)
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

                    //server.Kill();
                    //client.Disconnect();
                });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            Form forma = new HTTPDownload();
            forma.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string appPath = @"..\..\..\API\API\bin\Debug\net8.0\API.exe";

                using (Process procesB = new Process())
                {
                    procesB.StartInfo.FileName = appPath;
                    procesB.Start();

                    procesB.WaitForExit();

                    int exitCode = procesB.ExitCode;

                    if (exitCode == 0)
                    {
                        MessageBox.Show("Datoteka povijesti aktivnosti je preuzeta.");
                    }
                    else if (exitCode == 1)
                    {
                        {
                            MessageBox.Show($"Proces je završio s greškom.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}");
            }
        }
    }
}