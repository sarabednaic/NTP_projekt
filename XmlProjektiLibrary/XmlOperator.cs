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
            xmlDoc.Load(@"C:\Users\Matija\Source\Repos\sarabednaic\NTP_projekt\XmlProjektiLibrary\XMLPopisProjekta.xml");

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
        public void XmlWrite(Projekt projekt) 
        {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
            
            
        }
        public void XmlEdit(Projekt projekt) 
        {
            xmlDoc.Load(@"..\..\..\XmlProjektiLibrary\XMLPopisProjekta.xml");
            XmlNodeList aNodes = xmlDoc.SelectNodes("/projekti/projekt");
            foreach (XmlNode aNode in aNodes)
            {
                XmlAttribute idAtribut = aNode.Attributes["id"];
                if (idAtribut != null && idAtribut.ToString() == projekt.Id.ToString())
                {
                    XmlAttribute statusAtribut = aNode.Attributes["status"];
                    statusAtribut.Value = projekt.Status;
                }
            }
        }
        public void XmlDelete() { }
    }
}
