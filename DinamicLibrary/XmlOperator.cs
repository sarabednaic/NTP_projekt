using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace DinamicLibrary
{
    public class XmlOperator
    {
        XmlDocument xmlDoc = new XmlDocument();

        //prazan konstruktor kako bi mogli baratati sa metodama u klasi
        public XmlOperator() { }

        //Metoda za dohvaćanje statusa iz xml datoteke ovisno o ID-u projekta iz baze
        public string XmlRead(string id, string path, string nodes)
        {
            xmlDoc.Load(path);

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes(nodes);

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    string status = xmlNode.ChildNodes[1].InnerText.ToString();
                    return status;
                }
            }
            return "";
        }

        //Metoda za dodavanje statusa u xml datoteke ovisno za nove dodane projekte pri kreiranju projekta
        public void XmlAdd(Projekt projekt, string path, string nodes)
        {
            xmlDoc.Load(path);

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes(nodes);


            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == projekt.Id.ToString())
                {
                    break;
                }
            }
            XmlNode projektNode = xmlDoc.CreateNode("element", "projekt", "");
            XmlNode idNode = xmlDoc.CreateNode("element", "id", "");
            XmlNode statusNode = xmlDoc.CreateNode("element", "status", "");

            idNode.InnerText = projekt.Id.ToString();
            statusNode.InnerText = "Nije započeto";

            projektNode.AppendChild(idNode);
            projektNode.AppendChild(statusNode);

            XmlElement root = xmlDoc.DocumentElement;
            root.AppendChild(projektNode);

            xmlDoc.Save(path);

        }

        static public void XmlZadatakAdd(string id, string naziv, string opis, string pocetak, string kraj, string path, string nodes)
        {
            XmlDocument zadatakxmlDoc = new XmlDocument();
            zadatakxmlDoc.Load(path);

            XmlNodeList xmlNodeList = zadatakxmlDoc.SelectNodes(nodes);

            Boolean test = false;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[3].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId.Equals(id))
                {
                    test = true;
                }
            }

            if (test) return;
            XmlNode zadatakNode = zadatakxmlDoc.CreateNode("element", "Zadatak", "");
            XmlNode idNode = zadatakxmlDoc.CreateNode("element", "ID", "");
            XmlNode nazivNode = zadatakxmlDoc.CreateNode("element", "Naziv", "");
            XmlNode opisNode = zadatakxmlDoc.CreateNode("element", "Opis", "");
            XmlNode pocetakNode = zadatakxmlDoc.CreateNode("element", "Vrijeme_pocetak", "");
            XmlNode krajNode = zadatakxmlDoc.CreateNode("element", "Vrijeme_kraj", "");

            idNode.InnerText = id;
            nazivNode.InnerText = naziv;
            opisNode.InnerText = opis;
            pocetakNode.InnerText = pocetak;
            krajNode.InnerText = kraj;

            zadatakNode.AppendChild(idNode);
            zadatakNode.AppendChild(nazivNode);
            zadatakNode.AppendChild(opisNode);
            zadatakNode.AppendChild(pocetakNode);
            zadatakNode.AppendChild(krajNode);


            XmlElement root = zadatakxmlDoc.DocumentElement;
            root.AppendChild(zadatakNode);

            zadatakxmlDoc.Save(path);
        }

        public void XmlAdminAdd(string id,string ime, string prezime, string korisnickoIme , string lozinka , string sol,/*string[] projektID,*/ string path, string nodes) {
            xmlDoc.Load(path);

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes(nodes);

            Boolean test = false;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[3].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId.Equals(korisnickoIme))
                {
                    test = true;
                }
            }

            if (test) return;
            XmlNode adminNode = xmlDoc.CreateNode("element", "Admin", "");
            XmlNode idNode = xmlDoc.CreateNode("element", "IDkorisnika", "");
            XmlNode imeNode = xmlDoc.CreateNode("element", "Ime", "");
            XmlNode prezimeNode = xmlDoc.CreateNode("element", "Prezime", "");
            XmlNode korisnickoImeNode = xmlDoc.CreateNode("element", "KorisnickoIme", "");
            XmlNode lozinkaNode = xmlDoc.CreateNode("element", "Lozinka", "");
            XmlNode solNode = xmlDoc.CreateNode("element", "Sol", "");
            //XmlNode projetkiAdminNode = xmlDoc.CreateNode("element", "Admin projekata", "");

            idNode.InnerText = id;
            imeNode.InnerText = ime;
            prezimeNode.InnerText = prezime;
            korisnickoImeNode.InnerText = korisnickoIme;
            lozinkaNode.InnerText = lozinka;
            solNode.InnerText = sol;

            //string popis = "";
            //foreach (string projekt in projektID) {
            //    popis = projekt + " ";
            //}
            //projetkiAdminNode.InnerText = popis;

            adminNode.AppendChild(idNode);
            adminNode.AppendChild(imeNode);
            adminNode.AppendChild(prezimeNode);
            adminNode.AppendChild(korisnickoImeNode);
            adminNode.AppendChild(lozinkaNode);
            adminNode.AppendChild(solNode);
            //adminNode.AppendChild(projetkiAdminNode);

            XmlElement root = xmlDoc.DocumentElement;
            root.AppendChild(adminNode);

            xmlDoc.Save(path);
        }

        //Metoda za uređivanje statusa projekta ovisno o spremljenom ID projekta iz baze
        public void XmlEdit(string id, string status, string path, string nodes)
        {
            xmlDoc.Load(path);
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes(nodes);
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    xmlNode.ChildNodes[1].InnerXml = status;
                }
            }
            xmlDoc.Save(path);
        }

        //Metoda za brisanje zapisa o statusu projekta ovisno o ID projekta iz baze
        public void XmlDelete(string id, string path, string nodes, string MainNode)
        {
            xmlDoc.Load(path);
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes(nodes);
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    xmlNode.RemoveAll();
                    XmlNodeList projektlist = xmlDoc.SelectNodes(MainNode);
                    foreach (XmlNode node in projektlist)
                    {
                        node.RemoveChild(xmlNode);
                    }
                }
            }
            xmlDoc.Save(path);
        }
    }
}
