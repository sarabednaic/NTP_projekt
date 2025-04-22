using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ntp_projekt
{
    public static class SessionZadatak
    {
        static Baza baza = new Baza(@"c:\TeamPlan.mdb");

        public static string Id { get; private set; }
        public static string Naslov { get; private set; }
        public static string Opis { get; private set; }
        public static string Pocetak { get; private set; }
        public static string Kraj { get; private set; }

        public static void ZadatakaInfo(string naslov, string opis)
        {
            List<string> info = baza.ListaBazaRead("SELECT zadatak.ID, zadatak.naziv, zadatak.opis, zadatak.vrijeme_pocetak, zadatak.vrijeme_kraj FROM zadatak WHERE zadatak.naziv = '" + naslov + "' AND zadatak.opis = '" + opis + "' ;");

            if (info != null && info.Count == 5)
            {
                Id = info[0];
                Naslov = info[1];
                Opis = info[2];
                Pocetak = info[3];
                Kraj = info[4];
            }
            else
            {
                Id = Naslov = Opis = Pocetak = Kraj = string.Empty;
                MessageBox.Show("Nema podataka o ovom zadatku zadatku.");
            }
        }

        public static void ZadatakaInfoById(string zadatakId)
        {
            List<string> info = baza.ListaBazaRead("SELECT zadatak.ID, zadatak.naziv, zadatak.opis, zadatak.vrijeme_pocetak, zadatak.vrijeme_kraj FROM zadatak WHERE zadatak.ID = " + zadatakId + ";");

            if (info != null && info.Count == 5)
            {
                Id = info[0];
                Naslov = info[1];
                Opis = info[2];
                Pocetak = info[3];
                Kraj = info[4];
            }
            else
            {
                Id = Naslov = Opis = Pocetak = Kraj = string.Empty;
                MessageBox.Show("Nema podataka o ovom zadatku.");
            }
        }

    }
}


