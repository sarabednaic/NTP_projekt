using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProjektiLibrary
{
    public class Projekt
    {
        string id;
        string naslov;
        string opis;
        string status;
        Color boja;


        public Projekt(string _Id ,string _Naslov, string _Opis)
        {
            this.id = _Id ;
            this.naslov = _Naslov ;
            this.opis = _Opis ;
        }

        public string Id { get { return id; } set { id = value; } }
        public string Status { get { return status; } set { status = value; } }
        public Color Boja { get { return boja; } set { boja = value; } }
        public string Opis { get { return opis; } set { opis = value; } }
        public string Naslov { get { return naslov; } set { naslov = value; } }

    }
}
