using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ntp_projekt
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            //mutex
            const string mutexProjekt = "ntp_projekt_Mutex";
            bool novaApp;

            //omogućuje samo jednoj dretvi(threadu) da pristupi kodu
            //true -> daje ownership prvo pokrenutoj aplikaciji jer vidi pa postoji ime 
            mutex = new Mutex(true, mutexProjekt, out novaApp);

            if (!novaApp)
            {
                MessageBox.Show("Aplikacija je već pokrenuta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new StartApk();

            //briše mutex kada se aplikacija ugasi
            GC.KeepAlive(mutex);
        }
    }
}
