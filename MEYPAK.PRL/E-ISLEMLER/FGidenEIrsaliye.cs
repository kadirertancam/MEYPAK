using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using e_İrsaliyeDemo_v1._0._0;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using ServiceReference11; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<EFaturaGidenTask> tempIRSALIYE;
        PocoIRSALIYE irstemp;
        PocoCARIKART caritemp;
        PocoIRSALIYEDETAY[] irsDetaytemp;  
        PocoSTOK tempStok;
        PocoSTOKMARKA tempStokMarka;
        RepositoryItemLookUpEdit riLookup, riLookup2;
        private void FGidenEIrsaliye_Load(object sender, EventArgs e)
        {
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
 
        public DespatchInfo CreateDespatchInfo()
        {
            DespatchInfo despInfo = new DespatchInfo();
            DespatchAdviceType despatch = new DespatchAdviceType();

            irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            var tempirs= irsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            var tempirsdetay = irsaliyeDetayServis.obje.Where(x => x.irsaliyeid == tempirs.id).ToList();
            #region İrsaliye Genel Bilgileri
            //İrsaliye Numarası
            cariServis.Data(ServisList.CariListeServis);
            caritemp = cariServis.obje.Where(x => x.id == tempirs.cariid).FirstOrDefault();
            siparisServis.Data(ServisList.SiparisListeServis);

            var tempsip= siparisServis.obje.Where(x => x.id == tempirs.siparisid).FirstOrDefault();
            var personel = personelServis.obje.Where(x => x.id == tempirs.personelid).FirstOrDefault();

            despatch.IssueDate = new IssueDateType { Value = DateTime.Now };
            despatch.IssueTime = new IssueTimeType { Value = DateTime.Now };
            despatch.CopyIndicator = new CopyIndicatorType { Value = false };
            despatch.ProfileID = new ProfileIDType { Value = "TEMELIRSALIYE" };
            despatch.DespatchAdviceTypeCode = new DespatchAdviceTypeCodeType { Value = "SEVK" };
            despatch.Note = new NoteType[] { new NoteType { Value = "İş bu sevk irsaliyesi muhteviyatına 7 gün içerisinde itiraz edilmediği taktirde aynen kabul edilmiş sayılır." } };
            despatch.OrderReference = new OrderReferenceType[] { new OrderReferenceType { ID = new IDType { Value = tempsip!=null?tempsip.belgeno:"" }, IssueDate = new IssueDateType { Value = DateTime.Now } } };
            despatch.LineCountNumeric = new LineCountNumericType { Value = 2 };
            #endregion
            var dplt = new DespatchLineType[tempirsdetay.Count()];
            for (int i = 0; i < tempirsdetay.Count(); i++)
            {
                dplt[i] =
                    new DespatchLineType
                    {
                        //DocumentReference = new DocumentReferenceType[] { new DocumentReferenceType {  ID = new IDType { Value = "SIP2018012984" }, IssueDate= new IssueDateType { Value=DateTime.Now } }  },
                        OrderLineReference = new OrderLineReferenceType { LineID = new LineIDType { Value = (i+1).ToString() } },
                        ID = new IDType { Value = (i+1).ToString() },
                        Shipment = new ShipmentType[] {
                                                 new ShipmentType {
                                                                    ID = new IDType { Value = "1" },
                                                                    Delivery  = new DeliveryType { ID= new IDType { Value="1" } }
                                                                    }
                                                },
                        Item = new ItemType
                        {
                            Name = new NameType1 { Value = tempirsdetay[i].stokadi },
                          
                            ManufacturersItemIdentification=new ItemIdentificationType()
                            {
                                 ID=new IDType()
                                 {
                                     Value= stokServis.obje.Where(x => x.id == tempirsdetay[i].stokid).FirstOrDefault().kod
                                 }
                            },
                            SellersItemIdentification=new ItemIdentificationType()
                            {
                                 ID=new IDType()
                                 {
                                      Value= stokServis.obje.Where(x => x.id == tempirsdetay[i].stokid).FirstOrDefault().kod
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
                GoodsItem = new GoodsItemType[]{ new GoodsItemType{
                Description= new DescriptionType[]{
                    new DescriptionType{
                        Value="Taşıma özenli olmalı"
                                    }
                                                    },
                Item = new ItemType[]{
                                new ItemType{
                                    Name=new NameType1{
                                        Value= ""
                                                        }
                                            }
                                       }, 

                   InvoiceLine = new InvoiceLineType[]{ new InvoiceLineType{
                             ID= new IDType{ Value= "1"},
                             LineExtensionAmount = new LineExtensionAmountType{ currencyID="TRY", Value= 0},
                             InvoicedQuantity = new InvoicedQuantityType{ Value= 0, unitCode="NIU"},
                             Item= new ItemType{ Name = new NameType1{ Value="test"}} ,
                             Price = new PriceType{ PriceAmount=new PriceAmountType{Value= 0, currencyID="TRY"}},
                           
                   }}

            }},
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
                                         }

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
                                     CitySubdivisionName= new CitySubdivisionNameType(){ Value=caritemp.ilce },
                                     CityName=new CityNameType(){ Value=caritemp.il},
                                     PostalZone=new PostalZoneType(){Value=caritemp.postakod},
                                     Region=new  RegionType(){ Value=caritemp.ilce},
                                     District = new DistrictType(){ Value=caritemp.ilce},
                                     Country=new CountryType(){Name= new NameType1(){ Value=caritemp.ulke } }
                                 } 
                }
            };
            #endregion

            #region DespatchSupplierParty
            despatch.DespatchSupplierParty = new SupplierPartyType
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
                        StreetName = new StreetNameType { Value = "Gündüz Meypak" },
                        CitySubdivisionName = new CitySubdivisionNameType { Value = "Etimesgut" },
                        BuildingName = new BuildingNameType { Value = "1" }, 
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
                    PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = caritemp.vergino.Length > 2 ? "VKN":"TCKN", Value = caritemp.vergino.Length>2?caritemp.vergino:caritemp.tcno } } },
                    PostalAddress = new AddressType
                    {
                        Country = new CountryType
                        {
                            Name = new NameType1 { Value = caritemp.ulke},
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
                    }
                }
            };
            #endregion

            #region BuyerCustomerParty
            despatch.BuyerCustomerParty = new CustomerPartyType
            {
                Party = new PartyType
                {
                    PartyName = new PartyNameType { Name = new NameType1 { Value = caritemp.unvan.Length>1?caritemp.unvan:caritemp.adi+ " " + caritemp.soyadi} },
                    PartyIdentification = new PartyIdentificationType[] { new PartyIdentificationType { ID = new IDType { schemeID = caritemp.vergino.Length > 2 ? "VKN" : "TCKN", Value = caritemp.vergino.Length > 2 ? caritemp.vergino : caritemp.tcno } } },
                    PostalAddress = new AddressType
                    {
                        Country = new CountryType
                        {
                            Name = new NameType1 { Value = caritemp.unvan},
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
            #endregion
            despInfo.DespatchAdvice = despatch;

            return despInfo;
        }



        private async void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.EIRSALIYEGIDENKUTUSU.ToString()).EKLE==true)
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

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
