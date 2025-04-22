using dinamicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinamicLibrary;

namespace ntp_projekt
{
    public partial class DodajProjekt : Form
    {
        Baza baza = new Baza(@"c:\TeamPlan.mdb");
        string PutanjaXMLProjekt = @"..\..\..\DinamicLibrary\XMLPopisProjekta.xml";
        string nodes = "/projekti/projekt";
        public DodajProjekt()
        {
            InitializeComponent();
            
            DodajProjektProfilLinkLabel.Text = Session.DohvatiPunoIme();
            DodajProjektProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            DodajProjektClanoviListBox.Items.Clear();
            DodajProjektOvlastiListBox.Items.Clear();
        }

        private void DodajProjektClanoviListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjektOvlastiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajProjekt_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }

        private void DodajProjektNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void DodajProjektProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajProjektProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void DodajProjektButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DodajProjektNazivTextBox.Text) || string.IsNullOrEmpty(DodajProjektOpisRichTextBox.Text) ||
                    DodajProjektClanoviListBox.Items.Count == 0 || DodajProjektOvlastiListBox.Items.Count == 0)
                {
                    MessageBox.Show("Molimo Vas da popunite sva polja kako bi ste dodali projekt");
                    return;
                }

                string projektNaziv = DodajProjektNazivTextBox.Text;
                string projektOpis = DodajProjektOpisRichTextBox.Text;

                //provjerava se ako već ostoji projekt pod tim imenom
                string provjeraQuery = "SELECT COUNT(*) FROM projekt WHERE naziv = ?";
                int projectCount = Convert.ToInt32(baza.BazaReadParametar(provjeraQuery, new OleDbParameter("@naziv", projektNaziv)));

                if (projectCount > 0)
                {
                    MessageBox.Show("Projekt s tim imenom već postoji.");
                    return;
                }

                //dodavanje porojekta
                string insertProjectQuery = "INSERT INTO projekt (naziv, opis) VALUES (?, ?)";
                int projectId = baza.BazaWriteParametar(insertProjectQuery,
                    new OleDbParameter("@naziv", projektNaziv),
                    new OleDbParameter("@opis", projektOpis));

                if (projectId <= 0)
                {
                    MessageBox.Show("Greška pri dodavanju projekta.");
                    return;
                }

                //dodavanje u XML
                XmlOperator xmlOperator = new XmlOperator();
                Projekt noviProjekt = new Projekt(projectId.ToString(), projektNaziv, projektOpis);
                xmlOperator.XmlAdd(noviProjekt, PutanjaXMLProjekt, nodes);

                //dodavanje korisnika na projekt
                string korisniciUpit = "SELECT ID, ime, prezime FROM korisnik";
                List<string> registriraniKorisnici = baza.ListaBazaRead(korisniciUpit);

                for (int i = 0; i < registriraniKorisnici.Count; i += 3)
                {
                    string punoIme = registriraniKorisnici[i + 1] + " " + registriraniKorisnici[i + 2];
                    int korisnikId = int.Parse(registriraniKorisnici[i]);

                    if (DodajProjektClanoviListBox.Items.Contains(punoIme))
                    {
                        bool isAdmin = DodajProjektOvlastiListBox.Items.Contains(punoIme);

                        string insertMemberQuery = "INSERT INTO clanovi_projekta (korisnik_ID, projekt_ID, admin) VALUES (?, ?, ?)";
                        int result = baza.BazaWriteParametar(insertMemberQuery,
                            new OleDbParameter("@korisnik_ID", korisnikId),
                            new OleDbParameter("@projekt_ID", projectId),
                            new OleDbParameter("@admin", isAdmin));

                        if (result <= 0)
                        {
                            MessageBox.Show($"Greška pri dodavanju člana {punoIme} u projekt.");
                        }
                    }
                }
                TaskHistory newTask = new TaskHistory(Session.DohvatiKorisnikID(), DateTime.Now.ToString(), "projekt dodan", projectId.ToString());
                TaskHistory.saveHistory(newTask);
                MessageBox.Show("Projekt uspješno dodan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju projekta: " + ex.Message);
            }

            StartApk.MainFormManager.TrenutnaForma = new DodajProjekt();
        }

        private void DodajProjektDodajClanaButton_Click(object sender, EventArgs e)
        {
            if (DodajProjektDodajClanaTextBox.Text != null) {
                DodajProjektClanoviListBox.Items.Add(DodajProjektDodajClanaTextBox.Text);
                DodajProjektDodajClanaTextBox.Text = null;
            }
        }

        private void DodajProjektDodajAdminButton_Click(object sender, EventArgs e)
        {
            if (DodajProjektDodajAdminTextBox.Text != null)
            {
                DodajProjektOvlastiListBox.Items.Add(DodajProjektDodajAdminTextBox.Text);
                DodajProjektDodajAdminTextBox.Text = null;
            }

        }
    }
}
