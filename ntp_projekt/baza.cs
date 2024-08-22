using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ntp_projekt
{
    public class Baza
    {
        public string connectionString;
        public Image DefaultProfilPicture = Image.FromFile(@"..\..\Images\profilna.jpg");

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
                                string izlaz = reader[0].ToString();
                                connection?.Close();
                                return  izlaz;
                            }
                            else
                            {
                                connection?.Close();
                                return "Nema rezultata.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    connection?.Close();
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        public List<List<string>> NaprednaBazaRead(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            return null;

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
                        return results;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri naprednom čitanju iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        public List<string> ListaBazaRead(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        List<string> results = new List<string>();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                results.Add(reader[i].ToString());
                            }
                        }
                        return results;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                    return new List<string>(); // Vratiti praznu listu u slučaju greške
                }
            }
        }




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
                        connection?.Close();
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    connection?.Close();
                    MessageBox.Show("Greška pri upisu u bazu: " + ex.Message);
                    return -1; 
                }
            }

        }

        

        public void BazaSetImage(string query, string curFileName) {
            try
            {
                byte[] imageData = File.ReadAllBytes(curFileName);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.Add("profilna", OleDbType.LongVarBinary).Value = imageData;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Image inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert image.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }

        public Image BazaGetImage(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    OleDbCommand command = new OleDbCommand(query, connection);



                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "korisnik");
                    int count = dataSet.Tables["korisnik"].Rows.Count;

                    if (count > 0)
                    {
                        byte[] rawData = (byte[])dataSet.Tables["korisnik"].Rows[count - 1]["profilna"];
                        if (rawData == null || rawData.Length == 0)
                        { 
                            return DefaultProfilPicture;
                        }

                        try
                        {
                            using (MemoryStream rawDataStream = new MemoryStream(rawData))
                            {
                                Image profilna = Image.FromStream(rawDataStream);
                                return profilna;
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show("Invalid image data: " + ex.Message);
                            return DefaultProfilPicture;
                        }

                    }
                    else
                    {
                        return DefaultProfilPicture;
                    }


                }
                catch (Exception ex)
                {
                    connection?.Close();
                    MessageBox.Show("Greška pri dohvatu OLE objekta iz baze: " + ex.Message);
                    return DefaultProfilPicture;
                }
            }
        }

        public void BazaDelete(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Uspješna deaktivacija računa.");
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri deaktivaciji računa: {ex.Message}");
                }
            }
        }

        public string ConnectionString { get { return connectionString; } }

    }
}
