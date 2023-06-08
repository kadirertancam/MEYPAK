using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using e_İrsaliyeDemo_v1._0._0;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using ServiceReference11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class FGidenEIrsaliye : Form
    {
        public FGidenEIrsaliye()
        {
            InitializeComponent();
            stokMarkaServis = new GenericWebServis<PocoSTOKMARKA>();
            stokServis = new GenericWebServis<PocoSTOK>();
            irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            cariServis = new GenericWebServis<PocoCARIKART>();
            irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            gidenIrsaliyelerServis = new GenericWebServis<PocoGIDENIRSALIYELER>();
            siparisServis = new GenericWebServis<PocoSIPARIS>();
            personelServis = new GenericWebServis<PocoPERSONEL>();
            aracServis = new GenericWebServis<PocoARAC>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            faturaStokOlcuBrServis = new GenericWebServis<PocoFATURASTOKOLCUBR>();
            _faturaParams = new GenericWebServis<PocoEFATURAPARAMS>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            stokKasaMarka = new GenericWebServis<PocoSTOKKASAMARKA>();
        }
        GenericWebServis<PocoCARIKART> cariServis;
        GenericWebServis<PocoIRSALIYE> irsaliyeServis;
        GenericWebServis<PocoIRSALIYEDETAY> irsaliyeDetayServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKMARKA> stokMarkaServis;
        GenericWebServis<PocoGIDENIRSALIYELER> gidenIrsaliyelerServis;
        GenericWebServis<PocoSIPARIS> siparisServis;
        GenericWebServis<PocoPERSONEL> personelServis;
        GenericWebServis<PocoARAC> aracServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoFATURASTOKOLCUBR> faturaStokOlcuBrServis;
        GenericWebServis<PocoEFATURAPARAMS> _faturaParams;
        GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> stokKasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> stokKasaMarka;
        List<EFaturaGidenTask> tempIRSALIYE;
        PocoIRSALIYE irstemp;
        PocoCARIKART caritemp;
        PocoIRSALIYEDETAY[] irsDetaytemp;
        PocoSTOK tempStok;
        PocoSTOKMARKA tempStokMarka;
        RepositoryItemLookUpEdit riLookup, riLookup2;
        Main main;
        private void FGidenEIrsaliye_Load(object sender, EventArgs e)
        {
            main = (Main)Application.OpenForms["Main"];
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            cariServis.Data(ServisList.CariListeServis);
            irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            gidenIrsaliyelerServis.Data(ServisList.GidenIrsaliyelerListeServis);
            personelServis.Data(ServisList.PersonelListeServis);
            aracServis.Data(ServisList.AracListeServis);
            List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
            var ccf = irsaliyeServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.irsaliyetarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELIRSALIYE", TIP = "SATIS", DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE", ETTNO = gidenIrsaliyelerServis.obje.Where(z => z.irsaliyeid == x.id).Count() > 0 ? gidenIrsaliyelerServis.obje.Where(z => z.irsaliyeid == x.id).FirstOrDefault().ettno : "" }).ToList();
           
            faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            gridControl1.DataSource = ccf;

            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Irsaliyeleştir";
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
        }

        public DocumentReferenceType[] GetXsltAndDocuments()
        {
            DocumentReferenceType[] docs = new DocumentReferenceType[4];
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
                DocumentType = new DocumentTypeType { Value = "Xslt" },
                Attachment = new AttachmentType
                {
                    EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType
                    {
                        filename = "SatIrsUBL.xslt",
                        encodingCode = "Base64",
                        mimeCode = "applicationxml",
                        format = "",
                        characterSetCode = "UTF-8",
                        Value = Encoding.UTF8.GetBytes(Properties.Resources.SatIrsUBL)
                    }
                }
            };
            ImageConverter converter = new ImageConverter();
            docs[2] = new DocumentReferenceType
            {
                ID = new IDType { Value = new Guid().ToString() },
                IssueDate = new IssueDateType { Value = DateTime.Now },
                DocumentType = new DocumentTypeType { Value = "Logo" },
                Attachment = new AttachmentType
                {
                    EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType
                    {
                        filename = "139gunduzmeypak150px.jpg",
                        encodingCode = "Base64",
                        mimeCode = "image/jpeg",
                        format = "",
                        characterSetCode = "UTF-8",
                        Value = (byte[])converter.ConvertTo(Properties.Resources._139gunduzmeypak150px, typeof(byte[]))
                    }
                }
            };
            docs[3] = new DocumentReferenceType
            {
                ID = new IDType { Value = new Guid().ToString() },
                IssueDate = new IssueDateType { Value = DateTime.Now },
                DocumentType = new DocumentTypeType { Value = "Kase" },
                Attachment = new AttachmentType
                {
                    EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType
                    {
                        filename = "_139gmeypakkase150px__1_.jpg",
                        encodingCode = "Base64",
                        mimeCode = "image/jpeg",
                        format = "",
                        characterSetCode = "UTF-8",
                        Value = (byte[])converter.ConvertTo(Properties.Resources._139gmeypakkase150px__1_, typeof(byte[]))
                    }
                }
            };
            string kasamik = "";
            if (_stokKasaHarServis.obje.Where(x => x.irsaliyeid == tempirs.id).Count() > 0)
                kasamik = _stokKasaHarServis.obje.Where(x => x.irsaliyeid == tempirs.id).Sum(x => x.miktar).ToString();
            int genislik = 182; // belirli genişlik
            int nokta1 = 1; // ilk nokta
            int nokta2 = 12; // ikinci nokta
            int nokta3 = 42; // ikinci nokta
            int nokta4 = 57; // ikinci nokta 
            string deger1 = "M";
            deger1 += kasamik.Replace(',','.'); // ilk değer
            string deger2 = tempirsdetay.Where(x => x.birimid != 1).Sum(x => x.safi).ToString().Replace(',', '.');
            string deger3 = personelServis.obje.Where(x => x.id == tempirs.personelid).FirstOrDefault().telefon;
            string deger4 = "H0H";


            string formatliDeger = deger1.PadRight(nokta2 - nokta1, ' ')
    + deger2.PadRight(nokta3 - nokta2, ' ')
    + deger3.PadRight(nokta4 - nokta3, ' ')
    + deger4.PadRight(genislik - nokta4, ' ');


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
        List<PocoIRSALIYEDETAY> tempirsdetay;
        PocoIRSALIYE tempirs;

        public DespatchInfo CreateDespatchInfo()
        {
            DespatchInfo despInfo = new DespatchInfo();
            DespatchAdviceType despatch = new DespatchAdviceType();

            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            tempirs = irsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            tempirsdetay = irsaliyeDetayServis.obje.Where(x => x.irsaliyeid == tempirs.id).ToList();
            #region İrsaliye Genel Bilgileri
            //İrsaliye Numarası
            cariServis.Data(ServisList.CariListeServis);
            caritemp = cariServis.obje.Where(x => x.id == tempirs.cariid).FirstOrDefault();
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            siparisServis.Data(ServisList.SiparisListeServis);
            _faturaParams.Data(ServisList.EFaturaParamsListeServis);

            var tempsip = siparisServis.obje.Where(x => x.id == tempirs.siparisid).FirstOrDefault();
            var personel = personelServis.obje.Where(x => x.id == tempirs.personelid).FirstOrDefault();
            despatch.AdditionalDocumentReference = GetXsltAndDocuments();
            despatch.IssueDate = new IssueDateType { Value = DateTime.Now };
            despatch.IssueTime = new IssueTimeType { Value = DateTime.Now };
            despatch.CopyIndicator = new CopyIndicatorType { Value = false };
            despatch.ProfileID = new ProfileIDType { Value = "TEMELIRSALIYE" };
            despatch.DespatchAdviceTypeCode = new DespatchAdviceTypeCodeType { Value = "SEVK" };
            despatch.Note = new NoteType[] { new NoteType { Value = "İş bu sevk irsaliyesi muhteviyatına 7 gün içerisinde itiraz edilmediği taktirde aynen kabul edilmiş sayılır." } };
            despatch.OrderReference = new OrderReferenceType[] { new OrderReferenceType { ID = new IDType { Value = tempsip != null ? tempsip.belgeno : "" }, IssueDate = new IssueDateType { Value = DateTime.Now } } };
            despatch.LineCountNumeric = new LineCountNumericType { Value = 2 };
            #endregion

            var tempstokkasahar = _stokKasaHarServis.obje.Where(x => x.irsaliyeid == tempirs.id).ToList();
            var dplt = new DespatchLineType[tempirsdetay.Count()+ tempstokkasahar.Count()];
            for (int i = 0; i < tempirsdetay.Count(); i++)
            {
                string kasamik = "";
                if (tempstokkasahar[i] != null)
                    if (tempstokkasahar[i].miktar != null)
                        kasamik = tempstokkasahar[i].miktar.ToString();
                int genislik = 65; // belirli genişlik
                int nokta1 = 1; // ilk nokta
                int nokta2 = 12; // ikinci nokta
                int nokta3 = 32; // ikinci nokta
                int nokta4 = 42; // ikinci nokta 
                string deger1 = "M";
                deger1 += kasamik.Replace(',', '.'); // ilk değer 
                string deger2 = _olcuBrServis.obje.Where(z => z.id == tempirsdetay[i].birimid).FirstOrDefault().adi.ToLower() != "adet" ? tempirsdetay[i].darali.ToString().Replace(',', '.') : " ";
                string deger3 = _olcuBrServis.obje.Where(z => z.id == tempirsdetay[i].birimid).FirstOrDefault().adi.ToLower() != "adet" ? tempirsdetay[i].safi.ToString().Replace(',', '.') : " ";
                string deger4 = faturaStokOlcuBrServis.obje.Where(z => z.olcubrid == tempirsdetay[i].birimid).FirstOrDefault().kisa;


                string formatliDeger = deger1.PadRight(nokta2 - nokta1, ' ')
        + deger2.PadRight(nokta3 - nokta2, ' ')
        + deger3.PadRight(nokta4 - nokta3, ' ')
        + deger4.PadRight(genislik - nokta4, ' ');
                dplt[i] =
                    new DespatchLineType
                    {

                        OrderLineReference = new OrderLineReferenceType { LineID = new LineIDType { } },
                        ID = new IDType { Value = (i + 1).ToString() }, 
                        Item = new ItemType
                        {
                            Name = new NameType1 { Value = tempirsdetay[i].stokadi },
                            BrandName = new BrandNameType() { Value = stokMarkaServis.obje.Where(z => z.id == stokServis.obje.Where(x => x.id == tempirsdetay[i].stokid).FirstOrDefault().markaid).FirstOrDefault().adi },
                            BuyersItemIdentification = new ItemIdentificationType()
                            {
                                 ID = new IDType()
                                 {
                                     schemeID= "UrunKodu",
                                     Value = stokServis.obje.Where(x => x.id == tempirsdetay[i].stokid).FirstOrDefault().kod
                                 }
                            },
                           AdditionalItemIdentification=new ItemIdentificationType[]
                           {
                               new ItemIdentificationType(){
                                ID= new IDType() { schemeID= "EXTVALUE",Value= formatliDeger}
                               }
                           }
                           
                        },
                        DeliveredQuantity = new DeliveredQuantityType { Value = tempirsdetay[i].safi, unitCode = "NIU" },
                        OversupplyQuantity = new OversupplyQuantityType { Value = 0, unitCode = "NIU" },
                        OutstandingQuantity = new OutstandingQuantityType { Value = 0, unitCode = "NIU" },
                        OutstandingReason = new OutstandingReasonType[] { new OutstandingReasonType { Value = "Stok Yok" } },
                        Note = new NoteType[] { new NoteType { Value = tempirsdetay[i].aciklama } },

                    };


                #region Shipment
                despatch.Shipment = new ShipmentType
                {   
                    ShipmentStage = new ShipmentStageType[]{
                                     new ShipmentStageType
                                     {
                                         DriverPerson = new PersonType[]{
                                              new PersonType
                                              {
                                                  FirstName = new FirstNameType
                                                  {
                                                      Value = personel.adi
                                                  },
                                                  FamilyName = new FamilyNameType
                                                  {
                                                      Value = personel.soyadi
                                                  },
                                                  NationalityID = new NationalityIDType
                                                  {
                                                       Value = personel.tc
                                                  }

                                              }
                                         },
                                          TransportMeans= new TransportMeansType()
                                          {
                                               RoadTransport=new RoadTransportType()
                                               {
                                                    LicensePlateID= new LicensePlateIDType(){ schemeID="PLAKA", Value= aracServis.obje.Where(x=>x.id==tempirs.aracid).FirstOrDefault().plaka },

                                               }
                                          },


                                     }

                },

                    TransportHandlingUnit = new TransportHandlingUnitType[] {
                                           new TransportHandlingUnitType
                                           {
                                               TransportEquipment = new TransportEquipmentType[]{
                                                                        new TransportEquipmentType
                                                                        {
                                                                          ID = new IDType {Value =aracServis.obje.Where(x=>x.id== tempirs.dorseid).FirstOrDefault().plaka, schemeID="DORSEPLAKA"}
                                                                        }

                                               }

                                           }
                },
                    ID = new IDType { Value = "1" },
                    Delivery = new DeliveryType
                    {
                        ID = new IDType { Value = "1" },
                        Despatch = new DespatchType
                        {
                            ActualDespatchDate = new ActualDespatchDateType
                            {
                                Value = DateTime.Now
                            },
                            ActualDespatchTime = new ActualDespatchTimeType
                            {
                                Value = DateTime.Now
                            }
                        },

                        DeliveryAddress = new AddressType()
                        {
                            CitySubdivisionName = new CitySubdivisionNameType() { Value = caritemp.ilce },
                            CityName = new CityNameType() { Value = caritemp.il },
                            PostalZone = new PostalZoneType() { Value = caritemp.postakod },
                            Region = new RegionType() { Value = caritemp.ilce },
                            District = new DistrictType() { Value = caritemp.ilce },
                            Country = new CountryType() { Name = new NameType1() { Value = caritemp.ulke } }
                        }
                    }
                };
                #endregion
                despatch.SellerSupplierParty = new SupplierPartyType()
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().unvan } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = "VKN", Value = "9000068418" } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = "TÜRKİYE" },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().il
                            },
                            StreetName = new StreetNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().sokak },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ilce },
                            BuildingName = new BuildingNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().aptno },
                            PostalZone = new PostalZoneType() { Value = "06560" },
                            
                        },
                        Contact= new ContactType()
                        {
                            ElectronicMail = new ElectronicMailType() { Value = "mey_pak@hotmail.com" },
                            Telephone = new TelephoneType() { Value = "03123417273" },
                        },
                        PartyTaxScheme = new PartyTaxSchemeType()
                        {
                            TaxScheme = new TaxSchemeType()
                            {
                                Name = new NameType1 { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().vd }
                            }
                        }
                    }
                };
                #region DespatchSupplierParty
                despatch.DespatchSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().unvan } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType() { ID = new IDType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().vno, schemeID = "VKN" } }, new PartyIdentificationType() { ID = new IDType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().mersisno, schemeID = "MERSISNO" } }, new PartyIdentificationType() { ID = new IDType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ticsicilno, schemeID = "TICARETSICILNO" } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = "TÜRKİYE" },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().il
                            },
                            StreetName = new StreetNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().sokak },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().ilce },
                            BuildingName = new BuildingNameType { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().aptno },
                            PostalZone = new PostalZoneType() { Value = caritemp.postakod }
                        },

                        PartyTaxScheme = new PartyTaxSchemeType()
                        {
                            TaxScheme = new TaxSchemeType()
                            {
                                Name = new NameType1 { Value = _faturaParams.obje.Where(x => x.depoid == main.DEPOID).FirstOrDefault().vd }
                            }
                        }
                    }
                };
                #endregion

                #region DeliveryCustomerParty
                despatch.DeliveryCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length > 1 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = caritemp.vergino.Length > 2 ? "VKN" : "TCKN", Value = caritemp.vergino.Length > 2 ? caritemp.vergino : caritemp.tcno } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = caritemp.ulke },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = caritemp.il
                            },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce },
                            BuildingName = new BuildingNameType { Value = caritemp.apt },
                            Room = new RoomType { Value = caritemp.daire }
                        },
                        Contact= new ContactType()
                        {
                             ElectronicMail= new ElectronicMailType()
                             {
                                  Value=caritemp.eposta
                             },
                              Telephone=new TelephoneType()
                              {
                                   Value=caritemp.telefon
                              }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType()
                        {
                            TaxScheme = new TaxSchemeType()
                            {
                                Name = new NameType1()
                                {
                                    Value = caritemp.vergidairesi
                                }
                            }
                        },
                        AgentParty = new PartyType()
                        {
                            PartyIdentification = new PartyIdentificationType[]
                             {
                                new PartyIdentificationType(){
                                  ID=new IDType()
                                  {
                                      schemeID= "SUBENO",
                                       schemeName= _cariAltHesServis.obje.Where(x => x.id == tempirs.althesapid).FirstOrDefault().kod,
                                       Value=_cariAltHesServis.obje.Where(x => x.id == tempirs.althesapid).FirstOrDefault().adi

                                  }, 
                                 }, 
                             },
                             PartyName= new PartyNameType()
                             {
                                  Name= new NameType1()
                                  {
                                       Value=caritemp.unvan==""?caritemp.adi+ " " + caritemp.soyadi:caritemp.unvan
                                  }
                             },
                             PostalAddress=new AddressType()
                             {
                                  StreetName=new StreetNameType() {  Value=caritemp.sokak},
                                  CitySubdivisionName= new CitySubdivisionNameType() {  Value=caritemp.ilce},
                                  CityName=new CityNameType() { Value=caritemp.il},
                                  Country=new CountryType() { Name= new NameType1() { Value="Türkiye" } },

                             }
                        }
                    }
                };
                #endregion

                #region BuyerCustomerParty
                despatch.BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length > 1 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = caritemp.vergino.Length > 2 ? "VKN" : "TCKN", Value = caritemp.vergino.Length > 2 ? caritemp.vergino : caritemp.tcno } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = caritemp.unvan },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = caritemp.ulke
                            },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce },
                            BuildingName = new BuildingNameType { Value = caritemp.apt },
                            Room = new RoomType { Value = caritemp.daire }
                        }
                    }
                };
                #endregion

                #region SellerSupplierParty
                despatch.SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = "Gündüz Meypak" } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = "VKN", Value = "9000068418" } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = "TÜRKİYE" },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = "Ankara"
                            },
                            StreetName = new StreetNameType { Value = "Bahçekapı, Bahçekapı Mahallesi 2471. sokak" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "Etimesgut" },
                            BuildingName = new BuildingNameType { Value = "1" },
                            Room = new RoomType { Value = "" }
                        }
                    }
                };
                #endregion

                /*
                #region OriginatorCustomerParty
                despatch.OriginatorCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = "Tüm sürecin başlamasını Sağlayan Alıcı " } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = "VKN", Value = txtVKNAlici.Text } } },
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType
                            {
                                Name = new NameType1 { Value = "TÜRKİYE" },
                                IdentificationCode = new IdentificationCodeType
                                {
                                    Value = "TR"

                                }
                            },
                            CityName = new CityNameType
                            {
                                Value = "İSTANBUL"
                            },
                            StreetName = new StreetNameType { Value = "YILDIZ TEKNİK ÜNİ. DAVUTPAŞA KAMP. TEKNOPARK" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "ESENLER" },
                            BuildingName = new BuildingNameType { Value = "B1" },
                            Room = new RoomType { Value = "401" }
                        }
                    }
                };
                #endregion
                */
                #region DespatchLine
                despatch.DespatchLine = dplt;
            };
            stokKasaServis.Data(ServisList.StokKasaListeServis);
            stokKasaMarka.Data(ServisList.StokKasaMarkaListeServis);

            for (int i = tempirsdetay.Count(); i < tempirsdetay.Count() + tempstokkasahar.Count(); i++)
            {
                int genislik = 65; // belirli genişlik
                int nokta1 = 1; // ilk nokta
                int nokta2 = 12; // ikinci nokta
                int nokta3 = 32; // ikinci nokta
                int nokta4 = 42; // ikinci nokta 
                string deger1 = "M";
                deger1 += ""; // ilk değer 
                string deger2 = tempstokkasahar[i - tempirsdetay.Count()].miktar.ToString().Replace(',', '.');
                string deger3 =   " ";
                string deger4 = "Adet";
               

                string formatliDeger = deger1.PadRight(nokta2 - nokta1, ' ')
        + deger2.PadRight(nokta3 - nokta2, ' ')
        + deger3.PadRight(nokta4 - nokta3, ' ')
        + deger4.PadRight(genislik - nokta4, ' '); 
                var addt = new ItemIdentificationType[]
                             {
                                 new ItemIdentificationType(){

                                  ID=new IDType()
                                  {
                                        schemeID= "EXTVALUE",
                                         Value= formatliDeger
                                  }
                                 }
                             };
                var markaid = stokKasaServis.obje.Where(x => x.id == tempstokkasahar[i- tempirsdetay.Count()].kasaid).FirstOrDefault().markaid;
                var marka = stokKasaMarka.obje.Where(x => x.id == markaid).FirstOrDefault().adi;
                var kasa = stokKasaServis.obje.Where(x => x.id == tempstokkasahar[i- tempirsdetay.Count()].kasaid).FirstOrDefault();
                dplt[i]=   new DespatchLineType
                {

                    OrderLineReference = new OrderLineReferenceType { LineID = new LineIDType { Value = (i + 1).ToString() } },
                    ID = new IDType { Value = (i + 1).ToString() },
                    Shipment = new ShipmentType[] {
                                                 new ShipmentType {
                                                                    ID = new IDType { Value = "1" },
                                                                    Delivery  = new DeliveryType { ID= new IDType { Value="1" } }
                                                                    }
                                                },
                    Item = new ItemType
                    {
                        Name = new NameType1 { Value = marka + "-" + kasa.kasaadi },
                        BrandName = new BrandNameType { Value = marka },
                        BuyersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "" } },
                        ModelName = new ModelNameType { Value = "" },
                        Description = new DescriptionType { Value = "" },
                        ManufacturersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = "" } },
                        SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = kasa.kasakodu } },

                        AdditionalItemIdentification = addt
                    } 
                    , DeliveredQuantity= new DeliveredQuantityType()
                    {
                         Value= tempstokkasahar[i - tempirsdetay.Count()].miktar,
                          unitCode= "NIU"
                    }
                   
                };
            }
            #endregion
            despInfo.DespatchAdvice = despatch;

            return despInfo;
        }



        private async void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.EIRSALIYEGIDENKUTUSU.ToString()).EKLE == true)
            {
                try
                {
                    var client = DespatchTasks.Instance.CreateClient();

                    var despInfo = CreateDespatchInfo();
                    var despInfos = new DespatchInfo[] { despInfo };
                    var response = client.SendDespatchAsync(despInfos).Result;

                    if (response.IsSucceded)
                    {
                        MessageBox.Show(string.Format("İrsaliye No: {0} İrsaliye UUID: {1} ", response.Value[0].Number, response.Value[0].Id));
                        textBox1.Text = response.Value[0].Id; 
                        ShowInvoice(despInfo);
                    }
                    else
                    {
                        MessageBox.Show(response.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void RiLookup2_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup2.GetDataSourceRowByDisplayValue(riLookup2.Name);
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }
        private static XmlSerializerNamespaces _InvoiceNamespaces;
        public static XmlSerializerNamespaces InvoiceNamespaces
        {
            get
            {
                if (_InvoiceNamespaces == null)
                {
                    _InvoiceNamespaces = new XmlSerializerNamespaces();
                    _InvoiceNamespaces.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Despatch-2");
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

        public string ShowInvoiceWithCustomXslt(DespatchInfo invoice, string xslt)
        {
            var rootAttribute = new XmlRootAttribute("Despatch")
            {
                Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Despatch-2",
                IsNullable = false
            };

            XmlSerializer serializer = new XmlSerializer(typeof(DespatchInfo), rootAttribute);
            using (MemoryStream mstr = new MemoryStream())
            {
                serializer.Serialize(mstr, invoice, InvoiceNamespaces);

                string xml = Encoding.UTF8.GetString(mstr.ToArray());
                var teemmp = TransformXMLToHTML(xml, xslt);
                return teemmp;
            }


        }
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

        public void ShowInvoice(DespatchInfo invoice)
        {
            try
            {
                DespatchInfo invoics = invoice;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            cariServis.Data(ServisList.CariListeServis);
            irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            gidenIrsaliyelerServis.Data(ServisList.GidenIrsaliyelerListeServis);
            personelServis.Data(ServisList.PersonelListeServis);
            aracServis.Data(ServisList.AracListeServis);
            List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
            var ccf = irsaliyeServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.irsaliyetarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE", ETTNO = gidenIrsaliyelerServis.obje.Where(z => z.irsaliyeid == x.id).Count() > 0 ? gidenIrsaliyelerServis.obje.Where(z => z.irsaliyeid == x.id).FirstOrDefault().ettno : "" }).ToList();

            faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            gridControl1.DataSource = ccf;
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity != "BEKLEMEDE")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var invoiceInfo = CreateDespatchInfo();
            ShowInvoice(invoiceInfo);
        }
    }
}
