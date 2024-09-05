using System;
using System.Collections.Generic;
using System.Drawing;
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

        //Metoda za dohvaćanje statusa iz xml  datoteke ovisno o ID-u projekta iz baze
        public string XmlRead(string id)
        {
            xmlDoc.Load(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("projekti/projekt");

            foreach (XmlNode xmlNode in xmlNodeList)
            {   
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id) {
                    string status = xmlNode.ChildNodes[1].InnerText.ToString();
                    return status;
                }
            }
            return "";
        }

        //Metoda za dodavanje statusa u xml datoteke ovisno za nove dodane projekte pri kreiranju projekta
        public void XmlAdd(Projekt projekt) 
        {
            xmlDoc.Load(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("projekti/projekt");


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

            xmlDoc.Save(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");

        }

        //Metoda za uređivanje statusa projekta ovisno o spremljenom ID projekta iz baze
        public void XmlEdit(string id, string status) 
        {
            xmlDoc.Load(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/projekti/projekt");
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    xmlNode.ChildNodes[1].InnerXml = status;
                }
            }
            xmlDoc.Save(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");
        }

        //Metoda za brisanje zapisa o statusu projekta ovisno o ID projekta iz baze
        public void XmlDelete(string id) {
            xmlDoc.Load(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/projekti/projekt");
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    xmlNode.RemoveAll();
                    XmlNodeList projektlist = xmlDoc.SelectNodes("/projekti");
                    foreach (XmlNode node in projektlist)
                    {
                        node.RemoveChild(xmlNode);
                    }
                }
            }
            xmlDoc.Save(@"..\..\..\DinamicLibrary\XMLPopisProjekta.xml");
        }
    }
}
