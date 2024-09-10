using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinamicLibrary;

namespace ntp_projekt
{
    public static class Session
    {
        static Baza baza = new Baza(@"..\..\TeamPlan.mdb");

        public static void PostaviPodatke(string _username, Baza baza)
        {
            string upit = $"SELECT ID,ime,prezime,korisnicko_ime,lozinka FROM korisnik WHERE korisnicko_ime = \"{_username}\";";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            using (OleDbConnection connection = new OleDbConnection(baza.ConnectionString))
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
                string User = key.GetValue("Varijabla 3").ToString();
                key.Close();
                return User;

            } catch (Exception ex)
            {
                key.Close();
                MessageBox.Show("Greška pri dohvaćanju korisnika: " + ex.Message);
                return null;
            }
        }

        public static string DohvatiKorisnikID() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            try
            {
                string User = key.GetValue("Varijabla 0").ToString();
                key.Close();
                return User;

            }
            catch (Exception ex)
            {
                key.Close();
                MessageBox.Show("Greška pri dohvaćanju korisnika: " + ex.Message);
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

                MessageBox.Show("Greška pri dohvaćanju imena korisnika: " + ex.Message);
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
                MessageBox.Show("Greška pri dohvaćanju profilne slike: " + ex.Message);
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
                int korisnikID = Int32.Parse(Session.DohvatiKorisnikID());

                string[] upiti = new string[]
                {
                        "DELETE FROM clanovi_zadatka WHERE clanovi_zadatka.clan_projekta_ID IN (SELECT clanovi_projekta.ID  FROM clanovi_projekta WHERE clanovi_projekta.korisnik_ID = ?);",
                        "DELETE FROM clanovi_projekta WHERE clanovi_projekta.korisnik_ID = ?;",
                        "DELETE FROM korisnik WHERE korisnik.ID = ?"

                };

                foreach (string upit in upiti)
                {
                    int result = baza.BazaDelete(upit, new OleDbParameter("?", korisnikID));
                    if (result == -1)
                    {
                        MessageBox.Show("Greška pri deaktivaciji računa." );
                        break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri deaktivaciji računa za trenutnu sesiju: " + ex.Message);
            }
        }
    }
}
