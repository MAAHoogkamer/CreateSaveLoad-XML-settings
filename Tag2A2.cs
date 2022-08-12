using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
//For using xml with linq:
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;

namespace XMLtest
{
    public partial class Tag2A2 : Form
    {
        //Load 'Main' code here:
        public Tag2A2()
        {
            InitializeComponent();
            createXML();
        }
        public static void createXML()
        {
            XDocument xDoc = new XDocument(
                        new XDeclaration("1.0", "UTF-16", null),
                            new XElement("Window_properties",
                                new XComment("Window location:"),
                                new XElement("WinLoc", ""),
                                new XComment("Window size:"),
                                new XElement("WinSize", "")
                                ));
            xDoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempXMLtest.xml")
            );
        }
        //Set the path for local app data:
        static string localPath = Path.Combine
        (
         Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempXMLtest.xml"
        );
        //Loading the XML doc with Linq:
        XDocument windowSet = XDocument.Load(localPath);
        private void loadButt_Click(object sender, EventArgs e)
        {
            outputBox.Text += windowSet;
        }
        //Get form values and write them to doc:
        private void saveButt_Click(object sender, EventArgs e)
        {
            var WinLoc = this.Location.ToString();
            var WinSize = this.Size.ToString();
            var winz = windowSet;
            winz.XPathSelectElement("//Window_properties/WinLoc").Value = WinLoc;
            winz.XPathSelectElement("//Window_properties/WinSize").Value = WinSize;
            winz.Save(localPath);
        }
    }
}
