using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReference6;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.EISLEMLER;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class FGidenEMustahsil : XtraForm
    {
        public FGidenEMustahsil()
        {
            InitializeComponent();
            mustahsilServis = new GenericWebServis<PocoMUSTAHSIL>();
            mustahsilCariServis = new GenericWebServis<PocoMUSTAHSILCARI>();
            stokServis = new GenericWebServis<PocoSTOK>();
            mustahsilDetayServis = new GenericWebServis<PocoMUSTAHSILDETAY>();
            gidenMustahsilMakbuzlariServis = new GenericWebServis<PocoGIDENMUSTAHSILMAKBUZLARI>();
            stokMarkaServis = new GenericWebServis<PocoSTOKMARKA>();
            personelServis = new GenericWebServis<PocoPERSONEL>();
            aracServis = new GenericWebServis<PocoARAC>();
            faturaStokOlcuBr = new GenericWebServis<PocoFATURASTOKOLCUBR>();
        }
        GenericWebServis<PocoMUSTAHSIL> mustahsilServis;
        GenericWebServis<PocoMUSTAHSILDETAY> mustahsilDetayServis;
        GenericWebServis<PocoMUSTAHSILCARI> mustahsilCariServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoSTOKMARKA> stokMarkaServis;
        GenericWebServis<PocoPERSONEL> personelServis;
        GenericWebServis<PocoARAC> aracServis;
        GenericWebServis<PocoGIDENMUSTAHSILMAKBUZLARI> gidenMustahsilMakbuzlariServis;
        GenericWebServis<PocoFATURASTOKOLCUBR> faturaStokOlcuBr;
        RepositoryItemLookUpEdit riLookup, riLookup2;

        private void FGidenEMustahsil_Load(object sender, EventArgs e)
        {
            stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            stokServis.Data(ServisList.StokListeServis);
            //irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            mustahsilServis.Data(ServisList.MustahsilListeServis);
            //cariServis.Data(ServisList.CariListeServis);
            mustahsilCariServis.Data(ServisList.MustahsilCariListeServis);
            //irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            mustahsilDetayServis.Data(ServisList.MustahsilDetayListeServis);
            //gidenIrsaliyelerServis.Data(ServisList.GidenIrsaliyelerListeServis);
            personelServis.Data(ServisList.PersonelListeServis);
            faturaStokOlcuBr.Data(ServisList.FATURASTOKOLCUBRListeServis);
            aracServis.Data(ServisList.AracListeServis);
            gidenMustahsilMakbuzlariServis.Data(ServisList.GidenMustahsilMakbuzlariListeServis);
            List<EMustahsilGidenTask> eFaturaList = new List<EMustahsilGidenTask>();
            var ccf = mustahsilServis.obje.Select(x => new EMustahsilGidenTask { SEC = false, ID = x.id.ToString(), FATURALASTIR = "", BASIM = "", VKNTCK = mustahsilCariServis.obje.Where(z => z.id == x.mustahsilcariid).FirstOrDefault().TCNO, CARIADI = mustahsilCariServis.obje.Where(z => z.id == x.mustahsilcariid).FirstOrDefault().ADISOYADI, BELGENO = x.belgeno, TARIH = x.faturatarihi, VADETARIHI = x.vadetarihi, TUTAR = x.geneltoplam, KDV = x.kdvtoplam, DURUM = x.durum == true ? "GÖNDERİLDİ" : "BEKLEMEDE", ETTNO = gidenMustahsilMakbuzlariServis.obje.Where(z => z.mustahsilid == x.id).Count() > 0 ? gidenMustahsilMakbuzlariServis.obje.Where(z => z.mustahsilid == x.id).FirstOrDefault().ettno : "" }).ToList();


            gridControl1.DataSource = ccf;

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
            //gridView1.Columns["FATURATIP"].ColumnEdit = riLookup;
            //gridView1.Columns["TIP"].ColumnEdit = riLookup2;
            gridView1.Columns["ID"].Visible = false;
        }

        private void RiLookup2_EditValueChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo); ;

            if (dialogResult == DialogResult.Yes)
            {
                var client = CreateClient();
                var makbuz = CreateCreditNote();
                var response = client.SendProducerReceiptAsync(
                    new ProducerReceiptInfo[] {
                new ProducerReceiptInfo {
                                        Receipt = makbuz
                                        }
                    }
                    ).Result; ;

                if (response.IsSucceded)
                {
                    textBox1.Text = response.Value[0].DocumentId;
                    MessageBox.Show(string.Format("Request Başarıyla işlendi. UUID:{0} ID:{1}", response.Value[0].DocumentId, response.Value[0].ReceiptNumber));

                }
                else
                {
                    MessageBox.Show(string.Format("Hata: {0}", response.Message));
                }
            }
        }


        #region methods
        public CreditNoteType CreateCreditNote()
        {
            PocoMUSTAHSIL tempMustahsil = null;
            if (gridView1.GetFocusedRowCellValue("ID") != null)
                tempMustahsil = mustahsilServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID")).Count() > 0 ? mustahsilServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault() : null;

            mustahsilDetayServis.Data(ServisList.MustahsilDetayListeServis);
            mustahsilCariServis.Data(ServisList.MustahsilCariListeServis);
           var _tempkalem= mustahsilDetayServis.obje.Where(x => x.mustahsilid ==tempMustahsil.id).ToArray();
            var tempkalem = new CreditNoteLineType[_tempkalem.Count()];
            for (int i = 0; i < _tempkalem.Count(); i++)
            {


                tempkalem[i] =
                                      new CreditNoteLineType
                                      {
                                          ID = new IDType { Value = _tempkalem[i].num.ToString() }, //Sıra no
                                          CreditedQuantity = new CreditedQuantityType { unitCode = faturaStokOlcuBr.obje.Where(x => x.olcubrid == _tempkalem[i].birimid).FirstOrDefault().kisa, Value = Convert.ToDecimal( _tempkalem[i].safi) }, //Mal Hizmet Miktarı, UnitCode C62=Adet, KGM= Kilogram, LTR = Litre, Diğerleri için bilgi alınız.  
                                          Item = new ItemType { Name = new NameType1 { Value = _tempkalem[i].stokadi }, Description = new DescriptionType { Value = _tempkalem[i].aciklama } }, //Mal Hizmet adı ve diğer açıklamalr 
                                          Price = new PriceType { PriceAmount = new PriceAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_tempkalem[i].netfiyat) } },//Ürün birim fiyatı
                                          LineExtensionAmount = new LineExtensionAmountType { currencyID = "TRY", Value = Convert.ToDecimal(_tempkalem[i].nettoplam) }, //Satır Toplam Tutarı
                                          TaxTotal = new TaxTotalType[]{
                                                                   new TaxTotalType
                                                                   {

                                                                        TaxAmount = new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0) +Convert.ToDecimal(0) +Convert.ToDecimal(0) +Convert.ToDecimal(0) },
                                                                        TaxSubtotal = new TaxSubtotalType[]
                                                                        {
                                                                            new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },//stopaj
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)  },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "G.V.Stopaj" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "0003" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                            new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)  },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "Mera Fonu" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "9040" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                             new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)  },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "Borsa Tescil Ücreti" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "8001" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                               new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)  },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "SGK Prim Kesintisi" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "SGK_PRIM" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                        }



                                                                   }

                                                               }

                                      };
                                       

}
            var makbuz = new CreditNoteType
            {

                UBLVersionID = new UBLVersionIDType { Value = "2.1" }, //Sabit Değer
                CustomizationID = new CustomizationIDType { Value = "TR1.2" },  //Sabit Değer
                ProfileID = new ProfileIDType { Value = "e-Arşiv Belge" },   //Sabit Değer
                ID = new IDType { Value = tempMustahsil.serino+tempMustahsil.belgeno }, //BelgeNo 16 hane. 3 hane prefix, 4 hane belge tarihinin yılı. 9 hane 0000000001'den başlayarak sıralı numara. Boş bırakıldığında sistem varsayılan seriden sıradaki nuamrayı verir. 
                CopyIndicator = new CopyIndicatorType { Value = false }, //Sabit değer
                UUID = new UUIDType { Value = "" }, //Makbuza ait unique Id, boş bırakıldığında sistem üretir ve response'ta geri döner. Dolu olduğunda yazılımcınınki kullanılır.
                IssueDate = new IssueDateType { Value = tempMustahsil.faturatarihi }, //Belge Tarihi
                IssueTime = new IssueTimeType { Value = tempMustahsil.faturatarihi }, //Belge saati
                LineCountNumeric = new LineCountNumericType { Value = Convert.ToDecimal(mustahsilDetayServis.obje.Where(x => x.mustahsilid == tempMustahsil.id).Count()) }, //Belgedeki Mal hizmet kalemi sayısı (CreditNoteLine sayısı)
                Note = new NoteType[] { new NoteType { Value = tempMustahsil.aciklama } },
                //Belgeyi oluşturan firma bilgileri
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[] {
                            new PartyIdentificationType {
                                ID = new IDType {
                                    schemeID = "VKN", //Gönderici 11 haneli bir TCKN'ye sahipse bu alan "TCKN" olmalıdır ve bu eleman altındaki Person elemanında firstname ve FamiliyName dolu olmalıdır.
                                    Value = "9000068418", //Gönderici VKN ya da TCKN numarası
                                    

                                }
                            },
                            new PartyIdentificationType {
                                ID = new IDType {
                                    schemeID = "MERSISNO", //Mersis no ve benzeri bazı değerler için bu alan kullanılabilir. Kod listelerinde hangi kodların kullanılabileceğine dair bir liste bulunmaktadır. 
                                    Value = "", //İlgili numara

                                }
                            },

                        },
                        PartyName = new PartyNameType { Name = new NameType1 { Value = "Gündüz Meypak" } }, //Firma Ünvanı
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } }, //Ülke. Yurtdışına belge düzenlenme ihtimali yoksa sabit değer olarka kalabilir 
                            CityName = new CityNameType { Value ="Ankara" },//Firma Şehir
                            CitySubdivisionName = new CitySubdivisionNameType { Value ="Etimesgut" }, //Firma İlçe
                            StreetName = new StreetNameType { Value = "Bahçekapı, Bahçekapı Mahallesi 2471. sokak, Şaşmaz Blv. no:1" }, //Gönderici firma adresi.

                        },

                    },
                },


                //Belgenin alıcısı firmaya(müşteriye) ait bilgileri
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[] {
                            new PartyIdentificationType {
                                ID = new IDType {
                                    schemeID = "TCKN", //Alıcı 11 haneli bir TCKN'ye sahipse bu alan "TCKN" olmalıdır ve bu eleman altındaki Person elemanında firstname ve FamiliyName dolu olmalıdır.
                                    Value = mustahsilCariServis.obje.Where(x=>x.id== tempMustahsil.mustahsilcariid).FirstOrDefault().TCNO, //Gönderici VKN ya da TCKN numarası

                                }
                            }, 
                            
                        }, Person = new PersonType()
                        {
                            FamilyName = new FamilyNameType() { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().SOYADI },
                             FirstName = new FirstNameType() { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().ADI },
                              NationalityID = new NationalityIDType() { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().TCNO }
                        },
                        PartyName = new PartyNameType { Name = new NameType1 { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().ADISOYADI } }, //Alıcı Ünvanı
                        PostalAddress = new AddressType
                        {
                            Country = new CountryType { Name = new NameType1 { Value = "Türkiye" } }, //Ülke. Yurtdışına belge düzenlenme ihtimali yoksa sabit değer olarka kalabilir 
                            CityName = new CityNameType { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().IL },//Firma Şehir
                            CitySubdivisionName = new CitySubdivisionNameType { Value = mustahsilCariServis.obje.Where(x => x.id == tempMustahsil.mustahsilcariid).FirstOrDefault().ILCE }, //Firma İlçe
                            StreetName = new StreetNameType { Value = "" }, //Gönderici firma adresi.

                        },

                    },
                },

                //Teslim Tarihi
                Delivery = new DeliveryType[] { new DeliveryType { ActualDeliveryDate = new ActualDeliveryDateType { Value = tempMustahsil.faturatarihi } } },


                //Belge alt toplamları
                LegalMonetaryTotal = new MonetaryTotalType
                {

                    LineExtensionAmount = new LineExtensionAmountType { currencyID = "TRY", Value = Convert.ToDecimal(tempMustahsil.bruttoplam) }, //Vergiler ve İskonto Hariç toplam tutar, Virgülden sonra 2 haneden fazla olmamalı
                    TaxInclusiveAmount = new TaxInclusiveAmountType { currencyID = "TRY", Value = Convert.ToDecimal(tempMustahsil.geneltoplam) }, //Vergiler Dahil Toplam Tutar, Virgülden sonra 2 haneden fazla olmamalı
                    TaxExclusiveAmount = new TaxExclusiveAmountType { currencyID = "TRY", Value = Convert.ToDecimal(tempMustahsil.nettoplam) }, //Vergiler Hariç iskontolu Toplam Tutar, Virgülden sonra 2 haneden fazla olmamalı
                    AllowanceTotalAmount = new AllowanceTotalAmountType { currencyID = "TRY", Value = Convert.ToDecimal(tempMustahsil.iskontotoplam) }, //İskonto Toplamı , Virgülden sonra 2 haneden fazla olmamalı
                    PayableAmount = new PayableAmountType { currencyID = "TRY", Value = Convert.ToDecimal(tempMustahsil.geneltoplam) }, //Ödenecek Toplam Tutar , Virgülden sonra 2 haneden fazla olmamalı

                },



                //Belgedeki mal / hizmet kalemleri
                CreditNoteLine = tempkalem,

                //Belgeye ait vergiler
                TaxTotal = new TaxTotalType[]{
                                                                   new TaxTotalType
                                                                   {

                                                                        TaxAmount = new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0) +Convert.ToDecimal(0) +Convert.ToDecimal(0) +Convert.ToDecimal(0) },

                                                                        //TaxSubtotal her farklı vergi kodu, oranı veya vergi muafiyet açıklaması için çoklanacaktır. Örneğin aynı belgede hem %18 hem %1 vergi olur ise 1 TaxTotal altında 2 TaxSubTotal olacaktır
                                                                       TaxSubtotal = new TaxSubtotalType[]
                                                                        {
                                                                            new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) }, //Oranlar aynı olduğu için 1 tanesi baz alındı. Oranlar farklılaşırsa her oran için farklı bir subtotal oluşturulmalıdır. 
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)   },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "G.V.Stopaj" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "0003" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                            new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0) },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)   },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "Mera Fonu" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "9040" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                             new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0) },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "Borsa Tescil Ücreti" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "8001" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                               new TaxSubtotalType
                                                                            {
                                                                                 TaxAmount =  new TaxAmountType{ currencyID="TRY", Value= Convert.ToDecimal(0)  },
                                                                                  Percent = new PercentType1{ Value= Convert.ToDecimal(0) },
                                                                                   TaxableAmount = new TaxableAmountType{ currencyID="TRY", Value=Convert.ToDecimal(0)   },
                                                                                    TaxCategory = new TaxCategoryType
                                                                                    {
                                                                                         TaxScheme = new TaxSchemeType
                                                                                         {
                                                                                              Name = new NameType1{ Value=  "SGK Prim Kesintisi" },
                                                                                               TaxTypeCode = new TaxTypeCodeType{ Value= "SGK_PRIM" }
                                                                                         }
                                                                                    }

                                                                            },

                                                                        }



                                                                   }

                                                               }


            };


            return makbuz;


        }
        public ProducerReceiptIntegrationClient CreateClient()
        {
            var client = new ProducerReceiptIntegrationClient();
            client.ClientCredentials.UserName.UserName = "Uyumsoft";
            client.ClientCredentials.UserName.Password = "Uyumsoft";
            return client;


        }
        #endregion
    }
}
