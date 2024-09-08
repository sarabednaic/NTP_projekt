using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DinamicLibrary;


namespace UDPServer
{
    public class udpServer : IDisposable
    {
        private const int PORT = 11000;
        private UdpClient server;
        public static bool aktivan = false;
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source= ..\..\TeamPlan.mdb;";

        public udpServer()
        {
            server = new UdpClient(PORT);
        }

        //Započinje UDP server i čeka zahtjeve na zadanom portu
        public async Task ZapocniServerAsinkrono()
        {
            aktivan = true;
            while (aktivan)
            {
                try
                {
                    var tok = await server.ReceiveAsync();
                    var zahtjev = Encoding.UTF8.GetString(tok.Buffer);
                    var rezultati = await IzvrsiQueryAsinkrono(zahtjev);

                    byte[] odgovor;
                    if (rezultati.Count > 0)
                    {
                        odgovor = ListToBytes.pretvoriListToByte(rezultati);
                    }
                    else
                    {
                        odgovor = Encoding.UTF8.GetBytes("Nema toka zahtjeva");
                    }

                    await server.SendAsync(odgovor, odgovor.Length, tok.RemoteEndPoint);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Greška pri dohvaćanju zahtjeva u UDP serveru: {ex.Message}");
                }
            }
        }

        //Metoda vraća rezultat pretrage baze ovisno o zahtjevu koji je poslan
        private async Task<List<List<string>>> IzvrsiQueryAsinkrono(string zahtjev)
        {
            var query = "SELECT zadatak.ID, zadatak.naziv, zadatak.opis, zadatak.vrijeme_pocetak, zadatak.vrijeme_kraj FROM zadatak WHERE zadatak.naziv = @zahtjev";
            var results = new List<List<string>>();

            using (var connection = new OleDbConnection(connectionString))
            {
                await connection.OpenAsync();
                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@zahtjev", zahtjev);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader[i].ToString());
                            }
                            results.Add(row);
                        }
                    }
                }
            }

            return results;
        }

        //Mijenja bool aktivnosti
        public void ZaustaviServer()
        {
            aktivan = false;
        }

        //Zatvara UDP vezu servera i oslobađa resurse koji su bili korišteni od servera
        public void Dispose()
        {
            server?.Close();
            server?.Dispose();
        }
    }
}