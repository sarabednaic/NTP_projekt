using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public static class SessionProjekt
    {
        public static void postaviTrenutniProjekt(string id, string naslov, string opis) {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniProjekt");
            key.SetValue("ID", id);
            key.SetValue("Naslov", naslov);
            key.SetValue("Opis", opis);
            key.Close();
        }

        public static Projekt dohvatiTrenutniProjekt() {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniProjekt");
            Projekt izlaz = new Projekt(key.GetValue("ID").ToString(), key.GetValue("Naslov").ToString(), key.GetValue("Opis").ToString());
            return izlaz;
        }

        public static void CleanSession()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniProjekt");
            if (key != null)
            {
                string[] namesArray = key.GetValueNames();
                foreach (string name in namesArray)
                {
                    key.DeleteValue(name, true);
                }
            }
            key.Close();
        }


    }
}
