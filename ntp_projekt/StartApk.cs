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
            mainFormManager = new MainFormManager
            {
                TrenutnaForma = new Prijava()
            };
            
            Application.Run(mainFormManager);
        }
    }
}
