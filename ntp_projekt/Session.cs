using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public static class Session
    {
        
        static Baza baza = new Baza(@"..\..\TeamPlan.mdb");

        public static void PostaviPodatke(string _username, Baza baza)
        {
            string query = $"SELECT ime,prezime,korisnicko_ime,lozinka FROM korisnik WHERE korisnicko_ime = \"{_username}\";";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            using (OleDbConnection connection = new OleDbConnection(baza.ConnectionString))
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
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    key.SetValue("Varijabla " + i, reader[i].ToString());
                                }
                                key.Close();
                            }
                            else
                            {
                                key.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    key.Close();
                    MessageBox.Show("Greška pri stvaranju sesije: " + ex.Message);
                }
            }
        } 

        public static string DohvatiKorisnika() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            try 
            {
                string User = key.GetValue("Varijabla 2").ToString();
                key.Close();
                return User;

            } catch (Exception ex)
            {
                key.Close();
                MessageBox.Show("Greška pri dohvatu korisnika: " + ex.Message);
                return null;
            }
        }

        public static string DohvatiPunoIme() {
            try {
                string User = Session.DohvatiKorisnika();
                string ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{User}\";");
                string prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{User}\";");
                return ime + " " + prezime;
            } catch (Exception ex) 
            {

                MessageBox.Show("Greška pri dohvatu punog imena: " + ex.Message);
                return null;
            }
        }

        public static Image DohvatiProfilnuSliku() {
            try
            {
                string User = Session.DohvatiKorisnika();
                Image profilna = baza.BazaGetImage($"SELECT profilna FROM korisnik WHERE korisnicko_ime = \"{User}\";");
                return profilna;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dohvatu profilne slike: " + ex.Message);
                return Image.FromFile(@"..\..\Images\profilna.jpg");
            }
        }

        public static void CleanSession() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            if (key != null) {
                string[] namesArray = key.GetValueNames();
                foreach (string name in namesArray)
                {
                    key.DeleteValue(name, true);
                }
            }
            key.Close();
        }

        public static void DeaktivirajRacun() {
            try
            {
                string User = Session.DohvatiKorisnika();
                baza.BazaDelete($"DELETE FROM korisnik WHERE korisnicko_ime = '{User}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri deaktivaciji računa za trenutnu sesiju: " + ex.Message);
            }
        }
    }
}
