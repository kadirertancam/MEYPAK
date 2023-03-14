using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Map.Native;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout.Customization.Templates;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.EIslemler;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.SIPARIS;
using Newtonsoft.Json;
using RestSharp;
using ServiceReference1;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
        GenericWebServis<PocoCARIKART> cariServis;
        GenericWebServis<PocoFATURA> faturaServis;
        GenericWebServis<PocoFATURADETAY> faturaDetayServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKMARKA> stokMarkaServis;
        GenericWebServis<PocoGIDENFATURA> gidenFaturalarServis;
        List<EFaturaGidenTask> tempFatura;
        PocoFATURA fattemp;
        PocoCARIKART caritemp;
        PocoFATURADETAY[] fatDetaytemp; //bir faturanın birden fazla kalemi olabilir, dizi tanımlaması yapılır
        PocoSTOK tempStok;
        PocoSTOKMARKA tempStokMarka;
        RepositoryItemLookUpEdit riLookup, riLookup2;
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
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            faturaServis.Data(ServisList.FaturaListeServis);
            cariServis.Data(ServisList.CariListeServis);
            faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            gidenFaturalarServis.Data(ServisList.GidenFaturalarListeServis); 
            var client = CreateClient();
            var response2 = new InvoiceStatusResponse();
            var status = new InvoiceStatus();
            List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
            var ccf = faturaServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE",ETTNO= gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).Count() > 0 ? gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).FirstOrDefault().ettno : "" }).ToList();
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

                        var guid = new String[] {item.ETTNO };
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

        private void RiLookup2_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup2.GetDataSourceRowByDisplayValue(riLookup2.Name);
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }
        GenericWebServis<PocoFATURASTOKOLCUBR> faturaStokOlcuBrServis;
        #region Metotlar
        public InvoiceInfo CreateInvoice()
        {
            faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            EFaturaGidenTask eFaturaGidenTask = (EFaturaGidenTask)gridView1.GetFocusedRow();
            fattemp = faturaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            caritemp = cariServis.obje.Where(x => x.id == fattemp.cariid).FirstOrDefault();
            fatDetaytemp = faturaDetayServis.obje.Where(x => x.faturaid == fattemp.id).ToArray();
            var ccc = faturaDetayServis.obje.Where(x => x.faturaid == fattemp.id);
            
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
                    SellersItemIdentification = new ItemIdentificationType { ID = new IDType { Value = caritemp.vergino } },
                    

                };
                ınvoiceLineType[i].AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=true }, Amount = new AmountType2 { currencyID="TRY",Value=100 }, AllowanceChargeReason = new AllowanceChargeReasonType { Value= "Bayi İskontosu" },   }
                };
                ınvoiceLineType[i].Price = new PriceType { PriceAmount = new PriceAmountType { Value = Convert.ToDecimal(fatDetaytemp[i].netfiyat), currencyID = "TRY" } };
                ınvoiceLineType[i].InvoicedQuantity = new InvoicedQuantityType { unitCode = faturaStokOlcuBrServis.obje.Where(x => x.olcubrid == fatDetaytemp[i].birimid).FirstOrDefault().kisa, Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].safi), 2) };
                ınvoiceLineType[i].Note = new NoteType[] {  new NoteType {  Value = fatDetaytemp[i].aciklama }  };
                ınvoiceLineType[i].ID = new IDType { Value = (i+1).ToString() };
                ınvoiceLineType[i].LineExtensionAmount = new LineExtensionAmountType { Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].nettoplam), 2), currencyID = "TRY" };
                ınvoiceLineType[i].TaxTotal = new TaxTotalType
                {
                    TaxSubtotal = new TaxSubtotalType[]{ 
                      //Vergi 1 KDV
                      new TaxSubtotalType{
                      
                                 Percent = new PercentType1 { Value=Convert.ToDecimal(fatDetaytemp[i].kdv) } ,             
                                                                                                    //Percent =   //new PercentType{ Value=Math.Round(Convert.ToDecimal(txtKdvOrani1.Text),2)},
                              TaxCategory = new TaxCategoryType{TaxScheme = new TaxSchemeType{ TaxTypeCode = new TaxTypeCodeType{  Value = "0015"}, Name =new NameType1{ Value="KDV"} }, TaxExemptionReason=new TaxExemptionReasonType{ Value="12345 sayılı kanuna istinaden" }},
                              TaxAmount = new TaxAmountType{ Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].kdvtutari),2), currencyID= "TRY" },


                   }
                   },
                    TaxAmount = new TaxAmountType { Value = Math.Round(Convert.ToDecimal(fatDetaytemp[i].kdvtutari), 2), currencyID = "TRY" }

                }; 
                ınvoiceLineType[i].Note = new NoteType[]{ new NoteType() { Value = "" } };
            }
            var ttt = fatDetaytemp.GroupBy(x => new { x.kdv, x.kdvtutari });
            TaxTotalType[] taxTotalTypes;
            decimal kdv1=0, kdv8=0, kdv18 = 0;
            int kdvorani = 0;
            for (int i = 0; i <fatDetaytemp.Count(); i++)
            {
                if (fatDetaytemp[i].kdv == 1)
                {
                    kdv1+=fatDetaytemp[i].kdvtutari;
                    kdvorani = 1;
                }
                if (fatDetaytemp[i].kdv == 8)
                {
                    kdv8 += fatDetaytemp[i].kdvtutari;
                    kdvorani = 8;
                } if (fatDetaytemp[i].kdv == 18)
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
                UUID = new UUIDType { Value = Guid.NewGuid().ToString() }, //Set edilmediğinde sistem tarafından otomatik verilir. 
                IssueDate = new IssueDateType { Value = DateTime.Now },
                IssueTime = new IssueTimeType { Value = DateTime.Now  },
                InvoiceTypeCode = new InvoiceTypeCodeType { Value = eFaturaGidenTask.TIP },
                Note = new NoteType[] { new NoteType { Value = fattemp.aciklama }, new NoteType { Value = fattemp.aciklama }, new NoteType { Value = " " }, new NoteType { Value = "Test Not alanı 3" } },
                DocumentCurrencyCode = new DocumentCurrencyCodeType { Value = "TRY" },
                PricingCurrencyCode = new PricingCurrencyCodeType { Value = "TRY" },
                LineCountNumeric = new LineCountNumericType { Value = 2 },
                //PaymentTerms = new PaymentTermsType { Note = new NoteType { Value = "30 gün vadeli" }, Amount = new AmountType1 { Value = 100, currencyID = "TRY" } },
                PaymentMeans = new PaymentMeansType[] { new PaymentMeansType { PaymentDueDate = new PaymentDueDateType { Value = DateTime.Now }, PaymentMeansCode = new  PaymentMeansCodeType { Value = "42" } } },
                //Delivery = new DeliveryType { DeliveryParty = new PartyType { };
                // PricingExchangeRate = new ExchangeRateType{ SourceCurrencyCode= "TRY",}
                #endregion

                #region SGK fatura alanları
                AccountingCost =   null,
                InvoicePeriod = new PeriodType { StartDate = new StartDateType { Value = DateTime.Now }, EndDate = new EndDateType { Value = DateTime.Now } },
                #endregion



                ////AllowanceCharge = new AllowanceChargeType[]
                ////{
                ////    new AllowanceChargeType { ChargeIndicator= new ChargeIndicatorType { Value=true }, Amount = new AmountType2 { currencyID="TRY",Value=100 }, AllowanceChargeReason = new AllowanceChargeReasonType { Value= "Bayi İskontosu" },   }
                ////},

                //  BillingReference = new BillingReferenceType {   BillingReferenceLine = new BillingReferenceLineType[] { new BillingReferenceLineType {  } } }

                // AllowanceCharge = new AllowanceChargeType[] { new AllowanceChargeType { AllowanceChargeReason="Sigorta", ChargeIndicator = true },  }

                ////#region İrsaliye Bilgileri
                //////Irsaliye dosyasi               
                ////DespatchDocumentReference = new DocumentReferenceType[]{ new DocumentReferenceType{IssueDate= new IssueDateType{ Value=DateTime.Now},  DocumentType= new DocumentTypeType{  Value = "Irsaliye" }, ID= new IDType{Value="IRS000000001"}},
                ////                                                         new DocumentReferenceType{IssueDate= new IssueDateType{ Value=DateTime.Now},  DocumentType= new DocumentTypeType{  Value = "Irsaliye" }, ID= new IDType{Value="IRS000000002"}}},

                ////#endregion

                #region Xslt ve Ek belgeler
               // Fatura içerisinde görünüm dosyasını set etme.Değer geçilmediğinde varsayılan xslt kullanılır.
                

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
                ID = new IDType { Value = fattemp.serino+fattemp.belgeno }, //Set edilmediğinde sistem tarafından otomatik verilir. 
                #endregion

                #region Gönderici Bilgileri - AccountingSupplierParty

                AccountingSupplierParty = new SupplierPartyType
                {

                    Party = new PartyType
                    {
                        PartyName = new PartyNameType { Name = new NameType1 { Value = "Gündüz Meypak" } },
                        PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType() { ID = new IDType { Value = "9000068418", schemeID = "VKN" } }, new PartyIdentificationType() { ID = new IDType { Value = "12345669-111", schemeID = "MERSISNO" } }, new PartyIdentificationType() { ID = new IDType { Value = "12345669-111", schemeID = "TICARETSICILNO" } } },

                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = caritemp.il },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            Country = new CountryType { Name = new NameType1 { Value = caritemp.ulke } },
                            Room = new RoomType { Value = caritemp.daire },
                            BuildingNumber = new BuildingNumberType { Value = caritemp.apt },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce }, 
                        },
                        //PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType() { ID = new IDType { Value = "77777777701", schemeID = "TCKN" } } },
                        // Person = new PersonType{ FirstName= new FirstNameType{ Value="Ahmet"}, FamilyName= new FamilyNameType{ Value="Altınordu"} },
                        //PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = "Esenler" } } },
                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = caritemp.vergidairesi } } },

                    }
                },
                #endregion

                 
                AccountingCustomerParty = GetAccountingCustomerParty(),
                BuyerCustomerParty = GetBuyerCustomerParty(),
                TaxRepresentativeParty = GetTaxRepresantiveParty(),

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
                    AllowanceTotalAmount = new AllowanceTotalAmountType { Value = fattemp.geneltoplam, currencyID = "TRY" },
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
                TargetCustomer = new CustomerInfo { Alias =  "" },
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

                        PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length>0? caritemp.unvan:caritemp.adi+" "+ caritemp.soyadi } },
                        PartyIdentification = new PartyIdentificationType[1] { new PartyIdentificationType() { ID = new IDType { Value = caritemp.vergino.Length>0? caritemp.vergino: caritemp.tcno, schemeID = caritemp.vergino.Length >0 ? "VKN" : "TCKN" } } },
                        PostalAddress = new AddressType
                        {
                            CityName = new CityNameType { Value = caritemp.il },
                            StreetName = new StreetNameType { Value = caritemp.sokak },
                            Country = new CountryType { Name = new NameType1 { Value = caritemp.ulke } },
                            Room = new RoomType { Value = caritemp.daire },
                            BuildingNumber = new BuildingNumberType { Value = caritemp.apt },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = caritemp.ilce }

                        },
                        Contact = new ContactType { Telefax = new TelefaxType { Value = "22111222" }, ElectronicMail = new ElectronicMailType { Value = "test@test.com" }, Telephone = new TelephoneType { Value = "0212200022" } },
                        WebsiteURI = new WebsiteURIType { Value = "Web Sitesi" },
                        PartyTaxScheme = new PartyTaxSchemeType { TaxScheme = new TaxSchemeType { Name = new NameType1 { Value = caritemp.vergidairesi } } },
                        Person = caritemp.tcno.Length == 11 ? person : null
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
                            IdentityDocumentReference = new DocumentReferenceType { ID = new IDType { Value = "PSPTNO1234567" }, IssueDate = new IssueDateType { Value = fattemp.vadetarihi} }

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

                        PartyLegalEntity = new PartyLegalEntityType[] { new PartyLegalEntityType { RegistrationName = new RegistrationNameType { Value = caritemp.unvan.Length > 0 ? caritemp.unvan : caritemp.adi + " " + caritemp.soyadi }, CompanyID = new CompanyIDType { Value = caritemp.vergino.Length>0?caritemp.vergino:caritemp.tcno } } },
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
            var username = "Uyumsoft";
            var password = "Uyumsoft";
            var serviceuri = "https://efatura-test.uyumsoft.com.tr/services/Integration";
             

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
          gridControl2.DataSource=  faturaDetayServis.obje.Where(x => x.faturaid.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString());
        }

        private async void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
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
                    ettno = response.Value[0].Id.ToString(),hatakodu="",
                    tip = 1,
                    tarih = DateTime.Now,
                    userid = MPKullanici.ID, faturaid=fattemp.id

                });
                fattemp.durum = true;
                faturaServis.Data(ServisList.FaturaEkleServis, fattemp);
                faturaServis.Data(ServisList.FaturaListeServis);

                List<EFaturaGidenTask> eFaturaList = new List<EFaturaGidenTask>();
                var ccf = faturaServis.obje.Select(x => new EFaturaGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().vergino, CARIADI = cariServis.obje.Where(z => z.id == x.cariid).FirstOrDefault().unvan, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, FATURATIP = "TEMELFATURA", TIP = "SATIS", DURUM = x.durum == true ? "ONAYLANDI" : "BEKLEMEDE", ETTNO = gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).Count()>0? gidenFaturalarServis.obje.Where(z => z.faturaid == x.id).FirstOrDefault().ettno:"" }).ToList();
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
                    hatakodu=response.Message,

                });
                MessageBox.Show(response.Message);
            }
        }
    }
}
