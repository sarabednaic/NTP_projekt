using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class HTTPDownload : Form
    {
        int brzinaUKBps;
        long preuzetiBitovi = 0;
        DateTime azuriranoVrijemePreuzimanja = DateTime.UtcNow;
        readonly string url = "https://i.ibb.co/L9yX8YK/TeamPlan.png";
        HttpDownloader preuzimatelj;
        bool trenutnoPreuzima = false;
        public HTTPDownload()
        {
            InitializeComponent();
        }

        

        private void PreuzimanjeZapočniButton_Click(object sender, EventArgs e)
        {
            if (!trenutnoPreuzima) 
            {
                trenutnoPreuzima = true;
                string putanja = $"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")}\\{Path.GetFileName(url)}";

                if (File.Exists(putanja)) {
                    File.Delete(putanja);
                }
                preuzimatelj = new HttpDownloader(url, putanja);
                preuzimatelj.DownloadCompleted += Preuzimatelj_DownloadCompleted;
                preuzimatelj.ProgressChanged += Preuzimatelj_ProgressChanged;

                if (PreuzimanjeBrzinaRadioButton1.Checked)
                {
                    brzinaUKBps = 200;
                    PreuzimanjeProgressBar.MarqueeAnimationSpeed = 10000;
                }
                else if (PreuzimanjeBrzinaRadioButton2.Checked)
                {
                    brzinaUKBps = 100;
                    PreuzimanjeProgressBar.MarqueeAnimationSpeed = 5000;
                }
                else if (PreuzimanjeBrzinaRadioButton3.Checked)
                {
                    brzinaUKBps = 50;
                    PreuzimanjeProgressBar.MarqueeAnimationSpeed = 2500;
                }

                preuzimatelj.Start();
            }

    
        }

        private void Preuzimatelj_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            azurirajBrzinuPreuzimanja(e.TotalBytesReceived);    
            PreuzimanjeProgressBar.Value = (int)e.Progress;
            PreuzimanjePostotakLabel.Text = $"{e.Progress.ToString("0.00")}%";
            Speed.Text = string.Format("{0} KB/s", (e.SpeedInBytes).ToString("0.000"));
        }

        private void azurirajBrzinuPreuzimanja(long bajtovi) 
        {
            preuzetiBitovi += bajtovi;
            DateTime trenutnoVrijeme = DateTime.UtcNow;
            double protekleSekunde = (trenutnoVrijeme - azuriranoVrijemePreuzimanja).TotalSeconds;

            if (protekleSekunde >= 1) 
            {
                double brzinaPreuzimanja = (preuzetiBitovi / 1024.0) / protekleSekunde;

                if (brzinaPreuzimanja > brzinaUKBps)
                {
                    int delay = (int)((preuzetiBitovi / (brzinaUKBps * 1024.0)) * 1000);

                    for (int i = 0; i < (delay); i++) {
                        PreuzimanjeProgressBar.Refresh();
                    }
                    
                }

                preuzetiBitovi = 0;
                azuriranoVrijemePreuzimanja = trenutnoVrijeme;
            }

            
        }

        private void Preuzimatelj_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate 
            {
                PreuzimanjePostotakLabel.Text = "100%";
                MessageBox.Show("Sadržaj uspiješno preuzet.");
                trenutnoPreuzima = false;
                Close();
            });
        }

        private void PreuzimanjeZaustaviButton_Click(object sender, EventArgs e)
        {
            if (preuzimatelj != null)
            {
                preuzimatelj.Pause();
            }
        }

        private void PreuzimanjeNastavibutton_Click(object sender, EventArgs e)
        {
            if (preuzimatelj != null)
            {
                preuzimatelj.Resume();
            }

        }

        private void PreuzimanjeBrzinaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void PreuzimanjeBrzinaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PreuzimanjeBrzinaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void HTTPDownload_Load(object sender, EventArgs e)
        {

        }
    }
}
