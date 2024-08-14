using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    internal class baza
    {
        public baza() {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=""C:\Users\sbednaic\Desktop\TeamPlan.mdb""";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška: " + ex.Message);
                }
            }

        }
    }
}
