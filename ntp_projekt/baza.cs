using System;
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

        public Image BazaGetImage(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    //using (OleDbCommand command = new OleDbCommand(query, connection))
                    //{
                    //    using (OleDbDataReader reader = command.ExecuteReader())
                    //    {
                    //        if (reader.Read())
                    //        {
                    //            connection?.Close();
                    //            return Image.FromFile(@"..\..\Images\profilna.jpg");
                    //        }
                    //        else
                    //        {
                    //            connection?.Close();
                    //            return Image.FromFile(@"..\..\Images\profilna.jpg");
                    //        }
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    connection?.Close();
                    MessageBox.Show("Greška pri dohvatu OLE objekta iz baze: " + ex.Message);
                    return null;
                }
            }
        }

        
    }
}
