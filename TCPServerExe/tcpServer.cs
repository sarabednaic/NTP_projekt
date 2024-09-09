using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinamicLibrary;
using System.Diagnostics;

namespace TCPServerExe
{
    public partial class tcpServer : Form
    {
        public static SimpleTcpServer server;
        static string message = "";
        public static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source= ..\..\TeamPlan.mdb;";
        bool imaOdgovora = false;
        public tcpServer()
        {
            InitializeComponent();
        }

        private void tcpServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer("127.0.0.1:13001");
            server.Start();
            server.Events.DataReceived += Events_DataReceived;
            Status1.Text = "Connected: " + server.IsConnected(server.Port.ToString()).ToString();
            Status2.Text = "Listening: " + server.IsListening.ToString();
            Status3.Text = "Port: " + server.Port.ToString();
            Status4.Text = "Server IP adress: " + server.IpAddress.ToString();
            ZahtjevLabel.Text = "Request: ???";
            IsListeningOdgovor.Text = "Has responded: False";
        }

        //Odgovoran na zahtjev
        private void Events_DataReceived(object sender, SuperSimpleTcp.DataReceivedEventArgs poljeBitova)
        {
            Status1.Text = "Connected: " + server.IsConnected(poljeBitova.IpPort.ToString()).ToString();
            //Dojvaca tok bajtova i pretvara ih u string
            byte[] zahtjev = poljeBitova.Data.ToArray();
            message = Encoding.UTF8.GetString(zahtjev);
            byte[] odgovor;


            ZahtjevLabel.Text = "Request: " + message;
            //string message uzima kao uvijek za query kojim pretrazuje bazu i vraća odgovor na query
            string query = $"SELECT projekt.ID , projekt.naziv, projekt.opis FROM projekt WHERE projekt.naziv = \"{message}\"";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<List<string>> results = new List<List<string>>();
                        while (reader.Read())
                        {
                            List<string> row = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader[i].ToString());
                            }
                            results.Add(row);
                        }
                        odgovor = ListToBytes.pretvoriListToByte(results).ToArray();
                        imaOdgovora = true;
                    }
                    else
                    {
                        odgovor = null;
                    }

                }
            }
            //Šalje odgovor klijentu na zahtjev gdje poljeBitova.IpPort predstavlja drugaciji port nego port koji smo postavili za server
            if (imaOdgovora) IsListeningOdgovor.Text = "Has responded: True";
            server.Send(poljeBitova.IpPort, odgovor);//server je na jednom portu, a kijent na drugom pa on zapravo salje na temelju zahtjeva koji je dobil na klijentov port
        }

        public static void Zatvori()
        {
            server.Dispose();
            server.Stop();
        }
    }
}