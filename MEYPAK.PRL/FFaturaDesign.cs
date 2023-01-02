using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.IO;
using MEYPAK.PRL.EFatura;
using static MEYPAK.PRL.EFatura.TemelFaturaXML;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.CARI;

namespace MEYPAK.PRL
{
    public partial class FFaturaDesign : Form
    {
        public FFaturaDesign()
        {
            InitializeComponent();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
        }
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _faturaServis.Data(ServisList.FaturaListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
           var fatura= _faturaServis.obje.FirstOrDefault();
            var cari = _cariServis.obje.Where(x => x.id == fatura.id);
            DataSet ds;
            XmlDataDocument xmlDoc;
            XslCompiledTransform xslTran;
            XmlElement root;
            XPathNavigator nav;
            XmlTextWriter writer;
            try
            {
                TemelFaturaXML.Invoice temelfatura = new Invoice()
                {
                    AccountingCustomerParty = new AccountingCustomerParty()
                    {
                        Party = new AccountingCustomerPartyParty()
                        {
                            Contact = new AccountingCustomerPartyPartyContact()
                            {

                            }
                        }
                    }
                };
                
                //Create the DataSet from the XML file
                ds = new DataSet();
                ds.ReadXml("Employee.xml");
                //Create the XML from the DataSet
                xmlDoc = new XmlDataDocument(ds);
                //Load the XSLT for Transformation
                xslTran = new XslCompiledTransform();
                xslTran.Load("Employee.xslt");
                //Determine the Root object in the XML
                root = xmlDoc.DocumentElement;
                //Create the XPath Navigator to navigate throuth the XML
                nav = root.CreateNavigator();
                //First delete the RTF, if already exist
                if (File.Exists("Employee.rtf"))
                {
                    File.Delete("Employee.rtf");
                }
                //Create the RTF by Transforming the XML and XSLT
                writer = new XmlTextWriter("Employee.rtf", System.Text.Encoding.Default);
                xslTran.Transform(nav, writer);
                //Close the Writer after Transformation
                writer.Close();
                //Release all objects
                writer = null;
                nav = null;
                root = null;
                xmlDoc = null;
                ds = null;
                MessageBox.Show("Document created successfully.....");
            }
            catch (Exception ex)
            {
                writer = null;
                nav = null;
                root = null;
                xmlDoc = null;
                ds = null;
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
