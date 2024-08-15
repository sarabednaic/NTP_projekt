﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public static class Session
    {
        
        public static void PostaviPodatke(string _username, Baza baza) {
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
                                for (int i = 0; i < reader.FieldCount;i++) {
                                    key.SetValue("Varijabla " + i, reader[i].ToString());
                                }
                                key.Close();
                            }
                            else {
                                key.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
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
                MessageBox.Show("Greška: " + ex.Message);
                return null;
            }
        }

        public static void CleanSession() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            if (key != null) {
                var namesArray = key.GetValueNames();
                foreach (var name in namesArray)
                {
                    key.DeleteValue(name, true);
                }
            }
        }
    }
}
