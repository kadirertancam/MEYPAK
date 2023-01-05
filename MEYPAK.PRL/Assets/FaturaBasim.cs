using DevExpress.XtraRichEdit;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.Fatura;
using MEYPAK.PRL.EFatura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using static MEYPAK.PRL.EFatura.TemelFaturaXML;
using System.Xml.Serialization.Extensions;

namespace MEYPAK.PRL.Assets
{
    public class FaturaBasim
    {
        public FaturaBasim()
        {
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
        }

        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;

        public void Basim(int faturaid)
        {
            _faturaServis.Data(ServisList.FaturaListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            var fatura = _faturaServis.obje.Where(x => x.id == faturaid).FirstOrDefault();
            var cari = _cariServis.obje.Where(x => x.id == fatura.cariid).FirstOrDefault();
            var faturadetay = _faturaDetayServis.obje.Where(x => x.faturaid == fatura.id);
            DataSet ds;
            XmlDataDocument xmlDoc;
            XslCompiledTransform xslTran;
            XmlElement root;
            XPathNavigator nav;
            XmlTextWriter writer;
            try
            {
                var rsa = RSA.Create();
                var t1 = new AccountingCustomerParty()
                {
                    Party = new AccountingCustomerPartyParty()
                    {
                        Contact = new AccountingCustomerPartyPartyContact()
                        {
                            ElectronicMail = cari.eposta,
                            Telefax = cari.fax.ToString(),
                            Telephone = cari.telefon.ToString()
                        },
                        PartyIdentification = new AccountingCustomerPartyPartyPartyIdentification()
                        {
                            ID = new ID()
                            {
                                schemeID = "VKN",
                                Value = cari.vergino.ToString()
                            }
                        },
                        PartyName = new AccountingCustomerPartyPartyPartyName()
                        {
                            Name = cari.unvan.ToString(),
                        },
                        PartyTaxScheme = new AccountingCustomerPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = cari.vergidairesi.ToString()
                            }
                        },
                        PostalAddress = new AccountingCustomerPartyPartyPostalAddress()
                        {

                            BuildingName = "",
                            BuildingNumber = cari.apt,
                            CityName = cari.il.ToString(),
                            CitySubdivisionName = cari.ilce.ToString(),
                            Country = new AccountingCustomerPartyPartyPostalAddressCountry() { Name = cari.ulke },
                            PostalZone = "0",
                            Region = cari.mahalle.ToString(),
                            Room = cari.daire,
                            StreetName = cari.sokak.ToString(),

                        }
                    }
                };
                var t2 = new AccountingSupplierParty()
                {
                    Party = new AccountingSupplierPartyParty()
                    {
                        Contact = new AccountingSupplierPartyPartyContact()
                        {
                            ElectronicMail = "gunduzmeypak@gmail.com",
                            Telefax = "000000000",
                            Telephone = "000",

                        },

                        PartyName = new AccountingSupplierPartyPartyPartyName()
                        {
                            Name = "Gündüz Meypak A.Ş."
                        },
                        PartyTaxScheme = new AccountingSupplierPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = "Başkent"
                            }
                        },
                        PostalAddress = new AccountingSupplierPartyPartyPostalAddress()
                        {
                            BuildingName = "",
                            BuildingNumber = "0",
                            CityName = "Ankara",
                            CitySubdivisionName = "Çankaya",
                            Country = new AccountingSupplierPartyPartyPostalAddressCountry() { Name = "Türkiye" },
                            PostalZone = "0",
                            Region = "Kızılırmak",
                            Room = "0",
                            StreetName = "DumluPınar"


                        }

                    }
                };
                List<InvoiceLine> fatSatir = new List<InvoiceLine>();
                foreach (var item in faturadetay)
                {
                    fatSatir.Add(new InvoiceLine()
                    {

                        ID = new ID()
                        {
                            schemeID = "",
                            Value = item.stokid.ToString()
                        },
                        InvoicedQuantity = new InvoicedQuantity()
                        {
                            unitCode = "NIU",
                            Value = item.safi
                        },
                        Item = new InvoiceLineItem()
                        {
                            Name = item.stokadi

                        },
                        LineExtensionAmount = new LineExtensionAmount()
                        {
                            currencyID = "TRL",
                            Value = item.nettoplam
                        },
                        Price = new InvoiceLinePrice()
                        {
                            PriceAmount = new PriceAmount()
                            {
                                currencyID = "TRL",
                                Value = Convert.ToByte(item.birimfiyat)


                            }
                        },
                        TaxTotal = new InvoiceLineTaxTotal()
                        {
                            TaxAmount = new TaxAmount()
                            {
                                currencyID = "TRL",
                                Value = item.kdvtutari
                            },
                            TaxSubtotal = new InvoiceLineTaxTotalTaxSubtotal()
                            {
                                TaxAmount = new TaxAmount()
                                {
                                    currencyID = "TRL",
                                    Value = item.kdvtutari
                                },
                                Percent = item.kdv,
                                TaxableAmount = new TaxableAmount() { currencyID = "TRL", Value = item.nettoplam },
                                TaxCategory = new InvoiceLineTaxTotalTaxSubtotalTaxCategory()
                                {
                                    TaxScheme = new InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme()
                                    {
                                        TaxTypeCode = "0015",
                                        Name = "KDV"
                                    }
                                }
                            }
                        }
                    });
                }


