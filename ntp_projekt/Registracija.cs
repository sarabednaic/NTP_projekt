using System;
using System.Threading;
using System.Windows.Forms;
using ntp_projekt.soap;  // Namespace za SOAP servis

namespace ntp_projekt
{
    public partial class Registracija : Form
    {
        private Baza baza;
        Ini iniFile;

        public Registracija()
        {
            //Dodaje sliku, spaja bazu , učitava ini datoteku...
            InitializeComponent();
            baza = new Baza(@"c:\TeamPlan.mdb");
            iniFile = new Ini();
            iniFile.UcitajDatoteku(@"..\..\postavke.ini");

            RegistracijaJezikComboBox.Items.Add("hrvatski");
            RegistracijaJezikComboBox.Items.Add("english");
        }

        private void Registracija_Load(object sender, EventArgs e)
        {

        }


        private void RegistracijaButton_Click(object sender, EventArgs e)
        {
            if (RegistracijaImeTextBox.Text != "" && RegistracijaPrezimeTextBox.Text != "" &&
                RegistracijaKorisnickoTextBox.Text != "" && RegistracijaLozinkaTextBox.Text != "")
            {
                try
                {
                    //pozivanje SOAP servisa za pretvaranje korisničkog imena u mala slova
                    ntp_projekt.soap.TextCasingSoapTypeClient soapClient = new ntp_projekt.soap.TextCasingSoapTypeClient("TextCasingSoap");
                    string korisnickoIme = soapClient.LowercaseWordsWithToken(RegistracijaKorisnickoTextBox.Text,"");

                    Korisnik noviKorisnik = new Korisnik(
                        RegistracijaImeTextBox.Text,
                        RegistracijaPrezimeTextBox.Text,
                        korisnickoIme,  // Korisničko ime s malim slovima
                        RegistracijaLozinkaTextBox.Text
                    );

                    if (noviKorisnik.Lozinka != RegistracijaPonovnoLozinkaTextBox.Text)
                    {
                        MessageBox.Show("Lozinke se ne podudaraju.");
                        return;
                    }

                    string sol = Sha256.PromjenjivaSol();
                    string hashiranaLozinka = Sha256.Sazimanje(noviKorisnik.Lozinka, sol);

                    // Provera da li već postoji korisnik sa istim korisničkim imenom
                    string rezultat = baza.BazaRead("SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = \"" + noviKorisnik.KorisnickoIme + "\";");

                    if (rezultat == "0")
                    {
                        // SQL upit za upis novog korisnika u bazu
                        string upit = "INSERT INTO korisnik (korisnicko_ime, ime, prezime, lozinka , sol) VALUES (\""
                            + noviKorisnik.KorisnickoIme + "\", \""
                            + noviKorisnik.Ime + "\", \""
                            + noviKorisnik.Prezime + "\", \""
                            + hashiranaLozinka + "\", \""
                            + sol + "\");";

                        //Mijenja podatke o korisniku na temelju teksta u textboxovima
                        int prijava = baza.BazaWrite(upit);
                        string query = $"UPDATE korisnik SET profilna = ? WHERE korisnicko_ime = \"{noviKorisnik.KorisnickoIme}\";";
                        baza.BazaSetImage(query, @"..\..\Images\profilna.jpg");
                        iniFile.PostaviVrijednost("Postavke", "Jezik", RegistracijaJezikComboBox.SelectedItem.ToString());
                        iniFile.SpremiDatoteku(@"..\..\postavke.ini");
                        string jezik = iniFile.DohvatiVrijednost("Postavke", "Jezik", "hrvatski");

                        //Postavlja jezik ovisno o ini filu
                        if (prijava > 0)
                        {
                            MessageBox.Show("Registracija uspješna!");

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

                            StartApk.MainFormManager.TrenutnaForma = new Prijava();
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do greške prilikom registracije.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Korisničko ime je već zauzeto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti sve podatke kako bi se uspiješno registrirali!");
            }
        }
    }
}
