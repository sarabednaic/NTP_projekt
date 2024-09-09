using dinamicLib;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class BrisanjeZadatka : Form
    {
        private Baza baza;
        public BrisanjeZadatka()
        {
            InitializeComponent();
            baza = new Baza(@"..\..\TeamPlan.mdb");
        }

        private void BrisanjeProjektaUserButton_Click(object sender, EventArgs e)
        {

        }

        private void BriasnjeProjektaNaslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaArrowButton_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaPFPButton_Click(object sender, EventArgs e)
        {

        }

        private void BrisanjeZadatkaNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
        }

        private void BrisanjeZadatkaIzbrisiZadatakButton_Click(object sender, EventArgs e)
        {
            if (BrisanjeZadatkaLozTextBox.Text == BrisanjeZadatkaPonovnoLozTextBox.Text)
            {
                List<string> brisanje = baza.ListaBazaRead("SELECT korisnik.lozinka, korisnik.sol FROM korisnik WHERE (korisnik.ime & ' ' & korisnik.prezime) = '" + Session.DohvatiPunoIme() + "';");

                if (Sha256.Sazimanje(BrisanjeZadatkaLozTextBox.Text, brisanje[1]) == brisanje[0])
                {
                    dll_form_zadatak dll_Form_Zadatak = new dll_form_zadatak();
                    DialogResult result = dll_Form_Zadatak.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        TaskHistory newTask = new TaskHistory(Session.DohvatiKorisnikID(), DateTime.Now.ToString(), "zadatak obrisan", SessionZadatak.Id);
                        TaskHistory.saveHistory(newTask);
                        baza.BazaDelete("DELETE FROM clanovi_zadatka WHERE zadatak_ID = " + SessionZadatak.Id + ";");
                        baza.BazaDelete("DELETE FROM zadatak WHERE zadatak.ID = " + SessionZadatak.Id + ";");

                        //dynamic znači da će se odmah odraditi u runtimeu
                        dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"..\..\statusZadatka.json"));
                        JToken zadatakZaBrisanje = null;

                        foreach (var obj in jsonFile)
                        {
                            if ((string)obj["Zadatak_ID"] == SessionZadatak.Id.ToString())
                            {
                                zadatakZaBrisanje = obj;
                                break;
                            }
                        }

                        //zapravo obriše file i ponovno ga spremi pod tim imenom sa novim podacima
                        if (zadatakZaBrisanje != null)
                        {
                            jsonFile.Remove(zadatakZaBrisanje);
                        }

                        File.WriteAllText(@"..\..\statusZadatka.json", JsonConvert.SerializeObject(jsonFile, Formatting.Indented));

                        StartApk.MainFormManager.TrenutnaForma = new PopisZadataka();
                    }
                    else if (result == DialogResult.No)
                    {
                        dll_Form_Zadatak.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lozinka nije ispravna.");
                }
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju.");
            }
        }



        private void DeaktivacijaProfilPictureBox_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeZadatkaProfilLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void BrisanjeZadatka_Load(object sender, EventArgs e)
        {
            PanelLogo.BackgroundImage = Image.FromFile(Logo.LogoFoto());
        }

        private void BrisanjeZadatka_Load_1(object sender, EventArgs e)
        {

        }
    }
}
