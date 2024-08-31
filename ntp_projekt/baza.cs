using System;
using System.Collections.Generic;
using System.Data;
//API za pristup podacima u bazi
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

        public Image DefaultProfilna = Image.FromFile(@"..\..\Images\profilna.jpg");

        public Baza(string path)
        {
           connectionString = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={path};";
        }

        //čitanje jednog podatka iz baze
        public string BazaRead(string upit)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string izlaz = reader[0].ToString();
                                if (connection != null)
                                {
                                    connection.Close();
                                }
                                return izlaz;
                            }
                            else
                            {
                                if (connection != null)
                                {
                                    connection.Close();
                                }
                                return "Nema rezultata.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        //čitanje podataka (lista sa elementima koji su liste)
        public List<List<string>> NaprednaBazaRead(string upit)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }
                            
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
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        //čitanje podataka (lista)
        public List<string> ListaBazaRead(string upit)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
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
                    return new List<string>(); 
                }
            }
        }

        //traži u bazi prema parametru("naziv_stupca", vrijednost)
        public List<string> ListaBazaReadParametar(string upit, params OleDbParameter[] parameters)
        {
            List<string> results = new List<string>();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    results.Add(reader[i].ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                }
            }
            return results;
        }

        //upis u bazu
        public int BazaWrite(string upit)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected;
                    }
                }
                catch (Exception ex)
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                    MessageBox.Show("Greška pri upisu u bazu: " + ex.Message);
                    return -1; 
                }
            }

        }

        //upisuje u bazu prema parametru(upit, "naziv_stupca", vrijednost) tj. pod koji stupac što
        public int BazaWriteParametar(string upit, params OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        command.ExecuteNonQuery();

                        //posljednji ID
                        command.CommandText = "SELECT @@Identity";
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri upisu u bazu: " + ex.Message);
                    return -1;
                }
            }
        }

        //obično čitanje iz baze sa parametrom
        public object BazaReadParametar(string upit, params OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        return command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri čitanju iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        //upis postavljene profilne u bazu
        public void BazaSetImage(string upit, string fileName) {
            try
            {
                byte[] imageData = File.ReadAllBytes(fileName);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(upit, connection))
                {
                    command.Parameters.Add("profilna", OleDbType.LongVarBinary).Value = imageData;

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Fotografija uspješno postavljena!");
                    }
                    else
                    {
                        MessageBox.Show("Greška pri postavljanju fotografije.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}");
            }



        }

        //vraćanje profilne iz baze
        public Image BazaGetImage(string upit)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand(upit, connection);


                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "korisnik");
                    int count = dataSet.Tables["korisnik"].Rows.Count;

                    if (count > 0)
                    {
                        byte[] rawData = (byte[])dataSet.Tables["korisnik"].Rows[count - 1]["profilna"];
                        if (rawData == null || rawData.Length == 0)
                        { 
                            return DefaultProfilna;
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
                            return DefaultProfilna;
                        }

                    }
                    else
                    {
                        return DefaultProfilna;
                    }


                }
                catch (Exception ex)
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                    MessageBox.Show("Greška pri dohvatu prifilne fotografije iz baze: " + ex.Message);
                    return DefaultProfilna;
                }
            }
        }

        //brisanje iz baze prema upitu i parametrina
        public int BazaDelete(string upit, params OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(upit, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Uspješno obrisano.");
                        }
                        return 0;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju iz baze: {ex.Message}");
                    return -1;
                }
            }
        }

        public string ConnectionString { get { return connectionString; } }

    }
}
