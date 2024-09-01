using System;
using System.Collections.Generic;
using System.IO;

public class Ini
{
    //Prva osoba => [Ime][Sara], [Prezime][Bednaić];
    private Dictionary<string, Dictionary<string, string>> podaci = new Dictionary<string, Dictionary<string, string>>(StringComparer.InvariantCultureIgnoreCase);

    //ucita datoteku sa konkretne lokacije
    public void UcitajDatoteku(string lokacijaDatoteke)
    {
        if (!File.Exists(lokacijaDatoteke))
        {
            return;
        }

        string[] linije = File.ReadAllLines(lokacijaDatoteke);
        Dictionary<string, string> trenutnaSekcija = null;

        foreach (string linija in linije)
        {
            if (string.IsNullOrWhiteSpace(linija) || linija.StartsWith(";"))
                continue;

            if (linija.StartsWith("[") && linija.EndsWith("]"))
            {
                string sekcija = linija.Substring(1, linija.Length - 2);
                trenutnaSekcija = new Dictionary<string, string>();
                podaci[sekcija] = trenutnaSekcija;
            }
            else if (trenutnaSekcija != null)
            {
                string[] dijelovi = linija.Split(new[] { '=' }, 2);
                string kljuc = dijelovi[0].Trim();
                string vrijednost = dijelovi.Length > 1 ? dijelovi[1].Trim() : "";
                trenutnaSekcija[kljuc] = vrijednost;
            }
        }
    }

    //sprema datoteku sa promjenama na lokaciju
    public void SpremiDatoteku(string lokacijaDatoteke)
    {
        List<string> linije = new List<string>();

        foreach (var sekcija in podaci)
        {
            linije.Add("[" + sekcija.Key + "]");
            foreach (var par in sekcija.Value)
            {
                linije.Add(par.Key + "=" + par.Value);
            }
            linije.Add("");
        }

        File.WriteAllLines(lokacijaDatoteke, linije);
    }

    //postavljanje vrijednosti(POTREBNO POSEBNO SPREMITI DATOTEKU!)
    public void PostaviVrijednost(string sekcija, string kljuc, string vrijednost)
    {
        if (!podaci.ContainsKey(sekcija))
        {
            podaci[sekcija] = new Dictionary<string, string>();
        }

        podaci[sekcija][kljuc] = vrijednost;
    }

    //čitanje iz datoteke(sekcija, kljuc, ako nije postavljeno onda je ovo default vrijednost)
    public string DohvatiVrijednost(string sekcija, string kljuc, string defaultVrijednost)
    {
        if (podaci.ContainsKey(sekcija) && podaci[sekcija].ContainsKey(kljuc))
        {
            return podaci[sekcija][kljuc];
        }
        return defaultVrijednost;
    }
}
