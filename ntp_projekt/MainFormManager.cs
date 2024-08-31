using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public class MainFormManager : ApplicationContext 
    {
        protected bool ExitApk;

        //zatvaranje forme pa zatim aplikacije
        public Form TrenutnaForma 
        {
            get 
            {
                return MainForm;
            }

            set 
            {
                if (MainForm != null)
                {
                    ExitApk = false;
                    MainForm.Close();
                    ExitApk = true;
                }
                MainForm = value;
                MainForm.Show();
            }
        }

        public MainFormManager()
        {
            ExitApk = true;
        }

        protected override void OnMainFormClosed(Object sender, EventArgs e)
        {
            if (ExitApk==true) 
            {
                SessionProjekt.CleanSession();
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
