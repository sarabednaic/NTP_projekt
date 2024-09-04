using SuperSimpleTcp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    public class tcpServer
    {
        SimpleTcpServer server;
        static string message = "";
        public static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source= ..\..\TeamPlan.mdb;";
        public tcpServer() 
        {
            server = new SimpleTcpServer("127.0.0.1:13001");
            server.Start();
            server.Events.DataReceived += Events_DataReceived;
            
        }

        
        //Odgovoran na zahtjev
        private void Events_DataReceived(object sender, DataReceivedEventArgs poljeBitova)
        {
            //Dojvaca tok bajtova i pretvara ih u string
            byte[] zahtjev = poljeBitova.Data.ToArray();
            message = Encoding.UTF8.GetString(zahtjev);
            byte[] odgovor;

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
                    }
                    else 
                    {
                        odgovor = null;
                    }
                    
                }
            }
            //Šalje odgovor klijentu na zahtjev gdje poljeBitova.IpPort predstavlja drugaciji port nego port koji smo postavili za server
            server.Send(poljeBitova.IpPort , odgovor);
        }

        


        public SimpleTcpServer Server { 
            get 
            {
                return server;
            } 
        }

        
    }
}
