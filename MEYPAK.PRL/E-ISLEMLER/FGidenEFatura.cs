﻿using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Map.Native;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout.Customization.Templates;
using DevExpress.XtraRichEdit;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.EIslemler;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.EFatura;
using MEYPAK.PRL.SIPARIS;
using Newtonsoft.Json;
using RestSharp;
using ServiceReference1;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class FGidenEFatura : Form
    {
        public FGidenEFatura()
        {
            InitializeComponent();
            faturaServis = new GenericWebServis<PocoFATURA>();
            cariServis = new GenericWebServis<PocoCARIKART>();
            faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
            stokServis = new GenericWebServis<PocoSTOK>();
            stokMarkaServis = new GenericWebServis<PocoSTOKMARKA>();
            gidenFaturalarServis = new GenericWebServis<PocoGIDENFATURA>();
            faturaStokOlcuBrServis = new GenericWebServis<PocoFATURASTOKOLCUBR>();
            olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            faturaBasim = new FaturaBasim();
            efaturaParamsServis = new GenericWebServis<PocoEFATURAPARAMS>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _aracServis = new GenericWebServis<PocoARAC>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            stokKasaMarka = new GenericWebServis<PocoSTOKKASAMARKA>();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();

        }
        GenericWebServis<PocoCARIKART> cariServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
        GenericWebServis<PocoFATURA> faturaServis;
        GenericWebServis<PocoFATURADETAY> faturaDetayServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKMARKA> stokMarkaServis;
        GenericWebServis<PocoGIDENFATURA> gidenFaturalarServis;
        GenericWebServis<PocoOLCUBR> olcuBrServis;
        GenericWebServis<PocoIRSALIYE> irsaliyeServis;
        GenericWebServis<PocoARAC> _aracServis;
        GenericWebServis<PocoEFATURAPARAMS> efaturaParamsServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> stokKasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> stokKasaMarka;
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        List<EFaturaGidenTask> tempFatura;
        PocoFATURA fattemp;
        PocoCARIKART caritemp;
        PocoFATURADETAY[] fatDetaytemp; //bir faturanın birden fazla kalemi olabilir, dizi tanımlaması yapılır
        PocoSTOK tempStok;
        PocoSTOKMARKA tempStokMarka;
        RepositoryItemLookUpEdit riLookup, riLookup2;
        FaturaBasim faturaBasim;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gidenFaturalarServis.Data(ServisList.GidenFaturalarListeServis);
            faturaServis.Data(ServisList.FaturaListeServis);
            cariServis.Data(ServisList.CariListeServis);
            var client = CreateClient();
            List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
            var ccf = faturaServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE", ETTNO = gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).Count() > 0 ? gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).FirstOrDefault().ettno : "" }).ToList();
            foreach (var item in ccf)
            {

                try
                {
                    var response = client.IsEInvoiceUserAsync(item.VKNTCK, "").Result;
                    if (response.Value)
                    {
                        eFaturaList.Add(item);
                    }

                }
                catch (Exception ex)
                {

                }
            }
            gridControl1.DataSource = eFaturaList;
            gridControl1.RefreshDataSource();
        }

        private void FGidenEFatura_Load(object sender, EventArgs e)
        {
            main = (Main)Application.OpenForms["main"];
            _aracServis.Data(ServisList.AracListeServis);
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            faturaServis.Data(ServisList.FaturaListeServis);
            cariServis.Data(ServisList.CariListeServis);
            faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            gidenFaturalarServis.Data(ServisList.GidenFaturalarListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);

            var client = CreateClient();
            var response2 = new InvoiceStatusResponse();
            var status = new InvoiceStatus();
            List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
            var ccf = faturaServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE", ETTNO = gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).Count() > 0 ? gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).FirstOrDefault().ettno : "" }).ToList();
            foreach (var item in ccf)
            {

                try
                {
                    var response = client.IsEInvoiceUserAsync(item.VKNTCK, "").Result;
                    if (response.Value)
                    {
                        eFaturaList.Add(item);



                        var statusCode = 0;

                        //var res1 = client.GetInboxInvoiceList(new InboxInvoiceListQueryModel { InvoiceIds = new string[] { txtSampleGuid.Text } });

                        var guid = new String[] { item.ETTNO };
                        try
                        {
                            //response = client.QueryInboxInvoiceStatus(guid);
                            //response.Value[0].

                            response2 = client.QueryOutboxInvoiceStatusAsync(guid).Result;

                            if (response2.Value != null)
                            {
                                status = response2.Value[0].Status;
                                statusCode = response2.Value[0].StatusCode;
                                item.DURUM = status.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            //  MessageBox.Show(ex.Message, "Hata"); 
                        }
                    }




                }
                catch (Exception ex)
                {

                }
            }

            gridControl1.DataSource = eFaturaList;

            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Faturalaştır";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick1;

            RepositoryItemButtonEdit repositoryItemButtonEdit2 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit2.NullText = "";
            repositoryItemButtonEdit2.NullValuePrompt = "";
            repositoryItemButtonEdit2.Buttons[0].Caption = "Basım";
            repositoryItemButtonEdit2.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit2.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            //TICARIFATURA
            //TEMELFATURA
            //IHRACAT
            //YOLCUBERABERFATURA


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("TIPLER", typeof(string));

            dt.Rows.Add(1, "TICARIFATURA");
            dt.Rows.Add(2, "TEMELFATURA");
            dt.Rows.Add(3, "IHRACAT");
            dt.Rows.Add(4, "YOLCUBERABERFATURA");
            dt.Rows.Add(4, "HKS");

            riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = dt;
            riLookup.ValueMember = "TIPLER";
            riLookup.DisplayMember = "TIPLER";
            riLookup.NullText = "Sec";

            riLookup.HotTrackItems = true;
            riLookup.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = dt.Rows.Count;
            riLookup.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup.AutoSearchColumnIndex = 1;
            riLookup.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup.GetDataSourceRowByKeyValue(0);
            riLookup.EditValueChanged += RiLookup_EditValueChanged;


            //SATIS
            //IADE
            //ISTISNA
            //TEVKIFAT
            //OZELMATRAH
            //IHRACKAYITLI
            //SGK

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("ID", typeof(string));
            dt1.Columns.Add("TIPLER", typeof(string));
            dt1.Rows.Add(1, "SATIS");
            dt1.Rows.Add(1, "IADE");
            dt1.Rows.Add(1, "ISTISNA");
            dt1.Rows.Add(1, "TEVKIFAT");
            dt1.Rows.Add(1, "OZELMATRAH");
            dt1.Rows.Add(1, "IHRACKAYITLI");
            dt1.Rows.Add(1, "SGK");

            riLookup2 = new RepositoryItemLookUpEdit();
            riLookup2.DataSource = dt1;
            riLookup2.ValueMember = "TIPLER";
            riLookup2.DisplayMember = "TIPLER";

            riLookup2.NullText = "Sec";

            riLookup2.HotTrackItems = true;
            riLookup2.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup2.DropDownRows = dt.Rows.Count;
            riLookup2.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup2.AutoSearchColumnIndex = 1;
            riLookup2.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup2.GetDataSourceRowByKeyValue(0);
            riLookup2.EditValueChanged += RiLookup2_EditValueChanged;

            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["BASIM"].ColumnEdit = repositoryItemButtonEdit2;
            gridView1.Columns["FATURATIP"].ColumnEdit = riLookup;
            gridView1.Columns["TIP"].ColumnEdit = riLookup2;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["VKNTCK"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["CARIADI"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["BELGENO"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["TARIH"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["VADETARIHI"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["TUTAR"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["KDV"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["DURUM"].OptionsColumn.AllowEdit = false;
            gridView1.Columns["ETTNO"].OptionsColumn.AllowEdit = false;

        }

        private void RiLookup2_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup2.GetDataSourceRowByDisplayValue(riLookup2.Name);
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }
        public String CreateXmlFromInvoice(InvoiceType invoice)
        {
            var rootAttribute = new XmlRootAttribute("Invoice")
            {
                Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                IsNullable = false
            };
            XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType), rootAttribute);
            using (MemoryStream mstr = new MemoryStream())
            {
                serializer.Serialize(mstr, invoice, InvoiceNamespaces);
                //serializer.Serialize(mstr, invoice);
                return Encoding.UTF8.GetString(mstr.ToArray());
            }
        }
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

        public void SaveXml(InvoiceType invoice)
        {
            string xml = CreateXmlFromInvoice(invoice);
            using (FolderBrowserDialog sf = new FolderBrowserDialog())
            {
                sf.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (sf.ShowDialog() != DialogResult.OK)
                    return;

                string path = sf.SelectedPath;

                string fileName = string.Format("{0}.xml", invoice.UUID.Value.ToString());

                string fullName = Path.Combine(path, fileName);

                File.WriteAllText(fullName, xml);
            }
        }
        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var invoiceInfo = CreateInvoice();
            ShowInvoice(invoiceInfo.Invoice);
        }
        public string ShowInvoiceWithCustomXslt(InvoiceType invoice, string xslt)
        {
            var rootAttribute = new XmlRootAttribute("Invoice")
            {
                Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",
                IsNullable = false
            };

            XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType), rootAttribute);
            using (MemoryStream mstr = new MemoryStream())
            {
                serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                string xml = Encoding.UTF8.GetString(mstr.ToArray());
                var teemmp = TransformXMLToHTML(xml, xslt);
                return teemmp;
            }


        }
        public void ShowInvoice(InvoiceType invoice)
        {
            try
            {
                InvoiceType invoics = invoice;

                string xmll = ShowInvoiceWithCustomXslt(invoics, Properties.Resources.SatfatUBL);
                File.WriteAllText("output.html", xmll.ToString(), Encoding.UTF8);

                var p = new Process();
                p.StartInfo = new ProcessStartInfo(Application.StartupPath + "output.html")
                {
                    UseShellExecute = true
                };
                p.Start();
                MessageBox.Show("Belge Oluşturuldu..");

                // faturaBasim.TemelFaturaBasim(faturaServis.obje.Where(x => x.belgeno == gridView1.GetFocusedRowCellValue("BELGENO")).FirstOrDefault().id);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata?" + ex.Message);
            }
        }
        Main main;
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
                    string ss = "";
                    string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
                    if (inputXml.StartsWith(_byteOrderMarkUtf8))
                    {
                        inputXml = inputXml.Remove(0, _byteOrderMarkUtf8.Length);
                    }
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
            if (results != null)
            {
                return results.ToString();
            }
            else
            {
                return null;
            }


        }


        //XML serialization sırasında namespace'lerin doğru yapılabilmesi için namespace tanımlamaları
        PocoIRSALIYE irstemp;
        GenericWebServis<PocoFATURASTOKOLCUBR> faturaStokOlcuBrServis;
        #region Metotlar
        public InvoiceInfo CreateInvoice()
        {
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            efaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
            faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            EFaturaGidenTask eFaturaGidenTask = (EFaturaGidenTask)gridView1.GetFocusedRow();
            fattemp = faturaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            caritemp = cariServis.obje.Where(x => x.id == fattemp.cariid).FirstOrDefault();
            fatDetaytemp = faturaDetayServis.obje.Where(x => x.faturaid == fattemp.id).ToArray();
            var ccc = faturaDetayServis.obje.Where(x => x.faturaid == fattemp.id);
            irstemp = irsaliyeServis.obje.Where(x => x.id == fattemp.irsaliyeid).FirstOrDefault();
            DocumentReferenceType[] irsfat = new DocumentReferenceType[1];
            if (irstemp != null)
                irsfat = new DocumentReferenceType[] { new DocumentReferenceType() { IssueDate = new IssueDateType { Value = DateTime.Now }, DocumentType = new DocumentTypeType { Value = "Irsaliye" }, ID = new IDType { Value = irstemp.belgeno } } };



            InvoiceLineType[] ınvoiceLineType = new InvoiceLineType[ccc.Count()];
            //Fatura Satır 1
            //},


            for (int i = 0; i < faturaDetayServis.obje.Where(x => x.faturaid == fattemp.id).Count(); i++)
            {

                tempStok = stokServis.obje.Where(x => x.id == fatDetaytemp[i].stokid).FirstOrDefault();
                tempStokMarka = stokMarkaServis.obje.Where(x => x.id == tempStok.markaid).FirstOrDefault();
                ınvoiceLineType[i] = new InvoiceLineType();
                ınvoiceLineType[i].Item = new ItemType
                {
                    Name = new NameType1 { Value = tempStok.adi },
                    BrandName = new BrandNameType { Value = tempStokMarka.adi },
                    BuyersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "" } },
                    ModelName = new ModelNameType { Value = "" },
                    Description = new DescriptionType { Value = fatDetaytemp[i].aciklama },
                    ManufacturersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "" } },
                    SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = tempStok.kod } },


                };
                ınvoiceLineType[i].AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=false }, Amount = new AmountType2 { currencyID="TRY",Value=fatDetaytemp[i].iskontO1 },    },
                    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=false }, Amount = new AmountType2 { currencyID="TRY",Value=fatDetaytemp[i].iskontO2 },    },
                    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=false }, Amount = new AmountType2 { currencyID="TRY",Value=fatDetaytemp[i].iskontO3 },    },
                };
                var tempstokkasahar = _stokKasaHarServis.obje.Where(x => x.faturaid == fattemp.id).ToList();
                string kasamik = "";
                if (tempstokkasahar.Count > 0)
                    if (tempstokkasahar[i].miktar != null)
                        kasamik = tempstokkasahar[i].miktar.ToString();

                int genislik = 56; // belirli genişlik
                int nokta1 = 1; // ilk nokta
                int nokta2 = 12; // ikinci nokta
                int nokta3 = 32; // ikinci nokta
                int nokta4 = 42; // ikinci nokta 

                string deger1 = "M";
                deger1 += kasamik.Replace(',', '.');// ilk değer 
                string deger2 = olcuBrServis.obje.Where(z => z.id == fatDetaytemp[i].birimid).FirstOrDefault().adi.ToLower() != "adet" ? fatDetaytemp[i].darali.ToString().Replace(',', '.') : "";
                string deger3 = olcuBrServis.obje.Where(z => z.id == fatDetaytemp[i].birimid).FirstOrDefault().adi.ToLower() != "adet" ? fatDetaytemp[i].safi.ToString().Replace(',', '.') : "";
                string deger4 = faturaStokOlcuBrServis.obje.Where(z => z.olcubrid == fatDetaytemp[i].birimid).FirstOrDefault().kisa;


                decimal kdvtut = fatDetaytemp[i].kdvtutari;
                string formatliDeger = deger1.PadRight(nokta2 - nokta1, ' ')
        + deger2.PadRight(nokta3 - nokta2, ' ')
        + deger3.PadRight(nokta4 - nokta3, ' ')
        + deger4.PadRight(genislik - nokta4, ' ');

                ınvoiceLineType[i].Item.AdditionalItemIdentification = new ItemIdentificationType[]
                {
                    new ItemIdentificationType(){
                     ID=new IDType()
                     {
                         schemeID="EXTVALUE",
                          Value=formatliDeger ,
                     }

                    },
                        new ItemIdentificationType()
                                 {
                                     ID = new IDType()
                                     {
                                          schemeID="KUNYENO",
                                           Value=fatDetaytemp[i].kunye
                                     }
                                 }

                };
                ınvoiceLineType[i].Price = new PriceType { PriceAmount = new PriceAmountType { Value = Convert.ToDecimal(fatDetaytemp[i].netfiyat), currencyID = "TRY" } };
                ınvoiceLineType[i].InvoicedQuantity = new InvoicedQuantityType { unitCode = faturaStokOlcuBrServis.obje.Where(x => x.olcubrid == fatDetaytemp[i].birimid).FirstOrDefault().kisa, Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].safi), 2) };
                ınvoiceLineType[i].Note = new NoteType[] { new NoteType { Value = fatDetaytemp[i].aciklama } };
                ınvoiceLineType[i].ID = new IDType { Value = (i + 1).ToString() };
                ınvoiceLineType[i].LineExtensionAmount = new LineExtensionAmountType { Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].bruttoplam), 2), currencyID = "TRY" };
                ınvoiceLineType[i].TaxTotal = new TaxTotalType
                {
                    TaxSubtotal = new TaxSubtotalType[]{ 
                      //Vergi 1 KDV
                      new TaxSubtotalType{

                                 Percent = new PercentType1 { Value=Convert.ToDecimal(fatDetaytemp[i].kdv) } ,             
                                                                                                    //Percent =   //new PercentType{ Value=Math.Round(Convert.ToDecimal(txtKdvOrani1.Text),2)},
                              TaxCategory = new TaxCategoryType{TaxScheme = new TaxSchemeType{ TaxTypeCode = new TaxTypeCodeType{  Value = "0015"}, Name =new NameType1{ Value="KDV"} }, TaxExemptionReason=new TaxExemptionReasonType{ Value="12345 sayılı kanuna istinaden" }},
                              TaxAmount = new TaxAmountType{ Value = kdvtut, currencyID= "TRY" },


                   }
                   },
                    TaxAmount = new TaxAmountType { Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].kdvtutari), 2), currencyID = "TRY" }

                };
                ınvoiceLineType[i].Note = new NoteType[] { new NoteType() { Value = "" } };
            }




            var ttt = fatDetaytemp.GroupBy(x => new { x.kdv, x.kdvtutari });
            TaxTotalType[] taxTotalTypes;
            decimal kdv1 = 0, kdv8 = 0, kdv18 = 0;
            int kdvorani = 0;
            for (int i = 0; i < fatDetaytemp.Count(); i++)
            {
                if (fatDetaytemp[i].kdv == 1)
                {
                    kdv1 += fatDetaytemp[i].kdvtutari;
                    kdvorani = 1;
                }
                if (fatDetaytemp[i].kdv == 8)
                {
                    kdv8 += fatDetaytemp[i].kdvtutari;
                    kdvorani = 8;
                }
                if (fatDetaytemp[i].kdv == 18)
                {
                    kdv18 += fatDetaytemp[i].kdvtutari;
                    kdvorani = 18;
                }
            }
            taxTotalTypes = new TaxTotalType[]{
                    new  TaxTotalType{
                                                                     TaxSubtotal = new TaxSubtotalType[]{  new  TaxSubtotalType{
                      Percent = new PercentType1{ Value=Math.Round(Convert.ToDecimal(kdvorani),2)},
                       TaxCategory = new TaxCategoryType{
                           TaxScheme = new TaxSchemeType{
                               TaxTypeCode = new TaxTypeCodeType{  Value = "0015"},
                               Name =new NameType1{ Value="KDV"} },
                              //TaxExemptionReason = new TaxExemptionReasonType { Value="11/1-a Mal ihracatı" },
                              // TaxExemptionReasonCode= new TaxExemptionReasonCodeType { Value= "301" }
                               
                       },

                        TaxAmount = new TaxAmountType{ Value =Math.Round(Convert.ToDecimal(kdv1+kdv8+kdv18),2), currencyID= "TRY" },


                      },



                                                                                                            },

                                                                             TaxAmount = new TaxAmountType{ Value =Math.Round(Convert.ToDecimal(kdv1+kdv8+kdv18),2), currencyID= "TRY" },

                                                                    }

                };

            var invoice = new InvoiceType
            {
                #region Genel Fatura Bilgileri
                ProfileID = new ProfileIDType { Value = eFaturaGidenTask.FATURATIP },
                CopyIndicator = new CopyIndicatorType { Value = false },
                CustomizationID = new CustomizationIDType() { Value = "TR1.2" },
                UUID = new UUIDType { Value = Guid.NewGuid().ToString() }, //Set edilmediğinde sistem tarafından otomatik verilir. 
                IssueDate = new IssueDateType { Value = DateTime.Now },
                IssueTime = new IssueTimeType { Value = DateTime.Now },
                InvoiceTypeCode = new InvoiceTypeCodeType { Value = eFaturaGidenTask.TIP },
                Note = new NoteType[] { new NoteType { Value = _cariAltHesServis.obje.Where(x => x.id == fattemp.althesapid).FirstOrDefault().adi }, new NoteType { Value = " " } },
                DocumentCurrencyCode = new DocumentCurrencyCodeType { Value = "TRY" },
                PricingCurrencyCode = new PricingCurrencyCodeType { Value = "TRY" },
                LineCountNumeric = new LineCountNumericType { Value = 2 },
                //PaymentTerms = new PaymentTermsType { Note = new NoteType { Value = "30 gün vadeli" }, Amount = new AmountType1 { Value = 100, currencyID = "TRY" } },
                PaymentMeans = new PaymentMeansType[] {  new PaymentMeansType { PaymentDueDate = new PaymentDueDateType { Value = fattemp.vadetarihi }, PaymentMeansCode = new PaymentMeansCodeType { Value = "42" }, PayeeFinancialAccount= new FinancialAccountType(){ ID=new IDType(){
                 Value="TR630006400000142441014980"},
                 CurrencyCode= new CurrencyCodeType(){ Value="TRY" },
                    FinancialInstitutionBranch=new BranchType(){
                        FinancialInstitution=new FinancialInstitutionType()
                        {
                            Name=new NameType1()
                            {
                            Value="TÜRKİYE İŞ BANKASI A.Ş."
                            }
                        }
                 } } } },
                AllowanceCharge = new AllowanceChargeType[]
                {
                  new  AllowanceChargeType(){
                      ChargeIndicator= new ChargeIndicatorType()
                      {
                           Value= false
                      },
                       AllowanceChargeReason=new AllowanceChargeReasonType()
                       {
                            Value="İskonto(%"+((fattemp.iskontotoplam*100)/fattemp.bruttoplam).ToString().Replace(',','.')+")"
                       },
                        MultiplierFactorNumeric= new MultiplierFactorNumericType()
                        {
                             Value= ((fattemp.iskontotoplam * 100)/ fattemp.bruttoplam)
                        },
                         Amount=new AmountType2()
                         {
                              Value= fattemp.iskontotoplam
                         }
                    }
                },
                //Delivery = new DeliveryType { DeliveryParty = new PartyType { };
                // PricingExchangeRate = new ExchangeRateType{ SourceCurrencyCode= "TRY",}
                #endregion

                #region SGK fatura alanları
                AccountingCost = null,
                InvoicePeriod = new PeriodType { StartDate = new StartDateType { Value = DateTime.Now }, EndDate = new EndDateType { Value = DateTime.Now } },
                #endregion


                ////AllowanceCharge = new AllowanceChargeType[]
                ////{
                ////    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=true }, Amount = new AmountType2 { currencyID="TRY",Value=100 }, AllowanceChargeReason = new AllowanceChargeReasonType { Value= "Bayi İskontosu" },   }
                ////},

                //  BillingReference = new BillingReferenceType {   BillingReferenceLine = new BillingReferenceLineType[] { new BillingReferenceLineType {  } } }

                // AllowanceCharge = new AllowanceChargeType[] { new AllowanceChargeType { AllowanceChargeReason="Sigorta", ChargeIndicator = true },  }

                #region İrsaliye Bilgileri
                //Irsaliye dosyasi               

                //DespatchDocumentReference = new DocumentReferenceType[]{ new DocumentReferenceType{IssueDate= new IssueDateType{ Value=DateTime.Now},  DocumentType= new DocumentTypeType{  Value = "Irsaliye" }, ID= new IDType{Value="IRS000000001"}},
                //                                                         new DocumentReferenceType{IssueDate= new IssueDateType{ Value=DateTime.Now},  DocumentType= new DocumentTypeType{  Value = "Irsaliye" }, ID= new IDType{Value="IRS000000002"}}},
                DespatchDocumentReference = irsfat,
                #endregion

                #region Xslt ve Ek belgeler
                // Fatura içerisinde görünüm dosyasını set etme.Değer geçilmediğinde varsayılan xslt kullanılır.
                AdditionalDocumentReference = GetXsltAndDocuments(),

                //AdditionalDocumentReference = new DocumentReferenceType[] { new DocumentReferenceType { DocumentType = new DocumentTypeType { Value = "SATINALAMA BELGESİ" }, IssueDate = new IssueDateType { Value = DateTime.Now }, ID = new IDType { Value = "12345" } } },
                #endregion


                //#region Additional Document Reference
                //new DocumentReferenceType[]{
                //    new  DocumentReferenceType {
                //    ID = new IDType{ Value = new Guid().ToString()},
                //    IssueDate = new IssueDateType{ Value = DateTime.Now},
                //    Attachment= new AttachmentType{ 
                //                                    EmbeddedDocumentBinaryObject= new EmbeddedDocumentBinaryObjectType{ 
                //filename="customxslt.xslt", 
                //encodingCode= "Base64",
                //mimeCode= BinaryObjectMimeCodeContentType.applicationxml,
                //format="", 
                //characterSetCode="UTF-8",
                //Value = Encoding.UTF8.GetBytes(Properties.Resources.xslt) }}},


                // },
                //#endregion

                //#region Order Document Reference
                //OrderReference = GetOrderReference(),
                //#endregion

                #region Fatura Seri ve numarası
                ID = new IDType { Value = fattemp.serino + fattemp.belgeno }, //Set edilmediğinde sistem tarafından otomatik verilir. 
                #endregion

                #region Gönderici Bilgileri - AccountingSupplierParty

                AccountingSupplierParty = new SupplierPartyType
                {

                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().unvan } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType() { ID = new IDType { Value = efaturaParamsServis.obje.Where(x=>x.depoid== main.DEPOID).FirstOrDefault().vno, schemeID = "VKN" } }, new PartyIdentificationType() { ID = new IDType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().mersisno, schemeID = "MERSISNO" } }, new PartyIdentificationType() { ID = new IDType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ticsicilno, schemeID = "TICARETSICILNO" } } },

                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().il },
                            StreetName = new StreetNameType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().sokak },
                            Country = new CountryType { Name = new NameType1 { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ulke } },
                            Room = new RoomType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().daireno },
                            BuildingNumber = new BuildingNumberType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().aptno },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ilce },
                        },
                        //PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType() { ID = new IDType { Value = "77777777701", schemeID = "TCKN" } } },
                        // Person = new PersonType{ FirstName= new FirstNameType{ Value="Ahmet"}, FamilyName= new FamilyNameType{ Value="Altınordu"} },
                        //PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = "Esenler" } } },
                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().vd } } },

                    }
                },
                #endregion


                AccountingCustomerParty = GetAccountingCustomerParty(),
                //BuyerCustomerParty = GetBuyerCustomerParty(),
                //TaxRepresentativeParty = GetTaxRepresantiveParty(),

                #region Fatura Satırları - InvoiceLines
                //Fatura Satırları  //Fatura Detay
                InvoiceLine = ınvoiceLineType, //GetInvoiceLines(),

                #endregion

                #region Vergi Alt Toplamları - TaxTotal

                //Fatura Genel KDV 
                TaxTotal = taxTotalTypes,
                #endregion

                #region Tevkifatlar

                // WithholdingTaxTotal = new TaxTotalType[] { new TaxTotalTy pe { TaxSubtotal,taxamo     } }

                #endregion

                #region Yasal Alt Toplamlar - Legal Monetary Total

                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new LineExtensionAmountType { Value = fattemp.bruttoplam, currencyID = "TRY" },
                    TaxExclusiveAmount = new TaxExclusiveAmountType { Value = fattemp.nettoplam, currencyID = "TRY" },
                    TaxInclusiveAmount = new TaxInclusiveAmountType { Value = fattemp.geneltoplam, currencyID = "TRY" },
                    AllowanceTotalAmount = new AllowanceTotalAmountType { Value = fattemp.iskontotoplam, currencyID = "TRY" },
                    //-+    ChargeTotalAmount = new ChargeTotalAmountType { Value = Convert.ToDecimal(txtIskontoTutar1.Text) + Convert.ToDecimal(txtIskontoTutar2.Text), currencyID = "TRY" },
                    PayableAmount = new PayableAmountType { Value = fattemp.geneltoplam, currencyID = "TRY" },
                    // PayableRoundingAmount = new PayableRoundingAmountType { Value = Convert.ToDecimal(txtToplamTutar1.Text) + Convert.ToDecimal(txtToplamTutar2.Text), currencyID = "TRY" }

                }
                #endregion

            };

            #region e-Arşiv Fatura Bilgileri
            //Bu alanda eğer fatura bir e-arşiv faturası ise doldurulması gereken alanlar doldurulmalıdır.
            EArchiveInvoiceInformation earchiveinfo = new EArchiveInvoiceInformation
            {
                DeliveryType = InvoiceDeliveryType.Electronic,

                //Eğer ilgili fatura bir internet satışına ait ise InternetSalesInfo nesnesinde gerekli değerler dolu olmalıdır. 

            };
            #endregion

            return new InvoiceInfo
            {
                EArchiveInvoiceInfo = earchiveinfo,
                // LocalDocumentId = txtLocalDocumentId.Text,
                Invoice = invoice,
                TargetCustomer = new CustomerInfo { Alias = "" },
                Scenario = InvoiceScenarioChoosen.Automated,
                // ExtraInformation = txtExtraInformation.Text == "" ? null : txtExtraInformation.Text,

                //Notification = new NotificationInformation { 

                //    new MailingInformation { //Birden fazla bilgilendirme yapısı desteklenmiştir. Örneği muhasebeciye attachment olan diğer kişilere link olan mail gönderimi yapılmak istenirse yeni bir instance oluşturulup farklı gönderimler yapılabilir. 
                //    EnableNotification = true, //Mail gönderilecek mi bilgisi? 
                //    Attachment = new MailAttachmentInformation { Xml=true,Pdf=true }, //Mailde attachment olacaksa hangi tipte attachment olacak. 
                //    //EmailAccountIdentifier = "127ADE38-0BCB-4AC3-9830-B30A939AA8E9", //Bu Id canlı sistemde ayrıca sizinle paylaşılacaktır. Bir firmanın 1'den fazla mail sunucusu kullanılaiblir. Hangi sunucu ise o sunucu buradan belirtilecek
                //    To = "faruk.kaygisiz@uyumsoft.com.tr", //mail kime/kimlere gönderilecek
                //   // BodyXsltIdentifier = "C5A2BD86-4054-4387-9499-831AC6B108CA", // Bu Id canlı sistemde bizim tarafımızdan size sağlanacaktır. 
                //    Subject = "1234567689 abone numaranıza ait faturanız" // Mailin Subjecti ne olacak. 

                //    }
                //}

            };

        }
        string b64string = "";
        AdoConnect cc = new AdoConnect();
        public static byte[] ExtractResource(Bitmap image)
        {
            MemoryStream ms = new MemoryStream();

            image.Save(ms, ImageFormat.Png);
            if (ms == null)
                return null;
            byte[] imageByteArray = ms.ToArray(); ;
            return imageByteArray;
        }

        private static string Base64FromByteArray(byte[] image)
        {
            return "base64:" + Convert.ToBase64String(image);
        }
        public DocumentReferenceType[] GetXsltAndDocuments()
        {
            DocumentReferenceType[] docs = new DocumentReferenceType[3];
            //if (chkXsltSet.Checked)
            //{


            //docs[0] = new DocumentReferenceType
            //{
            //    ID = new IDType { Value = new Guid().ToString() },
            //    IssueDate = new IssueDateType { Value = DateTime.Now },
            //    DocumentType = new DocumentTypeType { Value = "123456" },
            //    DocumentTypeCode = new DocumentTypeCodeType { Value = "MUKELLEF_KODU" },
            //    DocumentDescription = new DocumentDescriptionType[] { new DocumentDescriptionType { Value = "Kurum Adı" } },
            //};

            //docs[1] = new DocumentReferenceType
            //{
            //    ID = new IDType { Value = new Guid().ToString() },
            //    IssueDate = new IssueDateType { Value = DateTime.Now },
            //    DocumentType = new DocumentTypeType { Value = "123456" },
            //    DocumentTypeCode = new DocumentTypeCodeType { Value = "MUKELLEF_ADI" },
            //    DocumentDescription = new DocumentDescriptionType[] { new DocumentDescriptionType { Value = "Kurum Kodu" } },
            //};
            //docs[2] = new DocumentReferenceType
            //{
            //    ID = new IDType { Value = new Guid().ToString() },
            //    IssueDate = new IssueDateType { Value = DateTime.Now },
            //    DocumentType = new DocumentTypeType { Value = "123456" },
            //    DocumentTypeCode = new DocumentTypeCodeType { Value = "DOSYA_NO" },
            //    DocumentDescription = new DocumentDescriptionType[] { new DocumentDescriptionType { Value = "DOSYA NO" } },
            //};

            docs[0] = new DocumentReferenceType
            {
                ID = new IDType { Value = new Guid().ToString() },
                IssueDate = new IssueDateType { Value = DateTime.Now },
                DocumentType = new DocumentTypeType { Value = "xslt" },
                Attachment = new AttachmentType
                {
                    EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType
                    {
                        filename = "customxslt.xslt",
                        encodingCode = "Base64",
                        mimeCode = "applicationxml",
                        format = "",
                        characterSetCode = "UTF-8",
                        Value = Encoding.UTF8.GetBytes(Properties.Resources.SatfatUBL)
                    }
                }
            };
            _cariHarServis.Data(ServisList.CariHarListeServis);
            var snc = _cariHarServis.obje.Where(x => x.cariid == caritemp.id).Sum(x => x.borc - x.alacak);
            string kasamikk = "";
            if (_stokKasaHarServis.obje.Where(x => x.faturaid == fattemp.id).Count() > 0)
                kasamikk = _stokKasaHarServis.obje.Where(x => x.faturaid == fattemp.id).Sum(x => x.miktar).ToString();
            string plate = "";
            if (irstemp != null)
                plate = _aracServis.obje.Where(x => x.id == irstemp.aracid).FirstOrDefault().plaka;
            int genislik = 182; // belirli genişlik
            int nokta1 = 1; // ilk nokta
            int nokta2 = 22; // ikinci nokta
            int nokta3 = 32;
            int nokta4 = 42;
            int nokta5 = 52;
            int nokta6 = 172;
            string deger1 = "M" + snc.ToString().Replace(',', '.'); // ilk değer
            string deger2 = "Veresiye";
            string deger3 = kasamikk.Replace(',', '.');
            string deger4 = fatDetaytemp.Where(x => x.birimid != 1).Sum(x => x.safi).ToString().Replace(',', '.');
            string deger5 = plate;
            string deger6 = "H0H";


            string formatliDeger = deger1.PadRight(nokta2 - nokta1, ' ')
    + deger2.PadRight(nokta3 - nokta2, ' ')
    + deger3.PadRight(nokta4 - nokta3, ' ')
    + deger4.PadRight(nokta5 - nokta4, ' ')
    + deger5.PadRight(nokta6 - nokta5, ' ')
    + deger6.PadRight(genislik - nokta6, ' ');


            docs[1] = new DocumentReferenceType()
            {
                ID = new IDType()
                {
                    Value = formatliDeger
                },
                IssueDate = new IssueDateType()
                {
                    Value = DateTime.Now
                },
                DocumentType = new DocumentTypeType() { Value = "EXTVALUE" }
            };
            docs[2] = new DocumentReferenceType()
            {
                ID = new IDType()
                {
                    Value = "Yalnız " + cc.komutoku("SELECT MEYPAKTEST.DBO.GETPARATOYAZI(" + fattemp.geneltoplam.ToString().Replace(',', '.') + ",'1','TL')").Rows[0].ItemArray[0].ToString()
                },
                IssueDate = new IssueDateType()
                {
                    Value = DateTime.Now
                },
                DocumentType = new DocumentTypeType() { Value = "MONEYTEXT" }
            };


            return docs;
            // };


            //if (chkSetInvoiceXslt.Checked)
            //{
            //    DocumentReferenceType doc = new DocumentReferenceType();
            //    //doc.ID = new IDType { Value = new Guid().ToString() };
            //   // doc.IssueDate = new IssueDateType { Value = DateTime.Now };
            //    AttachmentType atc = new AttachmentType { };
            //    EmbeddedDocumentBinaryObjectType emb = new EmbeddedDocumentBinaryObjectType();
            //    emb.filename = "customxslt.xslt";
            //    emb.encodingCode = "Base64";
            //    emb.mimeCode = "applicationxml";
            //    emb.format = "";
            //    emb.characterSetCode = "UTF-8";
            //    emb.Value = Encoding.UTF8.GetBytes(txtInvoiceXslt.Text);

            //    atc.EmbeddedDocumentBinaryObject = emb;
            //    doc.Attachment = atc;
            //    docs[0] = doc;

            //    return docs;
            //}
            //else
            //{
            //    return null;
            //}


        }



        #region Muhasebe Müşteri Tarafı Alın
        public CustomerPartyType GetAccountingCustomerParty()
        {
            CustomerPartyType customer;

            PersonType person = new PersonType { FamilyName = new FamilyNameType { Value = caritemp.soyadi }, FirstName = new FirstNameType { Value = caritemp.unvan.Length > 0 ? caritemp.unvan : caritemp.adi } };

            if (gridView1.GetFocusedRowCellValue("FATURATIP") == "IHRACAT" || gridView1.GetFocusedRowCellValue("FATURATIP") == "YOLCUBERABERFATURA")
            {
                #region Gümrük Ticaret Bakanlığı Bilgileri - AccountingCustomerParty
                customer = new CustomerPartyType
                {

                    Party = new PartyType
                    {

                        PartyName = new PartyNameType { Name = new NameType1 { Value = "GÜMRÜK VE TİCARET BAKANLIĞI BİLGİ İŞLEM DAİRESİ BAŞKANLIĞI" } },
                        PartyIdentification = new PartyIdentificationType[1] { new PartyIdentificationType() { ID = new IDType { Value = "1460415308", schemeID = "VKN" } } },
                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = "Ankara" },
                            StreetName = new StreetNameType { Value = ">Üniversiteler Mahallesi Dumlupınar Bulvar" },
                            Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } },

                            BuildingNumber = new BuildingNumberType { Value = "151" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "Çankaya" }

                        },

                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = "Ulus" } } },

                    }
                };

                #endregion

                return customer;
            }
            else
            {
                #region Alıcı Bilgileri - AccountingCustomerParty
                customer = new CustomerPartyType
                {

                    Party = new PartyType
                    {

                        PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length > 0 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi } },
                        PartyIdentification = new PartyIdentificationType[1] { new PartyIdentificationType() { ID = new IDType { Value = caritemp.vergino.Length > 0 ? caritemp.vergino : caritemp.tcno, schemeID = caritemp.vergino.Length > 0 ? "VKN" : "TCKN" } } },
                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = caritemp.il },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            Country = new CountryType { Name = new NameType1 { Value = caritemp.ulke } },
                            Room = new RoomType { Value = caritemp.daire },
                            BuildingNumber = new BuildingNumberType { Value = caritemp.apt },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce }

                        },
                        Contact = new ContactType { Telefax = new TelefaxType { Value = caritemp.fax }, ElectronicMail = new ElectronicMailType { Value = caritemp.eposta }, Telephone = new TelephoneType { Value = caritemp.telefon } },
                        WebsiteURI = new WebsiteURIType { Value = caritemp.web },
                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = caritemp.vergidairesi } } },
                        Person = caritemp.tcno.Length == 11 ? person : null
                        ,
                        AgentParty = new PartyType()
                        {
                            PartyIdentification = new PartyIdentificationType[]
                             {
                                 new PartyIdentificationType(){
                                  ID=new IDType()
                                  {
                                       schemeID=  "BAYINO",
                                       Value=_cariAltHesServis.obje.Where(x=>x.id== fattemp.althesapid).FirstOrDefault().kod,

                                  }
                                  },
                                  new PartyIdentificationType()
                                  {
                                      ID=new IDType()
                                      {
                                           schemeID="SUBENO",
                                            schemeName=_cariAltHesServis.obje.Where(x=>x.id== fattemp.althesapid).FirstOrDefault().adi,
                                            Value=_cariAltHesServis.obje.Where(x=>x.id== fattemp.althesapid).FirstOrDefault().kod
                                      }
                                  },


                             },
                            PostalAddress = new AddressType()
                            {
                                StreetName = new StreetNameType() { Value = caritemp.sokak },
                                CitySubdivisionName = new CitySubdivisionNameType() { Value = caritemp.ilce },
                                CityName = new CityNameType() { Value = caritemp.il },
                                Country = new CountryType()
                                {
                                    Name = new NameType1() { Value = "Türkiye" }
                                }
                            },
                            PartyName = new PartyNameType() { Name = new NameType1() { Value = caritemp.unvan == "" ? caritemp.adi + " " + caritemp.soyadi : caritemp.unvan } }
                        },


                    }
                };

                #endregion

                return customer;
            }


        }

        #endregion
        public CustomerPartyType GetBuyerCustomerParty()
        {
            CustomerPartyType customer;

            #region İhracatçı Bilgileri - BuyerCustomerParty
            if (gridView1.GetFocusedRowCellValue("FATURATIP") == "IHRACAT")
            {

                customer = new CustomerPartyType
                {

                    Party = new PartyType
                    {

                        PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length > 0 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi } },
                        PartyIdentification = new PartyIdentificationType[1] { new PartyIdentificationType() { ID = new IDType { Value = caritemp.vergino, schemeID = "PARTYTYPE" } } },
                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = caritemp.il },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            Country = new CountryType { Name = new NameType1 { Value = caritemp.ulke } },
                            Room = new RoomType { Value = caritemp.daire },
                            BuildingNumber = new BuildingNumberType { Value = caritemp.apt },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce }

                        },


                        PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType { RegistrationName = new RegistrationNameType { Value = caritemp.unvan }, CompanyID = new CompanyIDType { Value = caritemp.vergino } } },
                        //Contact = new ContactType { Telefax = new TelefaxType { Value = "22111222" }, ElectronicMail = new ElectronicMailType { Value = "test@xyz.com" }, Telephone = new TelephoneType { Value = "0212200022" } },
                        //WebsiteURI = new WebsiteURIType { Value = "Web Sitesi" },

                        //PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = txtAliciVergiDairesi.Text } } },
                        //Person = new PersonType { FirstName = new FirstNameType { Value = "Ahmet" }, FamilyName = new FamilyNameType { Value = "Altınordu" } },
                    }
                };
                return customer;
            }
            #endregion

            #region Turist Bilgileri - BuyerCustomerParty
            if (gridView1.GetFocusedRowCellValue("FATURATIP") == "YOLCUBERABERFATURA")
            {

                customer = new CustomerPartyType
                {

                    Party = new PartyType
                    {

                        Person = new PersonType
                        {
                            FirstName = new FirstNameType { Value = "JOHN" },
                            FamilyName = new FamilyNameType { Value = "DOE" },
                            NationalityID = new NationalityIDType { Value = "TR" },
                            IdentityDocumentReference = new DocumentReferenceType { ID = new IDType { Value = "PSPTNO1234567" }, IssueDate = new IssueDateType { Value = DateTime.Now } }

                        },
                        PartyIdentification = new PartyIdentificationType[1] { new PartyIdentificationType() { ID = new IDType { Value = caritemp.vergino, schemeID = "PARTYTYPE" } } },
                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = caritemp.il },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            Country = new CountryType { Name = new NameType1 { Value = caritemp.ulke } },
                            Room = new RoomType { Value = caritemp.daire },
                            BuildingNumber = new BuildingNumberType { Value = caritemp.apt },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce }

                        },

                        PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType { RegistrationName = new RegistrationNameType { Value = caritemp.unvan.Length > 0 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi }, CompanyID = new CompanyIDType { Value = caritemp.vergino.Length > 0 ? caritemp.vergino : caritemp.tcno } } },
                        //Contact = new ContactType { Telefax = new TelefaxType { Value = "22111222" }, ElectronicMail = new ElectronicMailType { Value = "test@crssoft.com" }, Telephone = new TelephoneType { Value = "0212200022" } },
                        //WebsiteURI = new WebsiteURIType { Value = "Web Sitesi" },

                        //PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = txtAliciVergiDairesi.Text } } },
                        //Person = new PersonType { FirstName = new FirstNameType { Value = "Ahmet" }, FamilyName = new FamilyNameType { Value = "Altınordu" } },
                    }
                };
                return customer;
            }
            #endregion

            else
            {
                return null;
            }

        }

        public PartyType GetTaxRepresantiveParty()
        {
            PartyType customer;

            if (gridView1.GetFocusedRowCellValue("FATURATIP") == "YOLCUBERABERFATURA")
            {


                #region Tax Free Aracı kurum Bilgileri - TaxRepresantiveParty
                customer = new PartyType
                {


                    PartyName = new PartyNameType { Name = new NameType1 { Value = "Tax Free Aracı kurum A.Ş." } },
                    PartyIdentification = new PartyIdentificationType[2] { new PartyIdentificationType() { ID = new IDType { Value = "1234567891", schemeID = "ARACIKURUMVKN" } }, new PartyIdentificationType() { ID = new IDType { Value = "urn:mail:yolcuberaberpk@aracikurum.com", schemeID = "ARACIKURUMETIKET" } } },
                    PostalAddress = new AddressType
                    {
                        CityName = new CityNameType { Value = "İstanbul" },
                        StreetName = new StreetNameType { Value = "Levent Mah. No:1 " },
                        Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } },
                        CitySubdivisionName = new CitySubdivisionNameType { Value = "Şişli" }

                    },



                };
                return customer;
            }
            #endregion

            else
            {
                return null;
            }

        }
        public IntegrationClient CreateClient()
        {
            efaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
            var username = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().kuladi;
            var password = efaturaParamsServis.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().sifre;
            var serviceuri = "https://efatura.uyumsoft.com.tr/services/BasicIntegration";
            //var username = "Uyumsoft";
            //var password = "Uyumsoft";
            //var serviceuri = "https://efatura-test.uyumsoft.com.tr/services/BasicIntegration";


            var client = new IntegrationClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(serviceuri);
            //  var client = new IntegrationClient();
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            //var response = client.IsEInvoiceUser("9000068418",string.Empty);
            return client;
        }
        #endregion
        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity != "BEKLEMEDE")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
        }

        private void loglarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = CreateClient();
            StringBuilder sb = new StringBuilder();
            InvoiceStatusWithLogResponse response = null;

            try
            {
                response = client.GetOutboxInvoiceStatusWithLogsAsync(new string[] { gridView1.GetFocusedRowCellValue("ETTNO").ToString() }).Result;
                if (response.IsSucceded && response.Value != null && response.Value[0].Logs != null && response.Value[0].Logs.Length > 0)
                {
                    for (int i = 0; i < response.Value[0].Logs.Length; i++)
                    {
                        var log = response.Value[0].Logs[i].Message;
                        sb.AppendLine(string.Format("{0} - {1}", i.ToString(), log));

                    }


                    MessageBox.Show(sb.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Hata : {0}", ex.Message));
            }

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {


        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridControl2.DataSource = faturaDetayServis.obje.Where(x => x.faturaid.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).Select(x => new FaturaDetailList()
            {
                ADI = x.stokadi,
                BIRIM = olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi,
                KOD = stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod,
                MIKTAR = x.safi,
                NETFIYAT = x.netfiyat,
                SIRA = x.num,
                TUTAR = x.nettoplam
            }).ToList();
            gridControl2.RefreshDataSource();
        }

        private async void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.EFATURAGIDENKUTUSU.ToString()).EKLE == true)
            {
                var client = CreateClient();

                var invoiceInfo = CreateInvoice();

                InvoiceInfo[] invoices = new InvoiceInfo[1];
                invoices[0] = invoiceInfo;

                var response = await client.SendInvoiceAsync(invoices);
                //InvoiceIdentitiesResponse response = client.SendInvoice(invoices);

                if (response.IsSucceded)
                {

                    MessageBox.Show(
                        string.Format("Fatura Gönderildi\n UUID:{0} \n ID:{1} \n Fatura Tipi:{2} ",
                                response.Value[0].Id.ToString(),
                                response.Value[0].Number.ToString(),
                                response.Value[0].InvoiceScenario.ToString()
                                )
                                );
                    // txtSampleOutboxGuid.Text = response.Value[0].Id.ToString();
                    textBox1.Text = response.Value[0].Id.ToString();
                    // Clipboard.SetText(response.Value[0].Id.ToString());
                    gidenFaturalarServis.Data(ServisList.GidenFaturalarEkleServis, new PocoGIDENFATURA()
                    {
                        belgeno = fattemp.belgeno,
                        durum = 2,
                        ettno = response.Value[0].Id.ToString(),
                        hatakodu = "",
                        tip = 1,
                        tarih = DateTime.Now,
                        userid = MPKullanici.ID,
                        faturaid = fattemp.id

                    });
                    fattemp.durum = true;
                    faturaServis.Data(ServisList.FaturaEkleServis, fattemp);
                    faturaServis.Data(ServisList.FaturaListeServis);

                    List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
                    var ccf = faturaServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "ONAYLANDI" : "BEKLEMEDE", ETTNO = gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).Count() > 0 ? gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).FirstOrDefault().ettno : "" }).ToList();
                    foreach (var item in ccf)
                    {

                        try
                        {
                            var respons = client.IsEInvoiceUserAsync(item.VKNTCK, "").Result;
                            if (respons.Value)
                            {


                                eFaturaList.Add(item);
                            }

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    gridControl1.DataSource = eFaturaList;
                    gridControl1.RefreshDataSource();

                }
                else
                {
                    gidenFaturalarServis.Data(ServisList.GidenFaturalarEkleServis, new PocoGIDENFATURA()
                    {
                        belgeno = fattemp.belgeno,
                        durum = 1,
                        ettno = "",
                        tip = 1,
                        tarih = DateTime.Now,
                        userid = MPKullanici.ID,
                        hatakodu = response.Message,

                    });
                    MessageBox.Show(response.Message);
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }
    }
}