                var t3 = new AdditionalDocumentReference[]
                {
                    new AdditionalDocumentReferenceAttachment()
                    {
                        EmbeddedDocumentBinaryObject= new EmbeddedDocumentBinaryObject()
                        {
                           
                        }
                      
                    }
                };
                var t5 = fatSatir;
                var t6 = new LegalMonetaryTotal()
                {
                    AllowanceTotalAmount = new AllowanceTotalAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.iskontotoplam
                    },
                    LineExtensionAmount = new LineExtensionAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.nettoplam
                    },
                    PayableAmount = new PayableAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.geneltoplam
                    },
                    TaxExclusiveAmount = new TaxExclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.bruttoplam
                    },
                    TaxInclusiveAmount = new TaxInclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.bruttoplam + fatura.kdvtoplam
                    },

                };
                var t8 = new TaxTotal()
                {
                    TaxAmount = new TaxAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.kdvtoplam
                    },
                    TaxSubtotal = new TaxTotalTaxSubtotal()
                    {
                        CalculationSequenceNumeric = 1,
                        Percent = faturadetay.FirstOrDefault().kdv,
                        TaxableAmount = new TaxableAmount()
                        {
                            currencyID = "TRL",
                            Value = fatura.kdvtoplam
                        },
                        TaxAmount = new TaxAmount()
                        {
                            currencyID = "TRL",
                            Value = fatura.kdvtoplam
                        },
                        TaxCategory = new TaxTotalTaxSubtotalTaxCategory()
                        {
                            TaxScheme = new TaxTotalTaxSubtotalTaxCategoryTaxScheme()
                            {
                                Name = "KDV",
                                TaxTypeCode = "0015"
                            }
                        }
                    }
                };
                TemelFaturaXML.Invoice temelfatura = new Invoice()
                {
                    AccountingCustomerParty = t1,
                    AccountingSupplierParty = t2,
                    AdditionalDocumentReference = t3,
                    CopyIndicator = false,
                    CustomizationID = "TR1.0",
                    UBLVersionID = decimal.Parse("2.1"),
                    InvoiceLine = t5,
                    InvoiceTypeCode = "SATIS",
                    IssueDate = fatura.vadetarihi,
                    LegalMonetaryTotal = t6,
                    LineCountNumeric = 1,
                    Note = "",
                    ProfileID = "TEMELFATURA",
                    TaxTotal = t8,
                    ID = new ID()
                    {
                        schemeID = "",
                        Value = fatura.belgeno,
                    },

                    UBLExtensions = new UBLExtensions()
                    {
                        UBLExtension = new UBLExtensionsUBLExtension()
                        {
                            ExtensionContent = new UBLExtensionsUBLExtensionExtensionContent()
                            {
                                autogeneratedwildcard = new object()
                            }
                        }
                    },
                    DocumentCurrencyCode = "TRY",
                    Signature = new Signature()
                    {

                        ID = new ID()
                        {
                            schemeID = "VKN_TCKN",
                            Value = cari.vergino
                        },
                        SignatoryParty = new SignatureSignatoryParty()
                        {
                            PartyIdentification = new SignatureSignatoryPartyPartyIdentification()
                            {
                                ID = new ID()
                                {
                                    schemeID = "VKN",
                                    Value = cari.vergino
                                }
                            },
                            PostalAddress = new SignatureSignatoryPartyPostalAddress()
                            {
                                Room = "340",
                                BuildingName = "YDA CENTER",
                                BuildingNumber = cari.apt,
                                CityName = cari.il,
                                Country = new SignatureSignatoryPartyPostalAddressCountry() { Name = cari.ulke },
                                CitySubdivisionName = cari.ilce,
                                PostalZone = cari.postakod,
                                Region = cari.ilce,
                                StreetName = cari.adres,


                            }
                        }
                    }

                };



                server = new RichEditDocumentServer();
                var ss = temelfatura.SerializeToXml<TemelFaturaXML.Invoice>();

                //File.WriteAllText("Employee.xml", ss.ToString(),Encoding.UTF8);

                //Create the DataSet from the XML file
                XslCompiledTransform proc = new XslCompiledTransform();
                proc.Load("Employee.xslt");
                proc.Transform(Application.StartupPath + "Employee.xml", Application.StartupPath + "output.html");
                PrintToPDF(Application.StartupPath + "output.html");
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
        List<string> fileList = new List<string>();
        RichEditDocumentServer server;
        PerformanceCounter counter;

        private void PrintToPDF(string filePath)
        {
            string displayText;

            try
            {
                server.LoadDocument(filePath);
            }
            catch (Exception ex)
            {
                server.CreateNewDocument();
                displayText = String.Format("{0:T} Error:{1} -> {2}", DateTime.Now, ex.Message, filePath) + Environment.NewLine;

                return;
            }
            server.Document.Sections[0].Page.Landscape = false;
            server.Document.Sections[0].Margins.Left = 100f;
            server.Document.Sections[0].Margins.Right = 0f;
            server.Document.Sections[0].Margins.Top = 100f;
            server.Document.Sections[0].Margins.Bottom = 0f;
            server.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            server.Document.Sections[0].Page.Width = 3080;
            server.Document.Sections[0].Page.Height = 5920;
            var url = Application.StartupPath + "output.html";
            var chromePath = Application.StartupPath + @"chrome-win\chrome.exe";
            var output = Path.Combine(Environment.CurrentDirectory, "output.pdf");
            using (var p = new Process())
            {
                p.StartInfo.FileName = chromePath;
                p.StartInfo.Arguments = $"--headless --disable-gpu --print-to-pdf={output} {url}";
                p.Start();
                p.WaitForExit();
            }


        }

    }
}
