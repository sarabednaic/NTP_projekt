using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public class StartApk
    {
        private static MainFormManager mainFormManager;
        public static MainFormManager MainFormManager 
        {
            get { return mainFormManager; }
        }

        public StartApk() {
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
