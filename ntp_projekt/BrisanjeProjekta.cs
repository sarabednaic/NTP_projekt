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
using XmlProjektiLibrary;

namespace ntp_projekt
{
    public partial class BrisanjeProjekta : Form
    {
        Baza baza = new Baza(@"..\..\TeamPlan.mdb");
        public BrisanjeProjekta()
        {
            InitializeComponent();
            BrisanjeProjektaProfilLinkLabel.Text = Session.DohvatiPunoIme();
            BrisanjeProjektaProfilPictureBox.Image = Session.DohvatiProfilnuSliku();
        }

        private void DodajProjektProfilPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrisanjeProjekta_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());
        }

        private void BrisanjeProjektaProfilPictureBox_Click(object sender, EventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeProjektaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeProjektaNatragButton_Click(object sender, EventArgs e)
        {

            SessionProjekt.CleanSession();
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void BrisanjeProjektaIzbrisiProjektButton_Click(object sender, EventArgs e)
        {
            XmlOperator obrisi = new XmlOperator();
            string user = Session.DohvatiKorisnika();
            string lozinkaKorisnika = baza.BazaRead($"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string sol = baza.BazaRead($"SELECT sol FROM korisnik WHERE korisnicko_ime = \"{user}\";");
            string hashiranaLozinka = Sha256.Sazimanje(BrisanjeProjektaLozinkaTextBox.Text, sol);
            if (BrisanjeProjektaLozinkaTextBox.Text.Length != 0 && BrisanjeProjektaPonovnoLozinkaTextBox.Text.Length != 0)
            {
                if (hashiranaLozinka == lozinkaKorisnika)
                {
                    if (BrisanjeProjektaLozinkaTextBox.Text == BrisanjeProjektaPonovnoLozinkaTextBox.Text)
                    {
                        dll_form_projekt dll_Form_Projekt = new dll_form_projekt();
                        DialogResult dijalogProjekt = dll_Form_Projekt.ShowDialog();
                        if (dijalogProjekt == DialogResult.Yes)
                        {
                            Projekt projekt = SessionProjekt.dohvatiTrenutniProjekt();
                            int projektID = Int32.Parse(projekt.Id);

                            string[] upiti = new string[]
                            {
                                "DELETE FROM clanovi_zadatka WHERE clanovi_zadatka.clan_projekta_ID IN (SELECT clanovi_projekta.ID  FROM clanovi_projekta WHERE clanovi_projekta.projekt_ID = ?);"
                                ,"DELETE FROM clanovi_projekta WHERE projekt_ID = ?;",
                                "DELETE FROM projekt WHERE ID = ?;"
                            };

                            bool success = true;
                            //provjera da li je svaki upit brisanja prosao
                            foreach (string upit in upiti)
                            {
                                int result = baza.BazaDelete(upit, new OleDbParameter("@projekt_ID", projektID));
                                if (result == -1)
                                {
                                    success = false;
                                    break;
                                }
                            }
                            obrisi.XmlDelete(projekt.Id);

                            obrisi.XmlDelete(projekt.Id);

                            if (success==true)
                            {
                                //maknuti session kada je sve potrebno obrisano
                                TaskHistory newTask = new TaskHistory(Session.DohvatiKorisnikID(), DateTime.Now.ToString(), "projekt obrisan", SessionProjekt.dohvatiTrenutniProjekt().Id);
                                TaskHistory.saveHistory(newTask);
                                SessionProjekt.CleanSession();
                                StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                            }

                        }

                        else if (dijalogProjekt == DialogResult.No)
                        {
                            dll_Form_Projekt.Close();
                        }

                        else
                        {
                            MessageBox.Show("Došlo je do greške prilikom brisanja projekta. Molimo pokušajte ponovno.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne podudaraju.Pokušajte ponovno!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna!");
            }

        }
    }
}
