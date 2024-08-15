﻿using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ntp_projekt
{
    public class Baza
    {
        public string connectionString;

        public Baza(string pathToDatabase)
        {
           connectionString = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={pathToDatabase};";
        }

        public string BazaRead(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader[0].ToString(); 
                            }
                            else
                            {
                                return "Nema rezultata.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                    return null;
                }
            }
        }

        public string ConnectionString { get { return connectionString; } }

        public int BazaWrite(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery(); 
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                    return -1; 
                }
            }
        }

        public Image BazaGetImage(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Image.FromFile(@"..\..\Images\profilna.jpg");
                            }
                            else
                            {
                                return Image.FromFile(@"..\..\Images\profilna.jpg");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
