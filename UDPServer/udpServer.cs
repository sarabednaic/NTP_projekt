using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCPServer;

namespace UDPServer
{
    public class udpServer : IDisposable
    {
        private const int PORT = 11000;
        private UdpClient server;
        private bool isListening = false;
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source= ..\..\TeamPlan.mdb;";

        public udpServer()
        {
            server = new UdpClient(PORT);
        }

        public async Task StartListeningAsync()
        {
            isListening = true;
            while (isListening)
            {
                try
                {
                    var result = await server.ReceiveAsync();
                    var zahtjev = Encoding.UTF8.GetString(result.Buffer);
                    var results = await ExecuteQueryAsync(zahtjev);

                    byte[] odgovor;
                    if (results.Count > 0)
                    {
                        odgovor = ListToBytes.ConvertListToByte(results);
                    }
                    else
                    {
                        odgovor = Encoding.UTF8.GetBytes("No results found");
                    }

                    await server.SendAsync(odgovor, odgovor.Length, result.RemoteEndPoint);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in UDP server: {ex.Message}");
                }
            }
        }

        private async Task<List<List<string>>> ExecuteQueryAsync(string zahtjev)
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

        public void StopListening()
        {
            isListening = false;
        }

        public void Dispose()
        {
            server?.Close();
            server?.Dispose();
        }
    }
}