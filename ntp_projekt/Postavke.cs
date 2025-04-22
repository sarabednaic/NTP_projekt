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
            baza = new Baza(@"c:\TeamPlan.mdb");
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

            //pisanje
            using (BinaryWriter writer = new BinaryWriter(File.Open(binarnaDatoteka, FileMode.Append)))
            {
                //pisanje zaglavlja ako je datoteka nova
                if (new FileInfo(binarnaDatoteka).Length == 0)
                {
                    writer.Write(format);
                    writer.Write(verzija);
                }

                DateTime vrijemeOdjave = DateTime.Now;
                string punoIme = Session.DohvatiPunoIme();
                string datumOdjave = vrijemeOdjave.ToString("dd.MM.yyyy.");
                string vrijemeOdjaveFormatirano = vrijemeOdjave.ToString("HH:mm");

                writer.Write("odjava");
                writer.Write(punoIme);
                writer.Write(datumOdjave);
                writer.Write(vrijemeOdjaveFormatirano); 
            }

            //čitanje
            using (BinaryReader reader = new BinaryReader(File.Open(binarnaDatoteka, FileMode.Open)))
            {
                string readFormatName = reader.ReadString();
                string readFormatVersion = reader.ReadString();
                string dogadaj = null;
                string punoIme = null;
                string datumOdjave = null;
                string vrijemeOdjave = null;

                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    dogadaj = reader.ReadString();
                    punoIme = reader.ReadString();
                    datumOdjave = reader.ReadString(); 
                    vrijemeOdjave = reader.ReadString(); 
                }

                string poruka = $"{punoIme} odjavljen {datumOdjave} u {vrijemeOdjave}";
                MessageBox.Show(poruka, "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //maknuemo sesiju korisnika
            Session.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }



        private void PostavkeDeaktivacijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Deaktivacija_racuna();
        }

        private void PostavkePromjenaButton_Click(object sender, EventArgs e)
        {
            string novoIme = PostavkeImeTextBox.Text;
            string novoPrezime = PostavkePrezimeTextBox.Text;
            string novoKorisnickoIme = PostavkeKorisnickoImeTextBox.Text;
            string novaLozinka = PostavkeLozinkaTextBox.Text;
            string ponovnoLozinka = PostavkePonovnoLozinkaTextBox.Text;

            //korisničko ime
            if (novoKorisnickoIme != user)
            {
                string korisnikPostoji = baza.BazaRead($"SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = \"{novoKorisnickoIme}\";");

                if (korisnikPostoji != "0")
                {
                    MessageBox.Show("Korisničko ime već postoji. Odaberite drugo korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ažuriranje korisničkog imena
                baza.BazaWrite($"UPDATE korisnik SET korisnicko_ime = \"{novoKorisnickoIme}\" WHERE korisnicko_ime = \"{user}\";");
                user = novoKorisnickoIme; // Ažuriraj lokalnu varijablu korisničkog imena
            }

            //ime
            if (novoIme != baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{user}\";"))
            {
                baza.BazaWrite($"UPDATE korisnik SET ime = \"{novoIme}\" WHERE korisnicko_ime = \"{user}\";");
            }

            //prezime
            if (novoPrezime != baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{user}\";"))
            {
                baza.BazaWrite($"UPDATE korisnik SET prezime = \"{novoPrezime}\" WHERE korisnicko_ime = \"{user}\";");
            }

            //lozinke
            if (!string.IsNullOrEmpty(novaLozinka) || !string.IsNullOrEmpty(ponovnoLozinka))
            {
                if (novaLozinka != ponovnoLozinka)
                {
                    MessageBox.Show("Lozinke se ne podudaraju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sol = Sha256.PromjenjivaSol();
                string hashiranaLozinka = Sha256.Sazimanje(novaLozinka, sol);
                baza.BazaWrite($"UPDATE korisnik SET lozinka = \"{hashiranaLozinka}\", sol = \"{sol}\" WHERE korisnicko_ime = \"{user}\";");
            }


            Session.PostaviPodatke(novoKorisnickoIme, baza);

            MessageBox.Show("Promjene su uspješno spremljene.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //jezika i fonta u ini datoteku
            iniFile.PostaviVrijednost("Postavke", "Jezik", PostavkeJezikComboBox.SelectedItem.ToString());
            iniFile.PostaviVrijednost("Postavke", "Font", PostavkeVelicinaFontaComboBox.SelectedItem.ToString());
            iniFile.SpremiDatoteku(@"..\..\postavke.ini");

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

                    MessageBox.Show($"Selected file: {selectedFilePath}");

                    baza.BazaSetImage($"UPDATE korisnik SET profilna = ? WHERE korisnicko_ime = \"{user}\";", selectedFilePath);
                }
            }
        }
    }
}