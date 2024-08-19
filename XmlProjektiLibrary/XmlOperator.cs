using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlProjektiLibrary
{
    public class XmlOperator
    {
        XmlDocument xmlDoc = new XmlDocument();
        Projekt[] projekts = null;
        int count = 0;


        public void XmlRead()
        {
            xmlDoc.Load(@"");

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//projekt");

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                if (xmlNode.SelectSingleNode("ID").InnerText == projekts[count].Id.ToString())
                {
                    projekts[count].Status = xmlNode.SelectSingleNode("status").InnerText;
                    projekts[count].Boja = Color.FromName(xmlNode.SelectSingleNode("boja").InnerText);

                }
            }

            count++;
        }
        public void XmlWrite(Projekt[] projekti) {
            
        }
        public void XmlEdit() { }
        public void XmlDelete() { }
    }
}
