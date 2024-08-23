using dinamicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public partial class UrediProjekt : Form
    {
        Baza baza = new Baza(@"..\..\TeamPlan.mdb");
        string korisniciQuery = "SELECT ID, ime, prezime FROM korisnik";
        Projekt trenutniprojekt = SessionProjekt.dohvatiTrenutniProjekt();


        public UrediProjekt()
        {
            InitializeComponent();
            UrediProjektProfilLinkLabel.Text = Session.DohvatiPunoIme();
            UrediProjektProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
            UrediProjektStatusComboBox.Text = null;
            UrediProjektNazivTextBox.Text = null;
            UrediProjektOpisRichTextBox.Text = null;
            UrediProjektClanoviListBox.Items.Clear();
            UrediProjektOvlastiListBox.Items.Clear();

            int projektID = Int32.Parse(trenutniprojekt.Id);

            // Get all users
            string korisniciQuery = "SELECT ID, ime, prezime FROM korisnik";
            List<string> registriraniKorisnici = baza.ListaBazaRead(korisniciQuery);

            // Get members of the current project
            string clanoviQuery = "SELECT korisnik_ID, admin FROM clanovi_projekta WHERE projekt_ID = ?";
            List<string> clanoviProjekta = baza.ListaBazaReadWithParams(clanoviQuery, new OleDbParameter("@projektID", projektID));

            // Lists to store members and admins
            List<string> clanovi = new List<string>();
            List<string> admini = new List<string>();

            //// Process project members
            //for (int i = 0; i < clanoviProjekta.Count; i += 2)
            //{
            //    int korisnikId = int.Parse(clanoviProjekta[i]);
            //    bool isAdmin = bool.Parse(clanoviProjekta[i + 1]);

            //    // Find the user's full name
            //    for (int j = 0; j < registriraniKorisnici.Count; j += 3)
            //    {
            //        if (int.Parse(registriraniKorisnici[j]) == korisnikId)
            //        {
            //            string punoIme = registriraniKorisnici[j + 1] + " " + registriraniKorisnici[j + 2];

            //            if (isAdmin)
            //            {
            //                bool test = false;
            //                foreach (string admin in admini) {
            //                    if (admin == punoIme) {
            //                        test = true;
            //                    }
            //                }
            //                if (!test) {
            //                    admini.Add(punoIme);
            //                    clanovi.Add(punoIme);
            //                }
                            
            //            }
            //            else
            //            {
            //                bool test = false;
            //                foreach (string clan in clanovi) {
            //                    if (clan == punoIme) {
            //                        test = true;
            //                    }
            //                }
            //                if (!test)
            //                {
            //                    clanovi.Add(punoIme);
            //                }
            //            }
            //            break;
            //        }
            //    }
                
            //}

            for (int i = 0; i < clanoviProjekta.Count; i += 2)
            {
                int korisnikId = int.Parse(clanoviProjekta[i]);
                bool isAdmin = bool.Parse(clanoviProjekta[i + 1]);

                // Find the user's full name
                for (int j = 0; j < registriraniKorisnici.Count; j += 3)
                {
                    if (int.Parse(registriraniKorisnici[j]) == korisnikId)
                    {
                        string punoIme = registriraniKorisnici[j + 1] + " " + registriraniKorisnici[j + 2];

                        // Add to clanovi regardless of admin status
                        clanovi.Add(punoIme);

                        if (isAdmin)
                        {
                            admini.Add(punoIme);
                        }

                        break; // Exit the inner loop once we've found and processed the user
                    }
                }
            }
            foreach (string clan in clanovi)
            {
                UrediProjektClanoviListBox.Items.Add(clan);
            }

            foreach (string admin in admini)
            {
                UrediProjektOvlastiListBox.Items.Add(admin);
            }
        }

        private void UrediProjekt_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }


        private void UrediProjektDodajClanaButton_Click(object sender, EventArgs e)
        {
            if (UrediProjektDodajClanaTextBox.Text != null)
            {
                UrediProjektClanoviListBox.Items.Add(UrediProjektDodajClanaTextBox.Text);
                UrediProjektDodajClanaTextBox.Text = null;
            }
        }

        private void UrediProjektDodajAdminButton_Click(object sender, EventArgs e)
        {
            if (UrediProjektDodajAdminTextBox.Text != null)
            {
                UrediProjektOvlastiListBox.Items.Add(UrediProjektDodajAdminTextBox.Text);
                UrediProjektDodajAdminTextBox.Text = null;
            }

        }

        private void UrediProjektButton_Click(object sender, EventArgs e)
        {

            int projektID = Int32.Parse(trenutniprojekt.Id);
            if (UrediProjektNazivTextBox.Text != ""){
                string projektNaziv = UrediProjektNazivTextBox.Text;

                string Query = "UPDATE projekt SET naziv = ? WHERE ID = ?";
                int rowsAffected = baza.BazaWriteWithParams(Query,
                    new OleDbParameter("@naziv", projektNaziv),
                    new OleDbParameter("@id", projektID));
            }
            
            if (UrediProjektOpisRichTextBox.Text != "") {
                string projektOpis = UrediProjektOpisRichTextBox.Text;

                string Query = "UPDATE projekt SET opis = ? WHERE ID = ?";
                int rowsAffected = baza.BazaWriteWithParams(Query,
                    new OleDbParameter("@opis", projektOpis),
                    new OleDbParameter("@id", projektID));
            }


            List<string> registriraniKorisnici = baza.ListaBazaRead(korisniciQuery);
            //Kupi korisnike iz lista i updatea bazu
            //for (int i = 0; i < registriraniKorisnici.Count; i += 3)
            //{
            //    string punoIme = registriraniKorisnici[i + 1] + " " + registriraniKorisnici[i + 2];
            //    int korisnikId = int.Parse(registriraniKorisnici[i]);

            //    if (UrediProjektClanoviListBox.Items.Contains(punoIme))
            //    {
            //        bool isAdmin = UrediProjektOvlastiListBox.Items.Contains(punoIme);

            //        string insertMemberQuery = "UPDATE clanovi_projekta SET korisnik_ID = ? , admin = ? WHERE projekt_ID = ?";
            //        int result = baza.BazaWriteWithParams(insertMemberQuery,
            //            new OleDbParameter("@korisnik_ID", korisnikId),
            //            new OleDbParameter("@admin", isAdmin),
            //            new OleDbParameter("@projekt_ID", projektID));

            //        if (result <= 0)
            //        {
            //            MessageBox.Show($"Greška pri dodavanju člana {punoIme} u projekt.");
            //        }
            //    }
            //}


            if (UrediProjektStatusComboBox.SelectedItem != null) {
                XmlOperator xmlOperator = new XmlOperator();
                xmlOperator.XmlEdit(trenutniprojekt.Id , UrediProjektStatusComboBox.Text);
            }
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void UrediProjektNatragButton_Click(object sender, EventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void UrediProjektProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void UrediProjektProfilPictureBox_Click(object sender, EventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void UrediProjektDeleteClanButton_Click(object sender, EventArgs e)
        {
            if (UrediProjektDodajClanaTextBox.Text != null && UrediProjektClanoviListBox.Items != null) 
            {
                foreach (string ime in UrediProjektClanoviListBox.Items)
                {
                    if (ime == UrediProjektDodajClanaTextBox.Text)
                    {
                        UrediProjektClanoviListBox.Items.Remove(ime);
                    }
                }
            }
        }

        private void UrediProjektDeleteAdminButton_Click(object sender, EventArgs e)
        {
            if (UrediProjektDodajAdminTextBox.Text != null && UrediProjektOvlastiListBox.Items != null)
            {
                foreach (string ime in UrediProjektOvlastiListBox.Items)
                {
                    if (ime == UrediProjektDodajAdminTextBox.Text)
                    {
                        UrediProjektOvlastiListBox.Items.Remove(ime);
                    }
                }
            }
        }

        

        
    }
}
