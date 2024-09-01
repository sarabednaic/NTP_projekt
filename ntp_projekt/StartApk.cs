using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public class StartApk
    {
        //služi za incijalizaciju glavne forme koja se prva treba prikazati i skriva i pokazuje druge potrebne forme
        private static MainFormManager mainFormManager;

        public static MainFormManager MainFormManager 
        {
            get { return mainFormManager; }
        }

        //ucitavanje glavnih postavki aplikacije
        public StartApk() {
            Ini iniFile;
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");

            string jezik = iniFile.DohvatiVrijednost("Postavke", "Jezik", "hrvatski");
            string font = iniFile.DohvatiVrijednost("Postavke", "Font", "M");

            if (jezik == "english")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            else if (jezik == "hrvatski")
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");
            }

            //kod prijavljenog korisnika automatski se otvori Popis projekata
            //ako ne postoji prijavljeni korisnik tada nas prebacuje na Prijavu
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\NTP_Projekt\TrenutniKorisnik");
            if (key != null && key.GetValueNames().Length != 0)
            {
                mainFormManager = new MainFormManager { TrenutnaForma = new PopisProjekta() };
            }
            else 
            {
                mainFormManager = new MainFormManager { TrenutnaForma = new Prijava() };
            }
            Application.Run(mainFormManager);
        }
    }
}
