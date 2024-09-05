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
using DinamicLibrary;
using static QuestPDF.Helpers.Colors;

namespace ntp_projekt
{
    public partial class UrediProjekt : Form
    {
        Baza baza = new Baza(@"..\..\TeamPlan.mdb");
        string korisniciQuery = "SELECT ID, ime, prezime FROM korisnik";
        string clanoviQuery = "SELECT korisnik_ID, admin FROM clanovi_projekta WHERE projekt_ID = ?";
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


            //Dohvaca registrirane korisnike
            List<string> registriraniKorisnici = baza.ListaBazaRead(korisniciQuery);

            //Dohvaca calnove koji rade na projektu
            List<string> clanoviProjekta = baza.ListaBazaReadParametar(clanoviQuery, new OleDbParameter("@projekt_ID", projektID));

            // Pohranjuje clanove za ubacivanje u LIstBox
            List<string> clanovi = new List<string>();
            List<string> admini = new List<string>();


            for (int i = 0; i < clanoviProjekta.Count; i += 2)
            {
                int korisnikId = int.Parse(clanoviProjekta[i]);
                bool isAdmin = bool.Parse(clanoviProjekta[i + 1]);


                for (int j = 0; j < registriraniKorisnici.Count; j += 3)
                {
                    if (int.Parse(registriraniKorisnici[j]) == korisnikId)
                    {
                        string punoIme = registriraniKorisnici[j + 1] + " " + registriraniKorisnici[j + 2];

                        //Dodaje članove neovisno o administratorskim ovlastima
                        clanovi.Add(punoIme);

                        //Provjerava administratorkse ovlasti
                        if (isAdmin)
                        {
                            admini.Add(punoIme);
                        }

                        break;
                    }
                }
            }

            //Dodaje članove u listbox
            foreach (string clan in clanovi)
            {
                UrediProjektClanoviListBox.Items.Add(clan);
            }
            //stavlja kvačice pokraj svakog clana u listboxu
            for (int i = 0; i < clanovi.Count; i++)
            {
                UrediProjektClanoviListBox.SetItemChecked(i, true);
            }
            //Dodaje admine u listbox
            foreach (string admin in admini)
            {
                UrediProjektOvlastiListBox.Items.Add(admin);
            }

            //stavlja kvačice pokraj svakog admina u listboxu
            for (int i = 0; i < admini.Count; i++)
            {
                UrediProjektOvlastiListBox.SetItemChecked(i, true);
            }
        }

        private void UrediProjekt_Load(object sender, EventArgs e)
        {
            //Postavlja logo
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());

        }



        //Uzima podatke koji su upisanu u svima textboxovima , listboxovima i sprema/brise ih u/iz baze
        private void UrediProjektButton_Click(object sender, EventArgs e)
        {
            //Updatea naziv projekta
            int projektID = Int32.Parse(trenutniprojekt.Id);
            if (UrediProjektNazivTextBox.Text != "")
            {
                string projektNaziv = UrediProjektNazivTextBox.Text;

                string Query = "UPDATE projekt SET naziv = ? WHERE ID = ?";
                int rowsAffected = baza.BazaWriteParametar(Query,
                    new OleDbParameter("@naziv", projektNaziv),
                    new OleDbParameter("@id", projektID));
            }

            //Updatea opis projekta
            if (UrediProjektOpisRichTextBox.Text != "")
            {
                string projektOpis = UrediProjektOpisRichTextBox.Text;

                string Query = "UPDATE projekt SET opis = ? WHERE ID = ?";
                int rowsAffected = baza.BazaWriteParametar(Query,
                    new OleDbParameter("@opis", projektOpis),
                    new OleDbParameter("@id", projektID));
            }

            //brise clanove i admine koji su odznačeni u listboxu
            for (int i = 0; i < UrediProjektClanoviListBox.Items.Count; i++)
            {
                if (UrediProjektClanoviListBox.GetItemChecked(i) == false)
                {
                    string queryKorisnik = $"SELECT ID FROM korisnik WHERE korisnik.ime & ' ' & korisnik.prezime = \'{UrediProjektClanoviListBox.Items[i]}\' ;";
                    int id = Int32.Parse(baza.BazaRead(queryKorisnik));

                    Projekt projekt = SessionProjekt.dohvatiTrenutniProjekt();
                    int trenutniProjektID = Int32.Parse(projekt.Id);

                    string[] queries = new string[]
                            {
                        "DELETE FROM clanovi_zadatka WHERE clanovi_zadatka.clan_projekta_ID IN (SELECT clanovi_projekta.ID  FROM clanovi_projekta WHERE clanovi_projekta.korisnik_ID = ? AND clanovi_projekta.projekt_ID = ?);"
                        ,"DELETE FROM clanovi_projekta WHERE korisnik_ID = ? AND projekt_ID = ?;"
                            };


                    foreach (string query in queries)
                    {
                        int result = baza.BazaDelete(query, new OleDbParameter("@korisnik_ID", id), new OleDbParameter("@projekt_ID", trenutniProjektID));
                        if (result == -1)
                        {
                            break;
                        }
                    }
                };
            }



            //Updatea status projekta
            if (UrediProjektStatusComboBox.SelectedItem != null)
            {
                XmlOperator xmlOperator = new XmlOperator();
                xmlOperator.XmlEdit(trenutniprojekt.Id, UrediProjektStatusComboBox.Text);
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






    }
}
