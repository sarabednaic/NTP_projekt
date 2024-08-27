using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ntp_projekt
{
    public partial class Postavke : Form
    {
        Baza baza;
        Ini iniFile;
        
        string user = Session.DohvatiKorisnika();

        public Postavke()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");

            
            string ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            PostavkeProfilnaPictureBox.Image = Session.DohvatiProfilnuSliku();

            PostavkeImeTextBox.Text = ime;
            PostavkePrezimeTextBox.Text = prezime;
            PostavkeKorisnickoImeTextBox.Text = user;
            PostavkeJezikComboBox.Items.Add("hrvatski");
            PostavkeJezikComboBox.Items.Add("english");
            PostavkeVelicinaFontaComboBox.Items.Add("S");
            PostavkeVelicinaFontaComboBox.Items.Add("M");
            PostavkeVelicinaFontaComboBox.Items.Add("L");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeOdjavaButton_Click(object sender, EventArgs e)
        {
            string binarnaDatoteka = @"..\..\prilagodena.dat";
            string format = "OdjavaFormat";
            string verzija = "1.0";

            // Pisanje u binarnu datoteku
            using (BinaryWriter writer = new BinaryWriter(File.Open(binarnaDatoteka, FileMode.Append)))
            {
                // Ako je datoteka prazna (ili nova), upisujemo zaglavlje
                if (new FileInfo(binarnaDatoteka).Length == 0)
                {
                    writer.Write(format);
                    writer.Write(verzija);
                }

                DateTime vrijemeOdjave = DateTime.Now;
                writer.Write(Session.DohvatiPunoIme());
                writer.Write(vrijemeOdjave.ToString("HH:mm"));
            }

            // Čitanje iz binarne datoteke
            using (BinaryReader reader = new BinaryReader(File.Open(binarnaDatoteka, FileMode.Open)))
            {
                // Čitanje zaglavlja
                string readFormatName = reader.ReadString();
                string readFormatVersion = reader.ReadString();

                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    string punoime = reader.ReadString();
                    string vrijemeOdjave = reader.ReadString();

                    string poruka = $"{punoime} odjavljen u {vrijemeOdjave}";
                    MessageBox.Show(poruka, "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Očistimo sesiju i vratimo se na početnu formu za prijavu
            Session.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }


        private void PostavkeDeaktivacijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Deaktivacija_racuna();
        }

        private void PostavkePromjenaButton_Click(object sender, EventArgs e)
        {
            iniFile.PostaviVrijednost("Postavke", "Jezik", PostavkeJezikComboBox.SelectedItem.ToString());
            iniFile.PostaviVrijednost("Postavke", "Font", PostavkeVelicinaFontaComboBox.SelectedItem.ToString());
            iniFile.SpremiDatoteku(@"..\..\postavke.ini");

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

            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PostavkeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            string jezik = iniFile.DohvatiVrijednost("Postavke", "Jezik", "hrvatski");
            string font = iniFile.DohvatiVrijednost("Postavke", "Font", "M");

            PostavkeJezikComboBox.SelectedItem = jezik;
            PostavkeVelicinaFontaComboBox.SelectedItem = font;


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

            if (font == "S")
            {
                PostavkeImeTextBox.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkePrezimeTextBox.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeKorisnickoImeTextBox.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkePonovnoLozinkaLabel.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeDeaktivacijaLinkLabel.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeJezikLabel.Font = new Font("Arial", 7, FontStyle.Regular);
                PostavkeFontLabel.Font = new Font("Arial", 7, FontStyle.Regular);
            }
            else if (font == "M")
            {
                PostavkeImeTextBox.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkePrezimeTextBox.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeKorisnickoImeTextBox.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkePonovnoLozinkaLabel.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeDeaktivacijaLinkLabel.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeJezikLabel.Font = new Font("Arial", 9, FontStyle.Regular);
                PostavkeFontLabel.Font = new Font("Arial", 9, FontStyle.Regular);
            }
            else if (font == "L")
            {
                PostavkeImeTextBox.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkePrezimeTextBox.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeKorisnickoImeTextBox.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkePonovnoLozinkaLabel.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeLozinkaLabel.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeDeaktivacijaLinkLabel.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeJezikLabel.Font = new Font("Arial", 11, FontStyle.Regular);
                PostavkeFontLabel.Font = new Font("Arial", 11, FontStyle.Regular);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostavkeProfilnaPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Display the selected file path (optional)
                    MessageBox.Show($"Selected file: {selectedFilePath}");

                    // Insert the image into the database
                    baza.BazaSetImage($"UPDATE korisnik SET profilna = ? WHERE korisnicko_ime = \"{user}\";", selectedFilePath);
                }
            }
        }
    }
}