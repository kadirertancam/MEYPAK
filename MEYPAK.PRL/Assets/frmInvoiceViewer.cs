
using EInvoiceDemoProject;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MEYPAK.PRL.Assets
{
    public partial class frmInvoiceViewer : Form
    {
        

        public frmInvoiceViewer()
        {
           
            InitializeComponent();
        }
        public frmInvoiceViewer(InvoiceType[] invoices)
        {
          
            InitializeComponent();
            dataGridView1.Columns.Add("Guid", "");
            dataGridView1.Columns.Add("Fatura Numarası", "");
            dataGridView1.Columns.Add("Alıcı", "");
            dataGridView1.Columns.Add("Alıcı VKN", "");
            for (int i = 0; i < invoices.Length; i++)
            {
                InvoiceType invoice = invoices[i];
                if (i==0)
                 ShowInvoice(invoice);
              
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = invoice.UUID.Value.ToString();
                row.Cells[1].Value = invoice.ID.Value.ToString();
                row.Cells[2].Value = invoice.AccountingCustomerParty.Party.PartyName.Name.Value.ToString()==null? invoice.AccountingCustomerParty.Party.Person.FamilyName.Value: invoice.AccountingCustomerParty.Party.PartyName.Name.Value.ToString();
                row.Cells[3].Value = invoice.AccountingCustomerParty.Party.PartyIdentification[0].ID.Value.ToString();
                row.Tag = invoice;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
           
        }
        public frmInvoiceViewer(InvoiceType[] invoices, string xslt)
        {

            InitializeComponent();
            //dataGridView1.Columns.Add("Guid", "");
            //dataGridView1.Columns.Add("Fatura Numarası", "");
            //dataGridView1.Columns.Add("Alıcı", "");
            //dataGridView1.Columns.Add("Alıcı VKN", "");
            //for (int i = 0; i < invoices.Length; i++)
            //{
                InvoiceType invoice = invoices[0];
                ShowInvoiceWithCustomXslt(invoice,xslt);

                //var row = new DataGridViewRow();
                //row.CreateCells(dataGridView1);
                //row.Cells[0].Value = invoice.UUID.Value.ToString();
                //row.Cells[1].Value = invoice.ID.Value.ToString();
                //row.Cells[2].Value = invoice.AccountingCustomerParty.Party.PartyName.Name.Value.ToString();
                //row.Cells[3].Value = invoice.AccountingCustomerParty.Party.PartyIdentification[0].ID.Value.ToString();
                //row.Tag = invoice;
                //dataGridView1.Rows.Add(row);
            //}
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.Rows[0].Selected = true;
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
          
        }

        void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                if (row != null || row.Cells[0].Value != null)
                {
                    string selectedGuid = row.Cells[0].Value.ToString();
                    InvoiceType invoice = row.Tag as InvoiceType;
                    label1.Text = selectedGuid;
                    ShowInvoice(invoice);
                }
            }
        }

        //Bu metoda bir fatura gönderildğğinde bu faturanın görüntülenmesini sağlar. 
        public void ShowInvoice(InvoiceType invoice)
        {
            try
            {

          
            var xslt=string.Empty;
           
            if (invoice.AdditionalDocumentReference != null)
            {
                AttachmentType attachment = null;
                DocumentReferenceType doc;
                byte[] xsltObject=null;

                for (int i = 0; i < invoice.AdditionalDocumentReference.Length; i++)
                {
                    doc = invoice.AdditionalDocumentReference[i];
                    attachment = doc.Attachment;
                    if (attachment!=null && attachment.EmbeddedDocumentBinaryObject.filename!=null)
                    {
                        string fileName = attachment.EmbeddedDocumentBinaryObject.filename;
                        if (Path.GetExtension(fileName) == ".xslt" || Path.GetExtension(fileName) == ".XSLT")
                        {
                            xsltObject = attachment.EmbeddedDocumentBinaryObject.Value;
                        }
                    }
                  
                }
                

                if (xsltObject != null)
                {
                    //var fileStream = File.Create("");
                    //fileStream.Write(xsltObject, 0, 0);
                    //fileStream.

                    //using (var stream = new FileStream(xsltObject))
                    //{
                    //    stream.Seek(0, SeekOrigin.Begin);

                    //    using (var reader = new StreamReader(stream))
                    //    {

                    //        xslt = reader.ReadToEnd();

                    //        //xslt = xslt.Replace("n1:Invoice", "Invoice");

                    //        XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
                    //        using (MemoryStream mstr = new MemoryStream())
                    //        {
                    //            serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                    //            string xml = Encoding.UTF8.GetString(mstr.ToArray());
                    //            webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
                    //        }
                    //    }
                    //}


                    using (var stream = new MemoryStream(xsltObject))
                    {
                        stream.Seek(0, SeekOrigin.Begin);

                        using (var reader = new StreamReader(stream))
                        {

                            xslt = reader.ReadToEnd();

                            //xslt = xslt.Replace("n1:Invoice", "Invoice");
                            var rootAttribute = new XmlRootAttribute("Invoice")
                            {
                                Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                                IsNullable = false
                            };

                            XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType),rootAttribute);
                            using (MemoryStream mstr = new MemoryStream())
                            {
                                serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                                string xml = Encoding.UTF8.GetString(mstr.ToArray());
                                webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xslt Dosyası Bulunamadı");
                }
            }
            else
            {
               
                MessageBox.Show("Varsayılan Xslt üzerinden görüntüleme yapılacak");
                xslt =  Properties.Resources.XSLTFile;
                var rootAttribute = new XmlRootAttribute("Invoice")
                {
                    Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                    IsNullable = false
                };

                XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType),rootAttribute);
                using (MemoryStream mstr = new MemoryStream())
                {
                    serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                    string xml = Encoding.UTF8.GetString(mstr.ToArray());
                    webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
                }

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata?"+ex.Message);
            }
        }

        public void ShowInvoiceWithCustomXslt(InvoiceType invoice,string xslt)
        {
            var rootAttribute = new XmlRootAttribute("Invoice")
            {
                Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                IsNullable = false
            };

             XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType),rootAttribute);
             using (MemoryStream mstr = new MemoryStream())
            {
                serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                string xml = Encoding.UTF8.GetString(mstr.ToArray());
                webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
            }
                        
             
        }

        //Bu metot verilen xml ve xslt parametrelerini kullanarak html transformu sağlar. 
        public static string TransformXMLToHTML(string inputXml, string xsltString)
        {
            StringWriter results = null;
            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(new StringReader(xsltString)))
            {
                try
                {
                    transform.Load(reader);
                     results = new StringWriter();
                     using (XmlReader reader2 = XmlReader.Create(new StringReader(inputXml)))
                    {
                        transform.Transform(reader2, null, results);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(" HTML dönüşümü başarısız: {0}", ex.Message));
                  
                }
               
            }
            if (results!=null)
            {
                return results.ToString();
            }
            else
            {
                return null;
            }
           
         
        }

       
        //XML serialization sırasında namespace'lerin doğru yapılabilmesi için namespace tanımlamaları
        private static XmlSerializerNamespaces _InvoiceNamespaces;
        public static XmlSerializerNamespaces InvoiceNamespaces
        {
            get
            {
                if (_InvoiceNamespaces == null)
                {
                    _InvoiceNamespaces = new XmlSerializerNamespaces();
                    _InvoiceNamespaces.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
                    _InvoiceNamespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                    _InvoiceNamespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                    _InvoiceNamespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                    _InvoiceNamespaces.Add("cctc", "urn:un:unece:uncefact:documentation:2");
                    _InvoiceNamespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
                    _InvoiceNamespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                    _InvoiceNamespaces.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
                    _InvoiceNamespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
                    _InvoiceNamespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
                    _InvoiceNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                }
                return _InvoiceNamespaces;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintHelpPage();  
            
        }

        private void PrintHelpPage()
        {
            // Create a WebBrowser instance. 
            WebBrowser webBrowserForPrinting = new WebBrowser();

            // Add an event handler that prints the document after it loads.
            webBrowserForPrinting.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(PrintDocument);

            //// Set the Url property to load the document.
            //webBrowserForPrinting.Url = new Uri(@"\\myshare\help.html");
        }

        private void PrintDocument(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            // Print the document now that it is fully loaded.
            ((WebBrowser)sender).Print();

            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
        }

        private void btnDownloadAllListedInvoiceXmls_Click(object sender, EventArgs e)
        {
            try
            {
                var client = InvoiceTasks.Instance.CreateClient();
                List<string> invoiceIds = new List<string>();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    var uuid = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    invoiceIds.Add(uuid);
                }

                var repsonse = client.GetInboxInvoicesAsync(new InboxInvoiceQueryModel { InvoiceIds = invoiceIds.ToArray(), PageIndex = 0, PageSize = 1 }).Result;
                if (repsonse.IsSucceded)
                {
                        
                }
                else
                {
                    MessageBox.Show(repsonse.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message) ;
            }
            

        }

        public bool SaveInboxInvoiceXmlfromObject(InvoiceType invoice)
        {
            try
            {
                var path = Path.Combine(Environment.SpecialFolder.Desktop.ToString(), "DownloadedXmls");
                var xml = "";
                string fileName = string.Format("{0}.xml", invoice.UUID.Value.ToString());

                string fullName = Path.Combine(path, fileName);
                var rootAttribute = new XmlRootAttribute("Invoice")
                {
                    Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                    IsNullable = false
                };
                XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType),rootAttribute);
                using (MemoryStream mstr = new MemoryStream())
                {
                    serializer.Serialize(mstr, invoice, InvoiceNamespaces);
                    //serializer.Serialize(mstr, invoice);
                    xml = Encoding.UTF8.GetString(mstr.ToArray());
                }

                File.WriteAllText(fullName, xml);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void frmInvoiceViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
