using System;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;


namespace ntp_projekt
{
    public partial class Prijava : Form
    {
        private Baza baza;

        public Prijava()
        {
            InitializeComponent();
            baza = new Baza(@"c:\TeamPlan.mdb");
            
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            
        }

        private void PrijavaLozinkaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrijavaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaPrijavaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik postojeciKorisnik = new Korisnik();
                postojeciKorisnik.KorisnickoIme = PrijavaKorisImeTextBox.Text;
                postojeciKorisnik.Ime = baza.BazaRead($"SELECT ime FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                postojeciKorisnik.Prezime = baza.BazaRead($"SELECT prezime FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                string lozinkaKorisnika = baza.BazaRead($"SELECT lozinka FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                string sol = baza.BazaRead($"SELECT sol FROM korisnik WHERE korisnicko_ime = \"{postojeciKorisnik.KorisnickoIme}\";");
                string hashiranaLozinka = Sha256.Sazimanje(PrijavaLozinkaTextBox.Text, sol);

                if (hashiranaLozinka == lozinkaKorisnika)
                {
                    Session.PostaviPodatke(postojeciKorisnik.KorisnickoIme, baza);

                    string binarnaDatoteka = @"..\..\prilagodena.dat";
                    string format = "OdjavaFormat";
                    string verzija = "1.0";
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

                        writer.Write("prijava");
                        writer.Write(punoIme);
                        writer.Write(datumOdjave);
                        writer.Write(vrijemeOdjaveFormatirano);
                    }
                    StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka je netočna!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom prijave: " + ex.Message);
            }
        }

        private void PrijavaRegistracijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Registracija();
        }
    }
}