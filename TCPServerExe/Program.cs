using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServerExe
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static Mutex mut;

        [STAThread]

        static void Main()
        {
            bool test;
            mut = new Mutex(true, "tcpserver", out test);

            if (!test)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new tcpServer());

            Application.ApplicationExit += Application_ApplicationExit;
            GC.KeepAlive(mut);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            tcpServer.Zatvori();
        }




    }
}
