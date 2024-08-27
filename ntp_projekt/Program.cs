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

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Unique identifier for your application to prevent multiple instances
            const string mutexProjekt = "ntp_projekt_Mutex";

            // Create a new Mutex, and check if another instance is already running
            bool novaApp;

            mutex = new Mutex(true, mutexProjekt, out novaApp);

            if (!novaApp)
            {
                // If another instance is running, show a message and exit
                MessageBox.Show("Aplikacija je već pokrenuta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new StartApk();

            // Release the mutex when the application closes
            GC.KeepAlive(mutex);
        }
    }
}
