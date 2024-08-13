﻿using System;
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
        protected bool Exitapk;

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
                    Exitapk = false;
                    MainForm.Close();
                    Exitapk = true;
                }
                MainForm = value;
                MainForm.Show();
            }
        }
        protected override void OnMainFormClosed(Object sender, EventArgs e)
        {
            if (Exitapk) 
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
