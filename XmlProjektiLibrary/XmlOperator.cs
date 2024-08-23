using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlProjektiLibrary
{
    public class XmlOperator
    {
        XmlDocument xmlDoc = new XmlDocument();


        public XmlOperator() { }

        public string XmlRead(string id)
        {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");

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
        public void XmlAdd(Projekt projekt) 
        {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");

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

            xmlDoc.Save(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");

        }
        public void XmlEdit(string id, string status) 
        {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/projekti/projekt");
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                string vrijdnostId = xmlNode.ChildNodes[0].InnerText.ToString();
                if (vrijdnostId != null && vrijdnostId == id)
                {
                    xmlNode.ChildNodes[1].InnerXml = status;
                }
            }
            xmlDoc.Save(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
        }
        public void XmlDelete(string id) {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
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
            xmlDoc.Save(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
        }
    }
}
