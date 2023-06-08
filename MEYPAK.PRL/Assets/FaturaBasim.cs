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
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
using System.Xml.Linq;
using static MEYPAK.PRL.EFatura.IrsaliyeXML;
using AdditionalDocumentReference = MEYPAK.PRL.EFatura.TemelFaturaXML.AdditionalDocumentReference;
using UBLExtensionsUBLExtension = MEYPAK.PRL.EFatura.TemelFaturaXML.UBLExtensionsUBLExtension;
using UBLExtensions = MEYPAK.PRL.EFatura.TemelFaturaXML.UBLExtensions;
using UBLExtensionsUBLExtensionExtensionContent = MEYPAK.PRL.EFatura.TemelFaturaXML.UBLExtensionsUBLExtensionExtensionContent;
using Signature = MEYPAK.PRL.EFatura.TemelFaturaXML.Signature;
using SignatureSignatoryParty = MEYPAK.PRL.EFatura.TemelFaturaXML.SignatureSignatoryParty;
using SignatureSignatoryPartyPartyIdentification = MEYPAK.PRL.EFatura.TemelFaturaXML.SignatureSignatoryPartyPartyIdentification;
using SignatureSignatoryPartyPostalAddress = MEYPAK.PRL.EFatura.TemelFaturaXML.SignatureSignatoryPartyPostalAddress;
using SignatureSignatoryPartyPostalAddressCountry = MEYPAK.PRL.EFatura.TemelFaturaXML.SignatureSignatoryPartyPostalAddressCountry;
using ID = MEYPAK.PRL.EFatura.TemelFaturaXML.ID;
using MEYPAK.Entity.PocoModels.PARAMETRE;

namespace MEYPAK.PRL.Assets
{
    public class FaturaBasim
    {
        public FaturaBasim()
        {
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _efaturaParamsServis = new GenericWebServis<PocoEFATURAPARAMS>();
        }

        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoEFATURAPARAMS> _efaturaParamsServis;

        public void TemelFaturaBasim(int faturaid)
        {
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _faturaServis.Data(ServisList.FaturaListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _faturaDetayServis.Data(ServisList.FaturaDetayListeServis);
            _efaturaParamsServis.Data(ServisList.EFaturaParamsListeServis);
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


                            CityName = cari.il.ToString(),
                            CitySubdivisionName = cari.ilce.ToString(),
                            Country = new AccountingCustomerPartyPartyPostalAddressCountry() { Name = cari.ulke },
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
                            ElectronicMail = "mey_pak@hotmail.com", 
                            Telephone = "03123617273",

                        },

                        PartyName = new AccountingSupplierPartyPartyPartyName()
                        {
                            Name = _efaturaParamsServis.obje.FirstOrDefault().unvan
                        },
                        PartyTaxScheme = new AccountingSupplierPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = _efaturaParamsServis.obje.FirstOrDefault().vd
                            }
                        },
                        PostalAddress = new AccountingSupplierPartyPartyPostalAddress()
                        {
                            BuildingName = "",
                            BuildingNumber = "0",
                            CityName = _efaturaParamsServis.obje.FirstOrDefault().il,
                            CitySubdivisionName = _efaturaParamsServis.obje.FirstOrDefault().ilce,
                            Country = new AccountingSupplierPartyPartyPostalAddressCountry() { Name = _efaturaParamsServis.obje.FirstOrDefault().ulke },
                            PostalZone = "06560", 
                            StreetName = _efaturaParamsServis.obje.FirstOrDefault().sokak


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
                            unitCode = "KGM",
                            Value = item.safi
                        },
                        Item = new InvoiceLineItem()
                        {
                            Name = item.stokadi

                        },
                        LineExtensionAmount = new TemelFaturaXML.LineExtensionAmount()
                        {
                            currencyID = "TRL",
                            Value = item.nettoplam
                        },
                        Price = new InvoiceLinePrice()
                        {
                            PriceAmount = new TemelFaturaXML.PriceAmount()
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
                List<KasaListeItems> tkasa = new List<KasaListeItems>();
                foreach (var item in _stokKasaHarServis.obje.Where(x => x.faturaid == faturaid))
                {

                    tkasa.Add(
                        new KasaListeItems()
                        {
                            KasaAdı = _stokKasaServis.obje.Where(x => x.id == item.kasaid).FirstOrDefault().kasaadi,
                            KasaId = item.kasaid,
                            KasaMiktar = item.miktar
                        });


                }

                var t3 = new AdditionalDocumentReference[]
                {
                    new AdditionalDocumentReference()
                    {
                         DocumentType="Logo",
                          Attachment= new AdditionalDocumentReferenceAttachment()
                          {
                               EmbeddedDocumentBinaryObject= new EmbeddedDocumentBinaryObject()
                               {

                                    Value="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AGxmZgAGAAAAAAABAC9mZgABAKGZmgAGAAAAAAABADIAAAABAFoAAAAGAAAAAAABADUAAAABAC0AAAAGAAAAAAABOEJJTQP4AAAAAABwAAD/////////////////////////////A+gAAAAA/////////////////////////////wPoAAAAAP////////////////////////////8D6AAAAAD/////////////////////////////A+gAADhCSU0EAAAAAAAAAgADOEJJTQQCAAAAAAAIAAAAAAAAAAA4QklNBDAAAAAAAAQBAQEBOEJJTQQtAAAAAAACAAA4QklNBAgAAAAAABAAAAABAAACQAAAAkAAAAAAOEJJTQQeAAAAAAAEAAAAADhCSU0EGgAAAAADSQAAAAYAAAAAAAAAAAAAAJYAAACWAAAACgBVAG4AdABpAHQAbABlAGQALQAxAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAACWAAAAlgAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAABAAAAABAAAAAAAAbnVsbAAAAAIAAAAGYm91bmRzT2JqYwAAAAEAAAAAAABSY3QxAAAABAAAAABUb3AgbG9uZwAAAAAAAAAATGVmdGxvbmcAAAAAAAAAAEJ0b21sb25nAAAAlgAAAABSZ2h0bG9uZwAAAJYAAAAGc2xpY2VzVmxMcwAAAAFPYmpjAAAAAQAAAAAABXNsaWNlAAAAEgAAAAdzbGljZUlEbG9uZwAAAAAAAAAHZ3JvdXBJRGxvbmcAAAAAAAAABm9yaWdpbmVudW0AAAAMRVNsaWNlT3JpZ2luAAAADWF1dG9HZW5lcmF0ZWQAAAAAVHlwZWVudW0AAAAKRVNsaWNlVHlwZQAAAABJbWcgAAAABmJvdW5kc09iamMAAAABAAAAAAAAUmN0MQAAAAQAAAAAVG9wIGxvbmcAAAAAAAAAAExlZnRsb25nAAAAAAAAAABCdG9tbG9uZwAAAJYAAAAAUmdodGxvbmcAAACWAAAAA3VybFRFWFQAAAABAAAAAAAAbnVsbFRFWFQAAAABAAAAAAAATXNnZVRFWFQAAAABAAAAAAAGYWx0VGFnVEVYVAAAAAEAAAAAAA5jZWxsVGV4dElzSFRNTGJvb2wBAAAA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eG1wOk1vZGlmeURhdGU9IjIwMjAtMDEtMDlUMDg6MzA6MzMrMDM6MDAiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6MEQwMjFDODZBMDMyRUExMUJDQjRCMTVGMTMyRkJCOUYiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6MEMwMjFDODZBMDMyRUExMUJDQjRCMTVGMTMyRkJCOUYiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDowQzAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgcGhvdG9zaG9wOkNvbG9yTW9kZT0iMyIgZGM6Zm9ybWF0PSJpbWFnZS9qcGVnIj4gPHhtcE1NOkhpc3Rvcnk+IDxyZGY6U2VxPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0iY3JlYXRlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDowQzAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgc3RFdnQ6d2hlbj0iMjAyMC0wMS0wOVQwODozMDozMyswMzowMCIgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIi8+IDxyZGY6bGkgc3RFdnQ6YWN0aW9uPSJzYXZlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDowRDAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgc3RFdnQ6d2hlbj0iMjAyMC0wMS0wOVQwODozMDozMyswMzowMCIgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIiBzdEV2dDpjaGFuZ2VkPSIvIi8+IDwvcmRmOlNlcT4gPC94bXBNTTpIaXN0b3J5PiA8cGhvdG9zaG9wOkRvY3VtZW50QW5jZXN0b3JzPiA8cmRmOkJhZz4gPHJkZjpsaT51dWlkOjYyYTliN2E3LWFlYmMtNDk3Zi04NTE4LTA4NjY2YTM3Njc2MDwvcmRmOmxpPiA8L3JkZjpCYWc+IDwvcGhvdG9zaG9wOkRvY3VtZW50QW5jZXN0b3JzPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8P3hwYWNrZXQgZW5kPSJ3Ij8+/+4AIUFkb2JlAGRAAAAAAQMAEAMCAwYAAAAAAAAAAAAAAAD/2wCEAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQECAgICAgICAgICAgMDAwMDAwMDAwMBAQEBAQEBAQEBAQICAQICAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDA//CABEIAJYAlgMBEQACEQEDEQH/xAD3AAACAgMBAQEBAAAAAAAAAAAFBgcIBAkKAwIAAQEAAQQDAQEAAAAAAAAAAAAAAAQFBgcBAwgCCRAAAAcAAQMBBwMCBQUAAAAAAQIDBAUGBwgAEQkSECAhExQVCjEiFjAkQFA0FxhBMiMlGREAAQQBAwIEAwUDCgQEBwAAAQIDBAUGABEHIRIxQVETYSIIcZEyQhSBIxXwobHB0VJicjMW4ZIkCfHSQ4OColOzNCUXEgACAQIEBAMFBAgDBQYHAAABAgMRBAAhEgUxQRMGUWEicYEyFAeRQlIjECChscHRYhUw8OFAUHIzY4KSokMkFlOTNEQlJif/2gAMAwEBAhEDEQAAAOhsGMGADgFwLAVDIDMDyDzDDAeAoAoL4LoL4LwSMDGDADEDABkCeMfOnfl4yOZ3LD0eiMnZBWAPkDgvgsgtAthI4NYMYMQMAGNfoNEpG1PbZDNC3AIirvJl11s72dX0Z11ND1kQxa8i8C4CuC2Eigzg1gy+cMJ6OesVF4W6us91BQ2tj5g9/wD5Sktb1jzpXLne7L7/AEk4lITKGKSFcFWpFYFYFgJDBpBtBsxiMKFuJOrSeD4o862vnB3Usxt29/XnGSuFhOg6XvF33x0BRK536r54wZAyKYKgLIPoN4MiBdkR55lqYxTWr8uvoLQPgnsiTK5r+w9LVyf3NsROk2r/ANJWNKNwwbb19l/mBGMLlWTN4r6WFC1AwuA8g4A5gMruZ1O4l6po3wx1zg1FnYHUXN9xfr3zwzWQzwD89rZoHxR0xVPqm7bx9q8m3s+ifFJ2zICm4yoApg8A64w343fMMkqFUFlVR4/6TZkiSRLEiZSSt5Nekw0uzAiSyLWeVEZKwy50DTRux4ZlT+HKSpOpA5BCbanaUO/VhBGbfLYznyFcwRDfnaMjqtBG6G49jrZ7Ak3P7zgx6fq4aulLpiRaGa2ZOiK8n7V4xILYOjuwO+GTdsaMmi+voxr3iyGt8Cb+uO7pfy38qRrtB6pl/N/ykwX6nS/fp0u8833JbEhLsyzMDn0rJi6v+qpVyq1bEhLodld0Tv227GXBqaiDBzd1jHNh63bsVy9ao6Vbe5nsGYaIuWGbZTbzlSivEdNa90Xdt/fHa3Tzc04x9GPRkg4p6Th3RreMm6O7NkqmDCFB4826pIJHnRHulRB6hCvDbVPF9xHlTY6bKLNS1VpM5xaNwnQjpzjUOybFrKcdLsKYqm6E1SlCbs+u6fLBg0H3r153jFgVO1n8jR49MPrzrNrmo9D9Jc+Waq1k3i9V9V23tuz18FT2KWvCR4zRpvbrIujgqGSJhRgsLnaXy1/VqGsGMD56iZjj2tuA1dtwtC5TypWKAIC2CqCuEVMzPX+IRKUbIsfOxrqBzjQEVwuu7K2HYFs7Msv3btM2y6VMKja3r1/nj2soEHhu9r/grvCIJFzO3Vnrivsl7Xj9qyz/AEBfRj37Z8eTKXShQ+HE9OYArCqkqMM3ts8zBMZFVes6rshY9kQLXcOvLft7QLFofIEumZd2d2yZzRaMLgfYMgMgMQMAG85J+vWChQmPe/8AbD+nrx3bwefAPX4A5yABZBbBdD+AzAwgdA0BUCwZIZIeYfAYoCwEgAAIC4C8C4H0DKDCBwC4FQKB7h7B+DwDGAeA0F8AoLwLwAA//9oACAECAAEFAP8AElEDdO3bdgyZu0JFjbJtOtVWnywz9V67h3/T+msAClUrcjZUp86Za/xUvIXTG+a14NUsVxByV7jxDFVXruiRlzsJ0ypH/oHN6Spic5f29+Qlrk8E2Ve7Vu25bw31ZGg3/mfo7S76RxX1GpM+PGu8nbjtEnn9DgM3ppvSHSkgyRe++YoGDVGGsU/qic2MntSXMDRM1uOIxNzukRAjGt/pwI3MovHCQvF221Wja9aebGO1tCk3DkHvoV2rwtVZe9IyLaLRitApEsqQguU+aeFsq28RbA8WvGoxdVRLM6bb1Dwurxxa1r89FuG7qOszLj5D51I6YGkZfGMpTk/gse6gLo9thQ+Z6PcARIe9ZRm+lNNA4b3uFNfJPT28jf7ElU69j2ZP9Hlc04wRLSPleOdRXYcgeNZo5vnNnf1Kxu0RUWx3hFOW5vnuPZtmTYRER9wfgB1W6RJrQqlBBYtf1Wab2ri7ye1CxJePW3Sp4vx9MGCIcC6wsBOCtQIVxwPrDkHvjmqC6j/gLPKFpWF8vMl6jdG3iDGG1WrSfST1msX4h7P06kZhnDJMlIufa229M6fIvnayUNG6PqdjUqxNFdUzDNDsM/MwFkslw3Eexh3+8z1SiQntpgqznF1Lfa7bddlIOy1959zhZK3RjGaWUgIUiDhJ0l0AAI6IQqlZzSWPHvNOZKydporwZmjZnd4qi2OlX2GvZLkqOPbVxbhfmRiEkx65XuBJGWHSaqyxnEAc1XM2DM0rRc+c/X1F45TmNVc/Ov8AaUUm6CXQ/pe2pFqxKruo9ksySmJrD35zweaQTN3qsPAw9eQ5eFbFr+MoFcZGTi3UWzzlyf8A9jRsDoLGI3uWLBUdC4LMs8xx8ZKiM28rOWLLlQ+ydu3ttiAOa5DtCz2d5DEPmZMwgJ6CuErk+jhcc3pmmQs/tWbyWm1mg1x1UacCqZVNryGc0p/GNhYsNMzi0XS2XKHRUpGbR89C5/kUYumfPVix9k7iIexVJNZNu1bMyic4dGADh8soCJj97lpUTTTK65OHcXm5bdJ2fI4nRGUD13OHRVDlA4AoJEk0gGGj/n9xH2dwL0nosANnZPGb9D2/9JetwM+3LiFAIqxZtY1kbuYfc7CPUzPw1fYutKZJ2fsXuYRAsnmEjBwFWQs38lb2+7pVyAtDxxMRGmVp/Ht7BCPHCMgzdPDiJ+hEifRpZgEom/YLCElF/dVdGaLxP8zsj6XUmp+z5tLt/uBXWYvb4b1uvl9GEQBzGxr8imaVQIAa7bG9oUzSa/hDyi2xUF4RshX5UkXIZm/+4N2EfPrw+h1daWgj2v7ihZxoVlSYNqdZl5mFoFWhECEKmkBjn98P19Q9n7NOTZLs2jhkui2WMVJEhiGFMAOPqD1dv8r/AP/aAAgBAwABBQD/ABAAIiBimBqku6duW6zRzWosZ+yWGOCGn/6pO/qs8AeGdQQ/MmuQ1PNU9M4uVILHqmsNhZaeBk/VN0l9WYcQEo/0O/7uwmP2EesZrsbsOVIViag9B5QZ08t1P4t0Z5V8/wCRGe2d3tub4RV8qh7ncZi6XBNP0FTYu1W3v9v3UJag2dK4cVtGq/XGCl3SraXK1SrTMsWRboqJyLFMyLohkt+rdvt+awXFXTJZS0QOM46E3YpexL+9HsVJJV9RrnGpmOkipxU151YUnLn6dKSsAIFfW9NMSXNMwxVmFUse+B2TZ5C5xeffwPRlDM8I1x+2lKg0rQj/AN/uCAHJVtCvNJc0/k3VJo1OaURy0sEoZDq4WtNmMzeDCo2t74o1W5HE1blyLg0cJna6pyqjKu/uOm3m+qAAB7oj2BNBZXqKpFpmBic0zWN6rXIDB83gZLl3Sh6X5bMg6/5fziYDy5tBh/5YyZyteWaiJ4/mLEJHs2ucb9ITkKLksqeRzyyMzKNHKJva7eNo8GUwR6lM2Nwk4BX0tjvJdyDUHpmME7cHXbqunUt+gzi6qBBPLN27F8D1s/m3RXDRUXbV5MtGD6QmzpJIroOU+gDuNs7HZVx6ZBzLJlM8iT/OiYV+RkMa+I9IuioxloEgFTFVI3VgADg6dtjRMYj9NFJNjLxsEYTR/wC5WcWKawSyKREE/ZZ+/wBjIkVsm3R+6rVxUopRbZE0gkigkM8XulHCH0IQqAKTQB8xvEMilsCqYMlXYJRcOcn20E1VnNZEoo+2Y9H2yLTB1W6w3cEcQTdwRweKfkcxrOSbuJVuZ0gxS+namEC9SbJw8FEokRk4129ePGpVmUb80I6vEE6cE4FKVN27+xVJNYiaCLcgCcvQmUEBEvYA7jfthgaECm52lw8tNq26cmspj9EaV72j6jCUClBKIjEHId+3Qj2Al/r57K1ctXrf2lMJRsFWrtpZpcdswRcx7FpEsPj39z49S83CQrJ1pDJCydg9Z+/olc2l4mtVJazPJ9vebarVq/aZFzYofT6pKRCE5FOFUJmPcLCJQOAdynfIpSRX7A5hfsiSYaG0WjGl4s0lKqTNmlc1mmCTtI+ePruPrc/K6MUpgUbtFDf7c1hvXBhLQjZkM7mGVI/h1s9Tuux7etzi7SWzpb7l/G4qbTgtTq4yUQFoLINrYNBtKaCFMsTiwQVBq1dblN6Se+HwER79SLNKTbKpFUbLItziUpRKZZQSFMb1B6u3+V//2gAIAQEAAQUAasyiVszL3asid0WPcUGJw6QZKdk2SnZNiYeiMB9JmZu5o/uBo8wisyU7LslOnLAQB0zJ2dMy93TInqFqHzmzXuDVmPdqzHpq0N2bMx7N40R6SjgErtBFkxaNEnTWwuUq/BVcykvWFY/4rRxhIq19RXLX4OmvT1oIi6a9hM0/87Jt0zbdiNGYm6ash6bMh7Ix51C0iXbWJCTYGThuMNnC6ZTy5nv4tk+RAnK5SaPKCsPZo+32B2yETuWQ9nTIQB017g8bfuO1/uWTbpoj3Ixa/Bs1ACtGoD02ZiUd9npXDdPc22uWXMeHupsKToPMHRW9y0jjLo1PY8fdR5FWDXpumZ9FZ/TnjIhQfHZpOnbX9rhr+x61/adEPqGSJumTb9rNv2Bo0D0aKx1CqJZ/zFymyhy9uWbWjFYe622vwBWahjqsHvoKgRPrjRaaVS9VuPMnGoJCnWXcN1bxdShq2yeN/i6QEpXqJvSdt/cskB7sG49HXQjEIK70mTcM2p1S80MHY1ZyJTCerUJ3LKQuPlMRxkBCktWWnTCSiFIt3gERm0nqDnR8sBCa5AYwzWY2dzZE3qXqK9QH0mQH6hg3Dpg37dMkSlPbclz3R2124Z6BBJ32Q1NKWokAMs6zajEcEr+esEkntBiFCXjPEALqFNIiVwmZJTH+FFhtMdUMdzvMkX6AGK8a/B8gAAdAv1LAgiLBE5gYkEoyGh0Wuqz2xbA/StHETlXsFlhPHdqyANfHhKq9f/OWum6L45KSKQePKtkPI+PMV05bxr2ApKtgfMDHiR9+3WJAml1l90uok5TkEVCidMfqWHXJ7mLx84WUfhzys4/c4sn8kXnBtPArkRO6lKzfEzF/K95uOVkrxPgPJvo3j38EnOXd9r1XDto33mB5lQ+Cfnj5Q7VxxoEjtHmvwbj341ucqHPTjf5DfOtyY4/ct+NGsqchuNnLjzK4bxM5e8nOV/F3hwxyvZ8j5CUM6Rfq2H6/kgxqa/j8/Gr36ayPkf5law40fyX+KS4LchvFB4cObOecC+QHCLnpjHPeu8loZ14yfLV4A8WXjs4LqOZqE/I6Kg8Ych+f/GWG8OvhbZyvE7xt1PGJjQ/HH4cZ5pY/GNq0vFcgvyELZ/uZ58vJlVaDTctpJ/8AUsBL389sUymvF/OkkMHwnOsvg+ZPMz8YPUlJ7jn4p+OucXbyZ47gWL4LH/kT1hg5oXi2YtFvHnGeAXAIpz+Q+9OXQOLfhS4WIUX8gjYmOOcLH/PcKz4z/AxfEV/GzF0naOTm8fjMXytS/Hh+YBE/+pYqB6vLxANbB4z/AB+4YpzR/H8/GYySyxJ/B1xf5R8Xea1u8Unk7gOXnjO4feSvEd78nfCe9838v4WYhP8AGbjEZ+iYvlZ8bu186LZUYhaqUzy0+PHmXzn5YeTDG3GiePjxoMt/4w+Lf8b7GS2CZ8BF1mMM8jD9VMejrE+oYrl73KiUXVqViOMY1x7prJ8uBGSiZemjshTtnwFHnB5Y8U4bSdi81HJixW22cmfIHuTnhrVuVNazxZ6UOnDzsD5wBBeO1QOdFoydDwH4YxG1yThMTHUL9QwWKJoXd6U80avT8NYI1o8KYzR16QbOfi3e+gNvwDC+SFPivBF46I+xUepUrMKio8J2Veh05em7u3frF257neqlN1fr1V6BBznICFZaCZdP6pk6MkErgE7VaVki94lNKg902BLMs31WyvLfSeVGa2euwuo0Odds73BSMgMgh8s8gJulLtBGsZ7JDHUc2yA/krrklGStVHddSsNjd367X3j7a2iB0JDFZPVnJlHv0rJz1HPBKIN492dphGdoZ8nRNAZaCjxztzfGV8o2RwqvS64woF5l6rauMc5Kzz2h1LR0qVyjydxM0VDUnFnQ1BbDdDSYEyzQ3VtruQ57S412umki9dGEp3X9wzc+kGTr0dNXod2r0OzZ6HYjlNTorv1DYo9nbK6uqi5RUUZuQO6IHR5EyabqRFQXD0RFw8AQdu/SDx4A9OnHwO5H6ls8Hs2c/Fq56bvBL03kDB0g/J2SfF9Kb4OiuyCAvSgJ3wek70ogo9IUF3vSz0e7t4JgdOenLkO5nfddsK3ZsLru1F10iLrugZz0iZbpI63YDr9FO59InX6OZx6TGc+k5l/QuZx6Vhdd3QuunQuenIuu4it83//aAAgBAgIGPwD/AGgYfSa6eNOWZGfhmCM+YI5HG4X04NLaB5h4ERDU9fJVqzeCipyFcWG5WxBt7mCOZSDUESKGBB4EGtQRlThjufuSRlCbft1zc5kAVgiZwDXLNwqDxZlXiQD2nvZ/+82+K5Ptmht2A/aSB7T4/o019Xhih4/4coMgSqkaj92ooGry0nOvljebCdVg7i2a8ktr+DhIkipG0TleLRyxFZ45B6X6jUzBxvkodZIhYXRehr6Pl3NP+21EYclJJx27HcXJk3bbHaymBB9IR2+XJP4TAVJbgulgfhOL2x2+Ujcd6u47ZF8bcwtNclj93T0048SyD7wx9OJ1OrTstohp4wxrbye5ZI3Hmo1DI4+Xt3EsuksdB1AACp1HID3nM5Y7m2ftaaO62nZ2WO7ulyjWc0LwxOcpnjDIHCE6WJU5g4aNHLIOBPEjx/wS1MIzQuPVVgBqKwcDNyqK1GgevLhgZBlqOIqCK8x4HmMdgfV7ZYXfZN5hey3WI59cW8mqNnahDzdM6EOgFYYtPqpUb33j2zukE/b0223bK0YoVLxGsbZkFo3ohqVzOQxfdt9z3Bte3d+txCWkYKkN0GKxiTiF6sbugcsKaw1DpoYe1NqmB2bZbdo3ZH6iTTSyD5h0oqgBEihiXM6hEzDT1NK7NN3P3TZ2Um0XNzb3KzTBJBWaSaONVoSzSLIAigFmIooJxD9IvpFDNYbJuN5HAgCmO6uyZFB16PVHEgrKrdQOwDK0agg42XsXY7ZP7LaRkMQNLzSli00sjmrMXn6jDUWIXStTQHCrLdQpcOKqHLAMPaqPT2UxHt093Em4OKrCWBnYf/E6Ka2SL/qTdLOg01I/wKHhhvqD9LJzuCw1lutlmIfrxKAJL2ykqvys0QGUZEqykH0gnHQ7saft3cQfUbn82A+aTxjQDXj1dKjmcXKdv94bduW7ruMMtt0J4mmjeQOruI1JYIFYqTwBYVzIx3F2h253DdWnaF6BFNaxPphJShdlFCVd2J6jKfVWlMETzwQ27PqaPMBmXgzVYknKooRTETDdouoDkeJz4Akk1A4DywIjpmtq1bjpdq11uKisg4K4oyjgQc8bPvnem4C12232+9+WcxvIsdy8arG3oDNUKz0ZyWJp6ssFtpiv936SKpWGKSJSemqhnnm9MamQMSQjEkk4t90tQvYf0ylzSaF0uNx3CuYFnMV0iEjhP0wDnQDBstotiCzapJZD1LiZvxTTt+ZK3mxI8v1xeXazmBTmY4nmoKcXCElV/q6cueWgccSQ7d3jYtd6s42kTWpoMmRhG608DGvsx1YtM0UtPVGKo+k+mmmoIU8AK0NcWX1a7at0h228b5a+gCBEikY/+meOMAKep/yZiB6paSNhC6qaDiQMgKHjy4A+7FxZbYuq8VjqpxLtT1CnEmmZwZrG2c278CS1csjx+zBnltqhc8yeWfjj+29wwZFxXVWmWfPCbhYtkQC0Y+EeBCjnxxssf1J3G2t+3ojWNJiY45blTWCGVx/5TEksrekHM8cBLbvvY0sOmqFVvYdCqv3KspIVeQY1AwltB39aX96TRbewS83BpT+FWso5mrz9JByzNK4S+2Ltbc4NrYVE17CLXUKj0JbPIZ+eoSSQrkpBNTQoZlAkpmB+rHKvFTWnjie37x7Rtrqdh6JXQCeI8QY7mMrOoBJIjLmKtW0VZiX3P6M/UC/kdsntbq+ntpdP4IblH6HTpkFEUL1rWTiS2x/US/3XrwEgW99PNI8QGRdRRkdD91wxRuTHE8ImVZJV1AE0rUHnwr5cfLFvvF7FJOjSjQVUsFBJrmKgVoONMQz36GIMp48ePgKnDxQtEZ6Hiy8acSCf2cfKuL+5jsYDFQFWXSKHUKEEsAKHPxPLB7b3O6UlHoZGIAIJIAqTnTyrgNbL1hIFP5f5lS5IAomrM04cudMWPdX1KvTtWxSxLJDFbUa5dGFVM7vSCBiPiR0kceNcJB2l2hDb38efzToZJSf6JpAJENCRWlaVHPFSc/1i81yiAeOQ954D34ZLnd0nvtOoQWge8nZcxURWqSuMwRRlUZccPY/Sn6KbtLO5rHdbuILGzYcyqyTfMAVqKSRI1RWlCMT9297b1tQ3WZNLa5tSxRVJFvEkMZrDGSTHWkjMTUYX/wB0977KzNkKW1xcAA/dEcnRGrwbVlQjSa5W9u/1RuAiDJYLNbcR+IAFw+qviaEUpTPBe4+pu9vJTNqR0PIDNmOVKZn2ZYT/APpfcgIA4SQClPAdI08hnTzxKzfU/uJyfh6htnFOdVESE5cMxTjQ8MLcW/fdx8wpJ1TWMMuZ/wCGaIg+Jq1fAYhhsfqZZXO3LWsUtlLAC1PT6knmGWVfRiBe0fqDsk+zIgAtGlnlgYcgUniXp5ZUTh4DCr9RPoFLeyc5tpvYZ2QeKQTyxNK39IoaVIzFMLFuUO47LuBH/J3Ozns3rUDSruhhc55BJGJAJGQJxG0dyhDiq0INR4ihP7aHGYz/AEV5YN3uBItqVy4muX7zg39pM0kRYAKSpXPxAGfsPA8cSbNZ7Hbt6lJKoI1JJAOpUKhnAoSxFaUqcsXd5YhzL8uJEQtkKrUiq0YAHwavni9s9jsYpJog1WESBgORFEfSRw51ON+G83c0XcvraAOq6vSuXIeljw4Gnga47h2Dua8Eu5RKGjDlq+hiJAKk5UZTTjkfDG4bZYbxOvbllO56atRAiGgyNR66Ak8yxpTLB8DjtufZL97eW6aQNpJFNCIwpnzL0NeWNv74ut6Mu0SKrkH1BRU/EKmimtCDmaVryxFudAL5GKSAD0gqqmvvr4nG57XtdrbS2EDIrMyVbUwq2YYA0PA8aczjaN0CRxyzx6mooop/prn9pJGI9gkieW7kH/mfnZczWXVpHHIEDwzoMdedLW3mkYEKsYjLf1ELQE1yqfZhJ4X1RNwNKcMjkc8iKfoAPAnE0jLqdZCq+yooPD3kHE2z3yn16WTKlDqAr7SK0GfDxGN/ktKaYBVgK1rlnxpwOQ4fw2+RHJufltGo5mgLL/CuN+m3a4dLKVGXStCSwb7pOYIAyORrXG43W1wyiG1kVQXFM2BGXtBNQSc/2J3FDbhdqu453CitCXQhuNc9ZqKcCTTLLHcPfF5bqJ728dEepJMYFSMzTTqz4VPjiFV3GEyZADqpUnLKniTlT3Y7FSJVzFw2fA/lwV5jw/0PPadhsr+K43OexjRo1qwR8iS3nXICv2DM7tvO4hliYSzItKHpRxoT7iTnmTz4nHeXc04DXJvYdJPHSa150JKlcszXIY2Nx8PSz/73uwkDzfkxvStANGn1Gh5gBBx4lj4YUwxFtmt2KAkZEKRnUGp8+Az4HEcNrToIKCnDLj+2v6DTji+nL0ZIwSOY9Q5Y7S72gYIYwqOo4EF6hfPiD4ilTwOPqEdvKyBtvRk0DVqdmZqeZPhz4Y3Lam/+phnqy1qVUZcOQAFPLhjdNo3m0E0CC6EiHMHiACDw50HLliS32rbo7eFmqdJ4+3j+/HaV08ZNwLqUKRyGhDmfdl78do26kaZLB4yVFB+Y71NOVAaePLA3GPft2NxHL1AOpGULK2sCmjVpryrqpzrnjsK2tm9HSn4fhZ4lyPmK08RXGw7pdbU826NBG7B29IagYHT7+ZOItltbYIb11iCoeCIQwFBw1Gg/nibs+XtsxF1VmlNQDwIetKA+kac8vDFtKRURhq+XpJIPhlnjernbFZympiy1IVOFcvHIZ8q4u4pXTrpMa0I4AULePEGp5nPnjh/k5/p3aFuDRfuII/aMTWLxa5IvSo56lFVYe3mciDjuaTcIXF1K6AVFKhMz7qEBfZyx3Mr7dIu3Tlwr09Jqagg8+JqR7KY3juft947eWe4ldHLlSoetCwA4kUrxpXhkMT7h3f3AtztzW7qIxIW/MZoyrUKgDSFYCnjix2LbrqKKWO46jFxXLQy0FAebeXI8qY2Lt68kD3NpDoJWpBzJyNBWgNK0FaYKF6OoDHIii+JJAXIZn1Y7fvNu3O3CW0BXS7aNbGQPVaI+oaQK04Uzxa2ZzMUEaA15ogU+7LI42XcI5Yv7FbpGGQyEGoZixCheNCOeZA4Uxe2dlZL1FgWOKiBmGkADV4cP9M8b/b7jt80UwR2QMtDmpUUFfP7Mb7dXdsyxyIEBPMCtRQ+dDnQ8csbztE3pifVpHIsTkeXKmfswNQzAA+wU/S0Uq1jPEYZbSLQGNTzqcAxkKaZ0AzxpkZtHgG0/uGKqz182JH2c8KrNVmNAKcSeGeDbTQmbeSp0w1Kg8KsHI00HOuZ5DAuW7p+XhBqEW0eaEg56Ot6akHJvTQEEAmlcW77BFut3YsqlGs5WhsmY0KFQImZnSv5qs3pYMGFMfO/UbuS4utynzSB1hAhFa0Lxxo0hp+I5eZ/R6XoPZjSKaTxy4nx8sapCxf25e9aUI8sMsSKsZ5AUz8cR3SQ6bha518eOWMzU/o1GlB41p76Z08aZ+GeLrtaWOdLqOWaNZmglW1lkgjWSeOOYsdJgibqnq5sEK8WwlzYX8NxaN8EkbBhIv4wBwFfT7f1CP8+7wOPlt52uG5i/rFWr4hviBB4EEYWd9udoBwR5pGX/ALtfHEO37fCsNjGoCIgoq05qORb7x4tzzwpYkkfq5D/TzwNw3HcCYjIIwqLX1NmKniP5Yft6DYb57WGWziluB01VJtwUtZoYn/MeF9JElwg0REEHMHFOp6eGrLh+KnDz8PdhiOIB8+Xhz9nPBm2C1l3PuW9lu23C5MpihX5iQTXrRW5IHVvbSNbGKRV1xEtRgGOOwe3beebaO3Tt8cEjRIUlEk9NzmsoUOiN2FusFo1y6/kOZyrh2fH1H76N/OLG2uZjZW97axx2j2yXLJA1tdRMs8jSLGFYMr+uTTQ6wpte2N9hjg3b+zpcz+qojkZ5Iwpdo4mBbpqQGRGq3A8W2rcb233LbLS+uBDbC8thE00rV0hSskocNQlfVmBXkaLZ227xvdmN5Ah0qxSNtEjgEglY39DkZK1VYhhTFjbW1wsvXjaRGRgysq09QZSQVzGYNKc8fmhaFtIpTSTyA5FiMwBmeOIeo4RXOlScgSK1C1+IqASVFTQHLI4TZhcSPuLKWA6TKKAaqk0FKgVHjyriMQ30Dl3KLpkRtTqNTItGNXVQWZRVlAJIAxYbHPuGi9u0kdEUamZYqainM0JAamQJAalRXet52ratwuxYPKsnpitIh0SwlKyXPTR40Kn5hqlkI/Lyrjtaz27advTb95295onkkn+djcW8csbTxKegi9aRI2yAqdDUJpjtrvy/7g3i3a33O1W9UqtnbvrmiFwYOjpE0Cu5jDF2QBZEIqpp9UPprPdzPul1etfbUVjmZz1NN4FF0oMUKK0T28cbOvodUQaGAPb27brZXO071Dt5tJGuJepcpJC0c9rfwOhKl4ZlljQSHUsbMq0VyDr+aPz2mvVoK9Sn/N08K6/Xp4Vy4foJCaj4YAubResQwDHigYUehHqGtSVJXPPF12vZQS2ux3NzFK0aTSyqlJY5Hp1cx6oUbSnpzqPVqx3zvlj3DD8tuto4hWRJWeB4oZUgjJEqg65nExYAKukBiDjtrtq12RbJrCS4unK3T3LfOQWyiyaEyuxjikmkmVkWmn4moDqOxPPZXEW5ybUm1NIhGqJb2F7vdLqoOZguEkIAOqVqdIPqWq2V7uX9r2aHs/bY0u72IiHr/OzSmOaRhURzJHGLiBdMkkeXLH04XdO14bTZpNztXe2iSZUWBjKizRsrLOY5aGSNaErG4GYocWFnvNhNGsGyTy7IqvcI8k43Mra6Ueha46IgjET/AJjxa20lJNR32137alvN8l3i6jDBpxcrZw7etzC0S06LI+mRHYNRDVDSQquO3bq92i8hgtL2z3Fm6byahfWE0d1IqoGb1ylXCAa1R9JUUNOy+7u3+3pL/bFhuonjV0t51hn6MkcsTTNGY2aWMh1NGoo1AChx9V+3tot1ii3xZxa3c99M8ccV2yvLbTWiq4VV6k46kK6mIzJDAntbftx7qjs7iws5ITHYRAKVNxDOEPzKSkq5hXVQ5Co54v0trOV4rx5DPbzSM9uB1mlQQQBuhEGeRpDpjVqrSo1UIX0dZQBqUFQ4A9NRlmgogJ5DLGqQes8f1xmR5jj7sGk0lacyMvAjLx4+VRzwbO/1SI4Iko5QFXGmQDSDlp+AEek1OPlZYNRUgpqOoLpVVjGeZ0kE++gwD8nEVjJMXUUSlCTmw1/C2n0DTQBeFDj8mFIU4aYwAApGaCtTpJ9XxVr5ZYABroVUSoFAiDSinLPSuQwxc6gRzpkfL+nwHtwNZq3+7P/aAAgBAwIGPwD/AGig44BUgg8Pdxxb2UdAJWCivNzkqL4s3JRmeQOLizuFK3MTlHUihVlNCrDiGByIOYORx2/sSVLXt3BFlmdEsoRnoPuqNRLcAFYk0Bp3BtY+K3vJICPARMV1U5VIpXxy4/4ykcjX3DM/sBp4nLG1XkaAbBudlHc2UtfQ6Nk6MfuTK3xRN6xxONgIGSbhA4rxBWVRw9+WN56UITb72FbyM1+Isqib/tibUAvEj1DLFrdyw1s9qs5JpGOWnUQtuB+Ji7vqAzQZnI47+iKkf/lbn2/mTPMnuKEE+By44VDMgJIAqaZnh/L208cbPuPckEtruN+NcEDA9QxGoSSROMauQ2ktSoFeYwVNKjwNR7j/AIOnBjjZC48Tp/gccK+XjTjjuv6Xbho/um2SfN7VIxzia5BMgY5flqQBxAqwyFcbR25u9r0NyN5bxAPVWkaOVQzohGa09QIJri33baNuM/cG0TmRUXOSW10fmGgzARquB6tQpQitcXPcG6rp3feZy/qTS8UCJ6A1SaiQ/mfd0V0+qlTukWy7Fczjd4oZISkZMWvQFk1SDIUALE08vPF73p9S7W3ur7b7Qzyoy6oYVz9WskrKxYKNOldJFc643Hu/e7lpdwndvTX8tIeEMcS0oiLFpIGebHCRK6KRw6jaAR5E1rie9jtZXsY+MwU9AH8HVfQry/0Q9YcTqoP8DVzxbdl/UGwFk8x02m4xHT6uPSuFo1TnlKSoAoKZY+b2J4t529QSWgok6LT4mt5iCwocumSx5DA/unbe42lidvkgd7iLTC6h4iqZHOQkVB8FONq7m3bZreferGZmgmdAXUgaQCfvBQfSDwIBzphZGkPzQUqW+8UP3GNM1plTwwxRV0MANP3ABlQLTLzwBFK2tSacKqDxUGlQtKinhjctg7NslmvZJomePVpUxqSWBBPqVvvCvIY6O4G022BtOh5ZOo+kU1aI1ykIBoASoAAzw21zXcnc/wBQAmayoEt7NeFZoBUO9eMQkBHM4jn3W51LGKRxqNEEK/hhhX8uMearq/q/XazhaETuPT1HKEmvBCMi3k2VMB73t66jtwtdRTWGGfrVogw0nh6iGqDUUph0ZwszLpIY0Yj8JBzp5YuvpzvMhkurVTcWc7MXklt0+IO7EnUOQJrTKmDITXP9ueeHUNRRUih4V4/64bU9X8a4Wk2dfHChZiT7cLVsxxz418cbmfp9tT3G+MuhirEGG2aomlioaiRRTSV9Qrlg9TsfdpJWkLlhbTSBnbMya9frLcS1M8PdN2dc2u3gVaScW1qiDxZrx4HUcBVRXPLDxbpvtjJfD0mG1lmudJ463uGBhrlpMcch41AoCQ4Hw1y/VeJhkwpXwxbzdtdyzwrGc4+o3yzr/XB8LueBY5laLwGGtPqf2Rt8b50u4LaKZq+JthCGj8wJH/FzpiPeexrHbVtZSNdxBbxDqDwDp6lPiSMsSRKfQPI4ZesoJDccuFOANP2YkjjlUnALQvpP9LEU9wzGIVqa+akcvMDELvKgOXEgfvIwZ+qmhBUkMDT7Cc/Zni97a7Ksv7nv8cjI7yho4oXFaqpWjuFPMgV4Vw83dO+3VxbuKCFawwx8/XElY3HlWlaHljIfq1pgdOCRyeSKXPvC8B546kO0mCwrpM9y6WsCtkaGWdo460INAxah+HhUS/Ur6s7farnqj2xpLyZSeGp416R5VKlhTicsRds9o7VuzbOhqqpAVZ2yHreV1XOnGtBilj2Hfzgfdmlgjp56lE1T5ac68cs2Nn9MLVW/6kySH7RbrT9tfLGmL6d7Ro82kr/4VUfYP54P/wCj7KFJ4FZTl4E9TPw4e7lgCf6bbGzf8LAfur+3GqX6Y7eR/wBKZ4afYj19mVPfg/O/T6aOE5MiTLLXz1SdM58KUyp54lj7r7Dvra6JJ1xiCFgfFpIpCztzqRnzwD2T9WpLbwh3GGdFc+DSRxyKo518aYdrAWu52g+/ZXEM5p+JoQyzonLW0YUMQpNWAMiXELRyKaEMCD+0fqLJdNSM8PPETWryRkNmVZkNPaDn7DlzxKZHM5ijUB5GZnALEaNVQdPMDxJPPDXFsqI1AQVUAnIHNuJ9pOCbMA0FaBf41BxI1wStxpr/AKc8TxXczPXMV5UyoPLxxcaJmWAGlBw9NB9v8ceeImhlZCzcR7qfvwLz5hmjGdDSnvHHCTuRqrTL+WJrdFQxRtQVHLEV1KpZjyLMVPtBOY9uLe2laajEABZZFCt4hVYAeGEbc94Zk4J15HkYLzCEnJa8vHPCz2smuBuB8eR/bUfoAxtrMKnrsvuCmg92EtJWrbkZDwP7+Hni9ievSYjLxpn7ePnhEX4gpH7wMPLcmsLmgHgf44kkQZVpglDRGB0jw8fP2+zE123wlmz9/wDPFeqKnzGLdKcGr/n7MNCKFtI/z+/Ej09ebD20y/bi8vZDWcvXVz/l+zFqp4U/mcdeb1dN86/hHL7cSRrQxRsNIoDQcSPtwkMagKopQcP81/Te6Fqw0U/+YlT9nHG1bhGaxs+ktyB01zOO44wpqQGXz9nuxOjMA1eHsFD+0YkgYh4YySPM/wAxg9GLScRNTME/wxBp8P4nAm6pB1avfWvji3DEUxHcEFmI8a+fAYSFBpbUMuBp7P8APDDWhFEbiTlQ+BxGNQqAa+WLoQKzFSS1M6CvE+A88XSrTXrHtpp/UvOp8Gn+IxKmkllc6B4Hz8BTnni6MkTBukQcuefDyxIJIWVdRzIoDmeBxK9rpCNXMtQ/uwXu5w0WkimonOo8h54ESOqt5mn8DiOKSRdY8Kn+GApP5pFQuVT7CfT9rA+OeIuimS/FXKnH7fD06s+NBniKNviAxC8ej5ZQK1NDWprlT2c/HDW6xqXAFCfADLli5pC6y6MgwocbpMYXVzGVzFOYP2ZYMAlWlMxXn5YNOH6WilXVGeIxotYxGv2/yx+W2knjljSzVQcBSlPfimnCqBV2NB7cTWc0TTb/AEokBBUN4sJD6Qo58zyHPBuP/dy2sPxBIrFriBK/dln1IRQ/EVRqZjPjjbW2BNzubWWMhXsJ5rawkampWUxjU61oszMR05NSaTTHV+o+7ibc5KFIljVOiOavKprcH+qQBgaHjw/TqcgvyNKYZQo0MMxgXcVrSelK1/bwxman9BNK4n7VYyi/ikmj6tKwPJBGsk8Zk4KYIn6pzqdFDkTiO6sb+G4s2+CSNgRIv4wBwFcssq/qVHHBsd/2a3uYD+JRqB8Q49QPmCMG6O2zPbmgMTXMxUheTLqzXLIeGWeLTa9rt1t9sgFI4kyRB4AcgeJHNqsc8EliT5mv6pIGDe7lvPSgDgMwQNpB/CPvyE8E8M8TduJ2/fyCKWwEk69MCJdxqtjqgYiSSK6kRke4jqtrIQJF0KxxpodNacRXj48K+fDnSmH001UNK8K0yxaLtkcu5b3PJeNuN112iiQ3DiW8khtywHUu7WNLKJ1XUg1AEBiD2J24txdbJs8u1m3d7aJY3LyIN6lihgkCRgpatbbe0oXVFIZ6FXDDH1K+oUO5OsCPI1hbzW0YtWt42kihWG4Do8zFoNEix+szPXU/UVcJ2rv8VvFvA2lbqfpyF4omMksYAkeOFgCIlPrjQhm0+r422TdpkuNrtdynWG0lvFaJ7yZ66IooQJFLPpbT6lqFJrkcCCPeYXlKM2mqKSqP03YZ5qj1RjwVwVajCmLOK1njmt7iJpEmRleLQhoW6ikpp451pkc8jirmPWXCAimbH4VBHFzTJRmaGgwHqOmRXV92lSCa8KAg1PAUNeBwm1PFJ82U1A0NAtCdR5aWpRTwJ4E4jRL+Bnd2RQJEJZ0BZ0UBqs6KCzoKsqglgACcWVjPKFmKu4WtC4FFoBX1aXKqcjRmVciwB37cNm2q/ubfbJZo7kt0bWPqQaus0M10Y0khtSCLkKxZzXpVocdpLY7Ft8G2bvtzXMTNJP8AMRlYIpo2uo3GhITNNHC7RNJUsI/iIGO3u/77eN3jlsNzthuCNGlrDIrTQw3HRWIhprdXakDklWQTdUa1y+qH0tvr24fdpdxO4bSaS6i0oW8Gi6MZhiSN7ea2iUzx0idERdDrXtjuTc7O42vf4NvktHe4mE13HIhSWC/tpIndSySLLDpd9XRdo8kdlx1PmP8A1uivU0ivUpXqaOFdfq00pXLh+ijJqHhhJZLQ/MqrqjgRkoHUh6FzVdYAUlfVnU5VxN2htcLwdtvcRuIWd5AmmZJ2K6slBkiU6FyqagVrjvferLd7ZbPc7V+gjJIXt5oYZY7dGYSqHgeR1mKgUUr6gDjtrYrPtdLZtukuLvpi8e6K30FsPkWgeeRjFFLO8yNGhAQHU4CmuO3B/a5Ev5Nuj22QjSdAubeS73G5qDSsV3EzgDOVn/LDEiv9n3S+i2ftyLtHboY7m5jlEUUjX8l0sU7hkUwXLxxxXNuCJmjJYsqVx9JJd22dLLZ5942xpLfVLbRojSXSiWNlJkEMuhpowWPTidA5FRjYpO4VuqP29M2zqZLqB5Lld4I2/plUZ3uGtflliLp15ErqhMchc7vHvmyvc93Xe8XkMkkjzvN8lbbaLq1lsT/yUsnMbwyxgMq3FdTLMypjtzcd02S9hFpeWW46ijyEpuO3ywXUgWMM2phIXdKawTpK1qMdi98bH27NuMEEN2DEXSDUl0IpY2KzMhBW4gXIivAkUzx9U9g2yzjS23pLhIrq4vp2gaC7dXkhksUVxC6GSYGeNOo+n4zqBPafcm49zW1rcbZayWnSsbNFRrc3EU6gtctOQG+WhyFSK50oSL21gtbq5s7t5WkilmYxohmaVIlh19BSzyNJrSMEaCuoaqFYlBBUAFq/GBktR/QoCCvIZf4AzI8xx92B+fLka8RWvKmX2+VRzxJbXet45AwkAcxgh1KsFKg5DigI9JrTEltEeko6fSOlJjGVahIEoKn8sBUyFGqeBwwW0hZFLNHqQDS7ElnIXIMwJSiaVC5LQ0oyNFHHGxzEShPTTMCoJUH8IbT94gtiNQ3qQUXIUC/hIpmAfh8BlhjIxeo58j5f0+A9uBqILc/92f/aAAgBAQEGPwBPy9SEk+PpufPwOh0/b1+P+LfQ+X8vqfMj47+Gh2jbp8ep2Pnv8dAAjbp5ff8Ado/b6eO37P7dev7B9vnv66PcN/D8o/qI0PLx6dp9T6HRHXbqPw+X/Nrbt8f8Px/zaV0BA8On2+Xx20fDz26DwG/Xw214j49PDx6aVv1H7evX7xt46PTb9p9D/i0enkfNXnv8dH5f5z6D46SNvzH7tiPHfQ2SDtsOg+A6eHTQ2RuB5hJ6dNvTQ+Q/h/uny26+GvwHx2/CfJI+Gk/If+U/07eWtgnfuPgASfDfyB32Ggfl2IBB8jv5g7dd9TJTiFrEWM/IKm0qKW0ttLJU4oDZICUk7nwCSfLUWVDWHI8yMxMZWg+4hbcppDyVtrT3pW2tK90kHYg76uruSEJZqKmzsle4AgOfw6E7KLaVL2ClrKAAPElQHnrHbl9Ozt1T09jIBGwEuRVIefKOgAacSUlPkTudHYj06fz+Xx0sjchO3edjsnu327jtsnu2O2+kqSApJ/CtI7kqA3G4I3ChvpXQfd6H7PXR+Uf8vwPwPpronf5Vfl6dD6baI7dtvLb7PhpA7R+M7DY7nxH9ej8vp/4Hz6eevw+n9nX7NAhPkPE7efn6fHQ6Dx9fDoP59J+Uff8AHz/r0ttKi0pxDiEup3UptS0FKXEpHU9hO+3mNWUJbjUW+x6zcoMnqnlgKi20Rrui2LK1fK5Bvar2pLSk/IQrp11duLbHst0lm8ttXakulMJ5TSCjzbWkK6/HVN3vF+yxlbuOWhXugtmIA/WLKlbBSHqt5vtUOnclSfFJ1OhMOe1Z5fPh45HbHiIaQubZyG1dB88ZlKFfFQHnrjqaN3O/CqIKI26yWI4iudu5HytoaUCr+8NtFko/eqSlaWgd1rSQpXckb9UpCep32SPHbVnXYupE6nxp1yvvMlHc5WO3zqUGNTY9IAS1KmQj/wDlujubR3hO+4Ol9EfiI6bJSSOh7QAEjqPv0r5R9/8AT9vno/KOh38f8J+8aUe3oBt49eg30VdvQ+f2ADrpo9vmrp08exXl/Lront/Ztt9np56I7dvD1+0aT0PQeh+G3n8ddxHn4dp/u7+O40hKlttKcR3NB0lHf1PUDYr9v/GElA9dJKTssKHadth39Ozrv1SVbfaNYVyvSxVS6bLoLmI59VsxSVzkUa25UWWhBWptNwK2SfaUUg+wyG9ztvq1zajsmrGgl4rby4sxotAmPGrX1vxpaS6FRbGC2Vd7BCldNgTvpeJ5FJbhY7yFGjwUSnpSGoMG+gF7+Fz5zrwbREiS23HIpUSCl0jcdNtRsYrZaX6zBIRgJktOpehycgmFqXZrZdaBbcRDittNFQK+5aSARvqtlZFklVRN4ROvaWymWkqIHGohnvWVYWK5bipk1UlMr5G0JKv3ewPzbpY414khz6GryGY3StzuxyNkGTKmPtofW6vZTlHV/pmlyCyhZWWkHvO3hR4hRKc/RU8YFL7iNjOsXSXJtnLYCj/1Tr6lAjuPaEgbkgkkMIdcWCf3BaWlZHmUOLKUvJJPj4aTC99PvvJ72GXEqbkrR1Pepg7ltOw/FuU/HSth9nQ+h+Pppz5fUeB8dteB6E+X2beemvl81Dfrv+FQ+3R8P6x06/068/5unrpPTxAB/r9NtAddifUdTsNS8240UrJ47LajkHHV00uTFsWkJSHrbGZjATNg2kZAG0YKU04R+Hc6aj5UZmAWKmk9yLRtU+kW82e2W2i4jNkR3x5JdQAk+OksUuZY3kt27kFFYVTdNbRJNgqM2ZTU6a/FZe/VMBmI6W1HsSNync9Njd4tRZHaVeNZZHDV/TRXm/0VlHfLb7jLjbzTq46H+neWVNrUCRvsdfuo6lI+RQWAFEuJ2KXN1pUS42sbgnwUSfHXb7DygXS+O8lRS4tRWsBR69q1q3I+A69NFp+KfdUv3Q45uSh5KSkPhJ+X3kIJSlWxIB1XZBndgmsqa6hyFEC0kR35bUGzlxW4jC3EMMvvKWqLJkJQvbuBUevgA/8AwJzIMxsCl11iJBrHaiEAHFOuPP21ulhosu+6lQ7Gye4n12Dd4llnhrjUyXEJsY0RNnmF+gbFIpJc5hDcOB2n97LU17Q/JvpyHVxVoDp75M2U+9Ntpzv/ANafayFqnS19fwrWWvPs32OljboNz8T00sAevj93w14Dz8vDw01477q9P7qvhv00ep8B/wANAb+fn9h8t/LSJUiNNkMoJ7xBgzbAtJSnf3JMetZkTi0PVtCtj+LppceDl+OyZIdKXa5y1hx7CO52pBYchPBmSgjp+JDR8incblD7KVOBCUhDjW7qUJQe5ADjZWkBJO46+emeX8Zhqi1GQW7NRlNewhLEOHeymCIlrGiNBLSUT1D2H2wn90+PcHXW7CELecUELJAKikgghSvHb4abW+2Ake0lLfZ8iklASB27bbJSgAegGmwGGwnyT7Cdh1G+w7PM/wA+jtCV8qSQrtAA2BO4Tt4ADfbTikJCVDtIIb7VDqN9jt6aU26VL2KgkuAns6FKtioEDuSrY/DVUzyjbV9PiseG/O3tle3U2NrAXHXUU9i8UOIZr5RU6pxPb2r9oBXTbSEM5vhDDCWWg1FayKCG2I7Se1hpDSFoSllltISn5QNh4aS03nMCzlrIEevoGJ1/ImLI6NR26eqmJedI3IHw30JVZhmRxqtY70WWQe1jPvnoAGIE2U5aOhQUVDuYbQQPEHYEEdqT2nuQnr2K3JCS50Dn+YaHX1/4aa69d1f/AG1dfHW3TfoPuH2a3IHT+wjw30ysFSVoPc28n/UZJA3WkHcbkdPPSomYYvU2Lyk7s3bEZqDfxl/MQ6zaQGmJjakqUT0Uep69NOWvCfIl/OQwVqXiltkdlW2oYKe7tg3LUv8AhUqSD4NPstnYjdWv9s8j2Oaps6xKn0UuUz57zsdaPANwH3kxnEOD8MgB7u/Ks6K/bUohw92+yTv3JHgSOvXTA9p0lBYH4F+aVE+Wx6DTLklSWTseji0pUBuQO5PcFAED00S3JYV8itj7zY8jt+JQ676kLbT3hIA3QtC991DzSs+GpRQhXeFOdCNttgk+J6D+jQbKSpQC0BDezy/3Z+ce2z7iwBuPLbVNl/Ic9vGMes22n66mpvalZTcQpDYcjuuyShceljrQdyUl5Y327QfD9NhmLRKx0Dc2rqTY2zpAKf39tLLk1J7Ttvs2fLfrpY8Vb7n1/CT1J+310vceG/mPL08NbHx6/wA2x019qh+3sVoHcfi/pA/s0UpKdzt4nYdQVHrt5AaHeg9ANioe2hRAG/Y497bSyAOo7vDSY9hetvWIQCilooM/J7107rQAinx6NZzUpKkkBa0pb33HduNPQuIPp+yqdMWUiFkfIzcTFqbvO/fKZqJdgLceyBuS7+kCh4DfTuVZ7b4bFspUSLEWp+5R7VexEUPZr66tpa0x62I1vvs2CpzzXudAWXLWK0wG/Sir8glN9pClKU4qS3UrLgDZ+YuBPTqDuNm0WnPeTr3AURBrJcVISodfZ7sleS4k+qkjbQ93mLkd91X/AKpYrFd43ABBdcfcCUJI8VnYdPHppPdyjyIVFsdxC65Kiop+YgBBSkk+XUDQbhc18pRE9oUGw5G7SFEhOzjDkZpRJB+UHfby0luNztmQQe7pYUrU3uG6UgOo/icdxSQTuSTttp9ys5YpZvvI7O20xmZWJUlba+4qEOVZrC1FadyQFHbw8N2WcM5Kwq8qYuyTjs6bdTa6U00AjuEG6q45httDb/RWGx+XTieQ+DZc9aHfbNrx5lFRaRH0jfd1qmvJkWQynp4NulWvbsY9/h8xfyiJmePW+PlTpG3sNT34a6h9Z33BTI2KQT4DRcjPR5KHEktrjyY8htYO2xQ6w642oft0Q4n21juJQSFEbhO3VO46g76a6j8aj/8AKof162HU9wAHqe3oOgPidY7yB9RmXWWI4vleSLw+llVuMXeRvTsmZrnrkVnsUrMt2Ch6tjuFL8gNo7k+B/CTzHwnMt8gw5rKMjw6xrMyqZePZBUXWN+yt1Fljc2VNMSPaw5ceXCeKtn4j4UUpO41ffTPxp9PWBZ3PxXE8Ryq5ynKM2vaaG1JyupNszUIw3FqWK9AUxALC0SH7V5TwcA9sAJUcm544kmV8+4tvp7l8ycbzZ7L8ypsf4jx63nmJOS4DzqFTIT0WS13IWQsoUR0Phf1v0/qgci2tBWVtzkGP8YcFcby/wDa1TYyFwWJrky8diy1tyZjawzu64odp3319RdV9ReW8lcYfV1d2WY2fCOV2CMJr8oqG4mOUVnitZGraaunUtXXWGQwHoTzbzbrxamOdqgQCnnng/6leXcv5JzD/bVPmWDqz2RAXcUC8ZtpuP59j0CNX1dYy0GJVpDdkJUhWymk9vaNwcxxnF+Z+WK7gHDuV84yGxxGhy/J6rCV4Hw06nG40KfRN2CYMePlGVxGWpLYQj3nHyrqDof5PH/4fv19O8PgnlXMOKMo5AzLPH7y2xFytYl22P4lj9Gwutlv2NbYKQyzZZdFeQWvbcCm/wAW24PGP1uq+oLMsx4JyQwrNr/cl1imdMVkXILL/b+Ptcj4pa4zGsWay9uClmNIiyO1D0hlCi2VhwNcmz6CBjPIuMZHYYRyXi9PIU7XRMlix4s6uuahuc9+uao8srZzbzDbqnFxZCX45W4Ge886cQ/T7jXDF7xtxJdUuLItM2xa8uLGZlNfSVgzBTllV5DXNfpE5c9Lgtp7UpKGE7Dv3J4L51UmrjSOV+KMPzWyagsf/rYtnd1ra7iLAEt16UiDAumpDTfuOqdDTY7lKVuTB+kXO+J+TcyubGTxZWHMcJk4ZYUlTd8qzYtfWUV1j15ZUt0zYVz09hbgZamJcZfC0p2SrWKW31E8j47xND5DyCbj+KvTYF1MXa2VXC/iNrJdgY3WWUmvqqiC4yZM1Uf9O26820O5athW8o8H8g0XJ/HV3Mt4FLl+LqsJFPZyaKUuvt48KTZ19QubJr7CO4y6ltv20LZWA4sjbTKe8fiWnv2Pb5jv227u3z28dtf+4N/s2Hr0OsJvFIQt6p+rLi9MN5xKnnIzFlhHLUKSzGHuJWBIRUBJQggq7dhrlL6TM5fVRUnOGBU3LPH1TZOl9p7OaGpqr1Lta+hxUV6qzTi65TIW4B+/TEjqSQnu7vroybH3lOQuEsS4jssjK/cfWzCqca4zwaW1EQhCnI/6O5vGlSFBQCG0q2221wvB/iH6q5h8O5vwPZyDMVYvwbTGY1/g1a1LOwUmSisVECGz0Q0EpAAA1yRnHMcfLZGA5hxRPwt+Lh1Gzc3rmTVubY9a4w85Fk2lVG/QtQ0XHvbOkJCmum2s+zDhytzKor+OsqhYzbIzWtrKyylP2VWm2hTI8aqs7dlUF1ltSEd7vfsgnYaa5spIU5rjfOpGV8rVMKMTHZl0PKGN5HSZ7jyH45S4uHjuXyTLQ13HsDMVXj483fU1kEN1N3ylmTmGUNnMDjrr1DjjzN7ls9qStZW6zY5ldORXFuH3DJqyVApG5S0nkfBHFuJDaWU5jjoWtSwEpaT2WJ2WtR2G2/Xw19G6VLS6tE3nSQ2UdilJZkR+JEsvNISHA6CI57FbhKj5joRx59MGB8g4xyBzXmH098TcU5BgtJ+snyMBmMVGLL5HtsmlKbjRaadjf6aamEhx1x1+zQ32JWlDqkfUr9U3IkRunxq7vMv5YwuPMbSyL7HePsKZpq/IGVp7HnK7KsqaehxA4ltRSx3NgsraUfrx+s/OmFWGZ5R9QHB9FHvHf1TyTJcyybl3JD0dyUl5QYXkGXV0YOElTbcdfuEg6+khMUFJxvj+3wh8FSlBU7Gs5yqsdR8xO/uKc7NjuDvt4atLC4uMVi4XjH1V19TLvZiu/HoGDfT3j297KtVLV2peqn8YnpcdUSppcUdemrdykdvsZ+mLjmLFixprQfQMD4FqLT9K86wiT210Lkrma8U49Ga3K2XXUuKSlqGTrFOMuPqGBjOBYDj9fimHY5WoCa+mx+pbS3AiRf3TPepQJcde7ErkPLU6vdSydM+P5xvv18CN9/Hf4+OtiQfn8AepGw321zRMmtBSsdzbhXJ6pJUEdl5//Usfxvv9w/6STV5Q+33eRUfU6/7P3/cu4tr3GJuJNS+DM4cbZdjuWOZ/S/yTl9awbfp7Yh57xfDsKV1SiEyobCEI3O23/fwuMSnv5BCzX6fszu+O7CumMp/XtZDK40z/ABJMKUlTrKY0uXh8WM8Uk9ra1jxBGud+I5Uxx1PHvNlHmtEy41HYai0XIOMQW7MsFKv1Mh6RlWOTHnSoEBMhBHRQ1dfT9zPhGM8qYXjzv1C4vLocyqUTK+Rd8fSrGMxZmM262VWDcylJCtwkJ389WFNwzxRg3FdVaOMyLaHhWN19C1by46FIjyrN6Gww9ZSGGn1oQt7vUlJICtumvphzBuurl2MHOc9xiTaOMkzzTXGNwZi6ht8fKIUifVodWg/+o2hQ8Fa+m+LFhIiMzMDtESm22x7ipr99dtzZjhSA1KkyJXe6txX41npqqnHmzl99yqkV8vsMTFWmHl17jL/YoJri60y6pnY7KKkpPQ79dfTTRuqbEGt41z60YSsBJRKevKiMp15ppQSmOU1rQUeqUq26Hw1xRyfyPi2a8mZffceYHk2R45m+aSpOAIyuzx2vtrl+LjFPAx92TAds5K1phTX5MYo2StB2O+F8C4k5Bx4805xT44qqrmIUCvreL+MobOSWsGBXw0sNQ68XMWobShttDQbQtrbr1m/9vQfT7eUH+4srczOdzHb2U6D/AB24n8jM5yZL+MScaiPS438NbYr2XUSXULYjNqClAg6x02KmmIHHvJ/Mla6+8R7Ka+pvFZSqQ71ADXZcLUVdBsnfy19Q+V8KQ5dnk9g39SnPmdz6WQqqYh8eWFpkORZ3PctUJc9uLYQMgcisNJ2Mx+W0xvs4dfUzxzBra6Fk2OctY7mMmSzCiRbewx/LsTZiUzFhJCv18+HS2FC4iOVD246HC2kk76WS4le63fmC1K/PuE7ubL3QOh38CNM/av8AoOum+++4+4ba+rpic0l9FTxtFyeKjbu/6/F8lor6MsdNu5uZAQpJ9R5a5O+n9qJHkZlh3JXOd1xa04poSk57il/H5cxxgqX3obF7a5fOp1dFpW1JI7VAFOvrLtuQeOc0xJi8xzhLCq6dm+L5BSC5rLCTytOzGtrzeQYLdopp6BATPS0taUJlMFwtoWlZ+qCHm3BHIeJcB3MHkLj2t5Ey7FpmJY7d2PHXKC3cDnUCL92ttJ2N5LjgfVDmxIcmI82432vbK3HN3OX06QY2BoueZOV8nwbP2eVMWxO+m45n+SXd0+qvIenPwYcqPkDrSEOIQVFsDceOp3KH1bcyuZxgVzgl7j8zFZ/NGS8hyYt9ImVcuntY9VKh/wAAbdSIjqVuNOJU2FkJ3BOuOsF4+yvE8Pt8O5AOXyrHLG7VcJ6v/gsyveiRjUx35KZLkqShRB7UqbBBPXXEvBWV3dNk2Qcd0Euqs73G48uNS2Dz9zZ2aXYLFh2y2x7U5IKVjfuB8ttLAbdV+7We1SO3fb5e0gnvBUT6eGuO8q4nzvjnGk4Jg2RYw7S503krLljZ3FgbES4thSMyY0VpLQQ2r3WnCDuQNwNYhjz36ZyXj2NY9Ry1M+44w8qnrIcF8x3XQlwtr/THtKk77bb643yDD63C3Pp6xLE8Tw9mZaZrWxbWrRa5G7bcqXrmNvx2Jz0ydC/TsNMtOrDzcNOykl1QT9QvE3HGAvZ1kVTxbVU3FuK1FHHuclcTjFjQJrqykaVFen/rkV0Rbf7tBK9vHrr6+2eUOJeTuMMnwj/+mZJxvjXJHHeYYnd3j2T8OVECNJqKC9p4VvZxZGZSAz7rDK2grr3dDr60J+S1qq2FYceYPwfcV9nCcrLSKjOzkr+Uuq/XhlxtL9ZEaQ6hBUjv7e4jYa5U+n/KXxGXn/HvJPFV5XCQwt08k8L5lGvKhlD7m6pyqxNPkTCGI4K1uSSSNk9D7aFIQFupAKy4o9h7Sta1bKK3CO5W+xBJGw8NMjr4rT4efYT66/YPP4benw1kfHHJuL1Gc8f5lXLpcuw/IGDKpcjpJC0KlVViwFoLkaQlsA7HcHYjqNNce8F8W4NxDg7c962axPjylTj1Ei1liP8ArLNUVt6Q69NlGMkqcW4pfofRhn9S+422G0NtyXVSmm2EBQ/Toae70htQWSd+5QWe5JGkBvuGyEpWXFJd71AAd/VCexSEpAbKdloAHzHx13dgKCntDKuxTal9NnXVqbVIdUj8o9wBPpoH23PJPayegH98pUsJShAG6jv0APQnT3HT1Bk+bc5yIqX6LCpkKfgeFvRZA2YvrjkrJK1FMvF4yj3PuVKLOWgJKfY7ylKmbc/Vrx3xhFXMEmLgfHX0wWPImBIQl/3P4VkeYZk7W59Y/o4w7JMiDHjFSAVttI+VsYpmvHlby3lcbMqWrm4vffTlfZJXcC20BKv0z1jgz1NAj2U6QtZQbFeRzEyquYt2E5FbLHepNr9VXIByPLrlTC6zDEQKN5eA1DLMsoiXeXVcKNNy3JJ7r6DIffKmmg0G0KUrqVbDc+HU+Xl6+O+lI7WyFJ3BUkrWhXhujvKmknp4hAPxOu5sD3Bsfce3dWJKEuJTJCd0sFYKhuFIUT2+OisPuJKQSyGyEJQsqacDjiUhXvkOpUepBIV2k+r8mDFgwJL60OS5kCBCgzpvtpUkCXJiMsiSrsWpIW4hbiQogK6nUH6kMV+nXjnCudK7J7vNhyThsO2xy9sMuyRuyavru5FXbxoly/bfxeSt9ElDqHHHVKI8tKKUlKdyQlS0qI3SOm6W207Dy6Dppo/41Hb/ANtWgN/EpG5JG25AJJ7VkePXofsPhqz43MfI4s6us59CxkEyr7MNt8hpMZiZfe49DvI6pLka9qcfmCRIbktsoCELPybbah3GPXsG9qbNsOVlpWPRpddKKHXEyWGZcZ19mS9G3QlRSrbcHoDptISUKQOx3ck96xuSoAjZI2I6D00khXXz3H8v/HQ+b8w8B4/b00fnICh2nbp0JCiDt12Pb19fDTuE848Z4zyXjii6YkO6gtN2dPIkdocm45fRhFtKF8BACv0zzYcA2UFDSLc4vytaxGpTE1vGrPlHIlY6ewpcMGSIDbU+ZXLPRbKpRSU/L0HTVHgPHuNUuG4Zi9ZHpqDGseiJrqiqrYneWokSKyEpQgrcWtajutxa1KWVKUolRKiNxsANglKNxs2lKAntbB69o6b9fHR7FfbvuevhsPj014jw9Pif5zo9yvzHoB9vprYqJ338B08P+G2nh7paIR3e6oH2mwCnvW+4Wng20lG5J7dyQAOpGjkWW3bFPUNyG2HJL8aVK/WPyQpqLBr4sIOz582bOYdjMsRm3pCnkpBQO7TGDjFcnlQXLTj/AB6Xl3sxYMGFbcnw1y8Qkt0EyW1lE2nkLbVEly0xEswZSVIeA7FnTXj2dyj4ju7O1X5tu3ft89tt9KdQhta2wpxtLySWVOoSVNpeSkFRaKwO4AblO4+Gq9nFYpzfk/IbfLbjkjNZOT5DSUMOuypS73k9WK1KYl4aLJeRq+I1j1bJiVrrkVnYr7U9RwVx8w9K49wuZx/W8e3lhQuvY3f1WQWUKV9RGT4pS0zzLDNZ7WLsVtG/P9pMivdRIYSgP96j9RvOEPIXl0+Nz8ou+LsYzzBGncCn4vVXcqmxGDjWYVcyrybJZ96mkejugqCES7OKpxG23dH4zzfHKiuzeDxZjvJORW2J5DYW+GVLmTZRd49RYvHORVFRbKnLiU6rCQqQygoZ2SkrADisay+U3meI0Od5djOFce2Gc4y/QQc8yrMDZKoIWGzTKkRb2HYNVSwtxAbbYAUpRGx0zGrc6xyfMmRMlnx4TFi0lyRBwm7kYll1s0l1ppLdfj+RVr0OSpRbS242pRB+Yisraqexbx7nFZuaQLysXDtMXk0EGXEhLms5HFmOQFOSDNC4wbK0PoStSVbJOgtMplUYAJQ8qQkoUntSUla3FEBwpIJG5230WkrCVrV7Lau7r7q0LUjt33Cl9iCoDY/KknbYHTWHmU+b9VQm4jx0V89MZ+u9z2lTk2QbVVltbnyhpTypPfsexKeuorbd7Trdspc6vrm27eAtyxsKth+VaV9e2iSVzp9ZFjOuyWGgt2O00tbiUpSoiJhbt1Faymzp5mQQKR1TiZcmqr5sWtmWjakbKXArZNg0ZKUnvAUnoN9ZrmeFYDyVlsPBsgvKKyUmrpsQqJUvEXLeLmFnX3WZ3FbXTqLGpNK4ia8z7rrZ37Y6tlbcQwMfwfEaah5u47yDNsXNvkNzY59QP1vH0HIU/wC4aMUkLHmqT+P3EKvcfRMkF3vKkobUoa445xvM/wCTmXcTzvCFcnVcenRxZi2TY5c5NU1eYNV9bTB6VfY5gEuWpLE5qc0qW1Ec94HdWvqF+mgTryPlEnNLDlngqXErrZ9cKxyCFH5Lqv0GRMV0qir5VBntLPbbMh1j2xISoqJUhAwLOsgqcr44yOk48usQtbHNMhj5DylXW4lU97hOa1dlj852plzarKXrH3kzHj7ta6EFKEvON6QybBH8T/QFgXBjNe3/ABH9GWjbiH2+z7f6v/qPZ27Nvk27dHqPL16fD79JV8xI6D21dq0lQICgokfh33PUEjwO+q9c6vrrCVWyJUivnPw2S/WuTYj0aXJr3/YROiypbLpaWtLvetKiFLCdO8S1SMhx/j57JaPJP4HByO6uoUdNLkVdlpoqxvJ51nIqqSzua5C34zTgYDq1rSkAk65qzWnybG34PKeHwaahgza63hZPh11SYrZ09G7FyeHPdhuUyLu6elyAIX6oBIDa/DXGHHVbx9TY9M4/sMxzaXEi8h3OYwp/JmH8ayKrjjLqqbcqgWFY3meSz5Q/hMVlEWoK+8bd2+sFtLTDb2quZHGEbiPNLzHhJiCnouZcWyvkLmi5eSHH4akYvlMZcViUkH37aybBUSTpzC8gyiHxBjtF9FXAWK1eSZtGsFYZQz6/k+ZkSsTyZtl6E9Mq71vGocC5he424/AeKF7Ke19LjuWce0PHuD23OnDYyjAXoDkLC6rF49jma7B8170YLZxO0ejpsGETO19Db7J7i8NxjR5BsMgZmV/BWZ3f0rT7OwyZq9nZ619SERrDJtel6WZ9nnY45epGqltxT05+oXISs9iljWWs5ni9HectZNy7yBXO3Nr/ABNGS4vxJVcMV+WYJYYDGcZXSt4FaTqibXWaYwS2u5kAObu9qhwvd3OA5jj9RV8k8Uc21yYtDY5HMkRedeHM3wbl62/RUTdvZMS5NwpMuRCUhL0T9SUrbSoka4H5ow/AcmzmPRY9yXiWQ0FMqmq7eJR57Bx6xq7dcbLLegjxfZtseYQ8hRL6QvcoHadfVdhGOYtR0FdzZKzGVjnIVtyPdWURVPmb0B2bizvGkaJPqsak9023ck2UZX6h92WN1HbfWA57d8n1lLa4XiF1gqqDA8MYaqpWOWdpS2Smos3LZ93Mq5thHoIUSW40FB5tlavkUU6ymprYFtZ0+WS7uba0OQX9peUDYyO2mZFbVNNj055uhqKV+6nPPpYaYSW1u9qXA0ntKSgu96lKZ2SGmFJZ71LC5RbUQqN7hKktIWsju9emvmcQ4dz86A72nySQHQFjp6/0aa6jfdXTr/cUft1v477eB+GgPH0O/wADodD4eo9R/L4aHQ+fmB5euk+P3+n9Gtl9UbjuTuAehB3Hluk9R8Rpl4L7X221o935N2ipxLnuRPkUlDjqk97hUFfvFEjbV3jFw5IcrL+C5AsSy8luWWXHUOFTMh1qSEOuoSpDi+zu2X3J2UkHTUeSEyWmwwlwSwmY5JMUJER55+QF9syP2BQdShJKyTsN9tM/qo8d8sPiUwt5luQ5FmIBSmXDW4EGHJKVFKltdhUk7dPIKAZUtJHa660FvgdwJCXQR2Ekk7pCSD166cSh51Ac2T8jjqPbaCkqKWwh1AStawSpW3UkjYDRUtKCpRPRoJaQlsk7J3SguOEEn8RO+vl6J36dUjYeQ2SAnpv5bDRA3+/+X/DR+31+B/m6aI+B8/Q/D+Q12+m/9v2jx00Pir83+BXw28NJHTbpv0O/gPj66H84/Yd+m+h18v7N+m+gOhHj5kg7fBWgB2/cfX/P56/EfHp9/wBvw10JP3H+kjro9R5eYHr6BWgSTv8AAj1/y6I3HQnzH/l0fDy8wfMfAa6k+e22w+8gnRAPXfz/AJvPw15beXQ9R8fm9deX3ff+bzOiDt+Ly36dDv5+h1+z+s7+fpo9fTf7h8eukHp0UofDwI/veWk/Kv8ALt1+746Hyq+8eh22676/Cvw9U+vTz0PlX4eo/qJ1/pqPjv1T8P8AFofu/M/mR6f5vPX+l5D8yPT4K8tdGj+xSf8AzaH7lfn+ZPr/AJ9H9yd+v5keP/Pvo/uleX5k+o/xaP7tZ8PzJ9R8Rrq0fE+KkdPw9PxaP7pWwP8AeT19PzaPyr8/NP8Abo/Kvx6dR6fA+Oj8q/Dr1Hx+Oj8q/vT6eXXSflVv3HzHor46/9k="
                               }
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
                    LineExtensionAmount = new TemelFaturaXML.LineExtensionAmount()
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
                    Note = new string[]
                    {
                        ""
                    },
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
                                    Value = _efaturaParamsServis.obje.FirstOrDefault().vno
                                }
                            },
                            PostalAddress = new SignatureSignatoryPartyPostalAddress()
                            { 
                                BuildingName = _efaturaParamsServis.obje.FirstOrDefault().unvan, 
                                CityName = _efaturaParamsServis.obje.FirstOrDefault().il,
                                Country = new SignatureSignatoryPartyPostalAddressCountry() { Name = _efaturaParamsServis.obje.FirstOrDefault().ulke },
                                CitySubdivisionName = _efaturaParamsServis.obje.FirstOrDefault().ilce,
                                PostalZone = "06560",
                                Region = _efaturaParamsServis.obje.FirstOrDefault().ilce,
                                StreetName = _efaturaParamsServis.obje.FirstOrDefault().sokak,


                            }
                        }
                    },
                    KasaListe = tkasa

                };



                server = new RichEditDocumentServer();
                var ss = temelfatura.SerializeToXml<TemelFaturaXML.Invoice>();
                string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
                if (ss.StartsWith(_byteOrderMarkUtf8))
                {
                    ss = ss.Remove(0, _byteOrderMarkUtf8.Length);
                }
                XDocument doc = XDocument.Parse(ss);
                File.WriteAllText("Employee.xml", doc.ToString(), Encoding.UTF8);

                //Create the DataSet from the XML file
                XslCompiledTransform proc = new XslCompiledTransform();
                proc.Load("ONURHAL_000_0_S (1).xslt");
                proc.Transform(Application.StartupPath + "Employee.xml", Application.StartupPath + "output.html");
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(Application.StartupPath + "output.html")
                {
                    UseShellExecute = true
                };
                p.Start();
                MessageBox.Show("Belge Oluşturuldu..");

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

        public void IrsaliyeBasim(int irsaliyeid)
        {
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            var irsaliye = _irsaliyeServis.obje.Where(x => x.id == irsaliyeid).FirstOrDefault();
            var cari = _cariServis.obje.Where(x => x.id == irsaliye.cariid).FirstOrDefault();
            var irsaliyedetay = _irsaliyeDetayServis.obje.Where(x => x.irsaliyeid == irsaliye.id);
            DataSet ds;
            XmlDataDocument xmlDoc;
            XslCompiledTransform xslTran;
            XmlElement root;
            XPathNavigator nav;
            XmlTextWriter writer;
            try
            {
                var rsa = RSA.Create();
                var t1 = new DeliveryCustomerParty()
                {
                    Party = new DeliveryCustomerPartyParty()
                    {
                        Contact = new DeliveryCustomerPartyPartyContact()
                        {
                            ElectronicMail = cari.eposta,
                            Telefax = cari.fax.ToString(),
                            Telephone = cari.telefon.ToString()
                        },
                        PartyIdentification = new DeliveryCustomerPartyPartyPartyIdentification[]
                        {
                            new DeliveryCustomerPartyPartyPartyIdentification(){
                            ID = new IrsaliyeXML.ID()
                            {
                                schemeID = "VKN",
                                Value = cari.vergino.ToString()
                            }
                            }
                        },
                        PartyName = new DeliveryCustomerPartyPartyPartyName()
                        {
                            Name = cari.unvan.ToString(),
                        },
                        PartyTaxScheme = new DeliveryCustomerPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new DeliveryCustomerPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = cari.vergidairesi.ToString()
                            }
                        },
                        PostalAddress = new DeliveryCustomerPartyPartyPostalAddress()
                        {


                            CityName = cari.il.ToString(),
                            CitySubdivisionName = cari.ilce.ToString(),
                            Country = new DeliveryCustomerPartyPartyPostalAddressCountry() { Name = cari.ulke },
                            StreetName = cari.sokak.ToString(),

                        }
                    }
                };
                var t2 = new DespatchSupplierParty()
                {
                    Party = new DespatchSupplierPartyParty()
                    {
                        Contact = new DespatchSupplierPartyPartyContact()
                        {
                            ElectronicMail = "gunduzmeypak@gmail.com",
                            Telefax = "000000000",
                            Telephone = "000",

                        },

                        PartyName = new DespatchSupplierPartyPartyPartyName()
                        {
                            Name = "Gündüz Meypak A.Ş."
                        },
                        PartyTaxScheme = new DespatchSupplierPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new DespatchSupplierPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = "Başkent"
                            }
                        },
                        PostalAddress = new DespatchSupplierPartyPartyPostalAddress()
                        {
                            //BuildingName = "",
                            BuildingNumber = "0",
                            CityName = "Ankara",
                            CitySubdivisionName = "Çankaya",
                            Country = new DespatchSupplierPartyPartyPostalAddressCountry() { Name = "Türkiye" },
                            PostalZone = ushort.Parse("0"),
                            //  Region = "Kızılırmak",
                            //  Room = "0",
                            StreetName = "DumluPınar"


                        }

                    }
                };
                List<DespatchLine> irsSatir = new List<DespatchLine>();
                foreach (var item in irsaliyedetay)
                {
                    irsSatir.Add(new  DespatchLine()
                    {

                        ID = new IrsaliyeXML.ID()
                        {
                            schemeID = "",
                            Value = item.stokid.ToString()
                        },
                        DeliveredQuantity = new  DeliveredQuantity()
                        {
                            unitCode = "NIU",
                            Value = Convert.ToByte(item.safi)
                        },
                        Item = new  DespatchLineItem()
                        {
                            Name = item.stokadi,// SellersItemIdentification= item.stokid ekleneceeek

                        },
                          
                      
                         OrderLineReference=new DespatchLineOrderLineReference()
                         {
                              
                         },
                          Shipment=new DespatchLineShipment()
                          {
                               GoodsItem= new DespatchLineShipmentGoodsItem()
                               {
                                    InvoiceLine = new DespatchLineShipmentGoodsItemInvoiceLine()
                                    {
                                         
                                    }
                               }
                          }
                    });
                }
                List<KasaListeItems> tkasa = new List<KasaListeItems>();
                foreach (var item in _stokKasaHarServis.obje.Where(x => x.faturaid == irsaliyeid))
                {

                    tkasa.Add(
                        new KasaListeItems()
                        {
                            KasaAdı = _stokKasaServis.obje.Where(x => x.id == item.kasaid).FirstOrDefault().kasaadi,
                            KasaId = item.kasaid,
                            KasaMiktar = item.miktar
                        });


                }

                var t3 = new IrsaliyeXML.AdditionalDocumentReference[]
                {
                    new IrsaliyeXML.AdditionalDocumentReference()
                    {


                    }
                };
                var t5 = irsSatir;
                var t6 = new LegalMonetaryTotal()
                {
                    AllowanceTotalAmount = new AllowanceTotalAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.iskontotoplam
                    },
                    LineExtensionAmount = new TemelFaturaXML.LineExtensionAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.nettoplam
                    },
                    PayableAmount = new PayableAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.geneltoplam
                    },
                    TaxExclusiveAmount = new TaxExclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.bruttoplam
                    },
                    TaxInclusiveAmount = new TaxInclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.bruttoplam + irsaliye.kdvtoplam
                    },

                };
                var t8 = new TaxTotal()
                {
                    TaxAmount = new TaxAmount()
                    {
                        currencyID = "TRL",
                        Value = irsaliye.kdvtoplam
                    },
                    TaxSubtotal = new TaxTotalTaxSubtotal()
                    {
                        CalculationSequenceNumeric = 1,
                        Percent = irsaliyedetay.FirstOrDefault().kdv,
                        TaxableAmount = new TaxableAmount()
                        {
                            currencyID = "TRL",
                            Value = irsaliye.kdvtoplam
                        },
                        TaxAmount = new TaxAmount()
                        {
                            currencyID = "TRL",
                            Value = irsaliye.kdvtoplam
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
                IrsaliyeXML.DespatchAdvice irsaliyetempss = new DespatchAdvice()
                {
                    DeliveryCustomerParty = t1,
                    DespatchSupplierParty = t2,
                    AdditionalDocumentReference = t3,
                    CopyIndicator = false,
                    CustomizationID = "TR1.0",
                    UBLVersionID = decimal.Parse("2.1"),
                    DespatchLine = t5,
                    DespatchAdviceTypeCode = "SATIS",
                    IssueDate = irsaliye.vadetarihi,
                    // = t6,
                    // = 1,
                    Note = "",
                    ProfileID = "TEMELIRSALIYE",
                    // TaxTotal = t8,
                    ID = new IrsaliyeXML.ID()
                    {
                        schemeID = "",
                        Value = irsaliye.belgeno,
                    },

                    UBLExtensions = new IrsaliyeXML.UBLExtensions()
                    {
                        UBLExtension = new IrsaliyeXML.UBLExtensionsUBLExtension()
                        {
                            ExtensionContent = new IrsaliyeXML.UBLExtensionsUBLExtensionExtensionContent()
                            {
                                autogenerated_for_wildcard = new object()
                            }
                        }
                    },
                    // DocumentCurrencyCode = "TRY",
                    Signature = new IrsaliyeXML.Signature()
                    {

                        ID = new IrsaliyeXML.ID()
                        {
                            schemeID = "VKN_TCKN",
                            Value = cari.vergino
                        },
                        SignatoryParty = new IrsaliyeXML.SignatureSignatoryParty()
                        {
                            PartyIdentification = new IrsaliyeXML.SignatureSignatoryPartyPartyIdentification()
                            {
                                ID = new IrsaliyeXML.ID()
                                {
                                    schemeID = "VKN",
                                    Value = cari.vergino
                                }
                            },
                            PostalAddress = new IrsaliyeXML.SignatureSignatoryPartyPostalAddress()
                            {
                                //Room = "340",
                                //BuildingName = "YDA CENTER",
                                BuildingNumber = cari.apt,
                                CityName = cari.il,
                                Country = new IrsaliyeXML.SignatureSignatoryPartyPostalAddressCountry() { Name = cari.ulke },
                                CitySubdivisionName = cari.ilce,
                                PostalZone = ushort.Parse(cari.postakod),
                                StreetName = cari.adres,



                            }
                        }
                    },
                    //  KasaListe = tkasa

                };



                server = new RichEditDocumentServer();
                var ss = irsaliyetempss.SerializeToXml<IrsaliyeXML.DespatchAdvice>();
                string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
                if (ss.StartsWith(_byteOrderMarkUtf8))
                {
                    ss = ss.Remove(0, _byteOrderMarkUtf8.Length);
                }
                XDocument doc = XDocument.Parse(ss);
                File.WriteAllText("Employeeirs.xml", ss.ToString(), Encoding.UTF8);

                //Create the DataSet from the XML file
                XslCompiledTransform proc = new XslCompiledTransform();
                proc.Load("ONURHALIRS_000_0_I (1).xslt");
                proc.Transform(Application.StartupPath + "Employeeirs.xml", Application.StartupPath + "output.html");
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(Application.StartupPath + "output.html")
                {
                    UseShellExecute = true
                };
                p.Start();
                MessageBox.Show("Belge Oluşturuldu..");

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



        public void HKSBasim(int faturaid)
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
                var t1 = new HKSFaturaXML.AccountingCustomerParty()
                {
                    Party = new HKSFaturaXML.AccountingCustomerPartyParty()
                    {
                        Contact = new HKSFaturaXML.AccountingCustomerPartyPartyContact()
                        {
                            ElectronicMail = cari.eposta,
                            Telefax = cari.fax.ToString(),
                            Telephone = cari.telefon.ToString()
                        },
                        PartyIdentification = new HKSFaturaXML.AccountingCustomerPartyPartyPartyIdentification()
                        {
                            ID = new HKSFaturaXML.ID()
                            {
                                schemeID = "VKN",
                                Value = cari.vergino.ToString()
                            }
                        },
                        PartyName = new HKSFaturaXML.AccountingCustomerPartyPartyPartyName()
                        {
                            Name = cari.unvan.ToString(),
                        },
                        PartyTaxScheme = new HKSFaturaXML.AccountingCustomerPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new HKSFaturaXML.AccountingCustomerPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = cari.vergidairesi.ToString()
                            }
                        },
                        PostalAddress = new HKSFaturaXML.AccountingCustomerPartyPartyPostalAddress()
                        {


                            CityName = cari.il.ToString(),
                            CitySubdivisionName = cari.ilce.ToString(),
                            Country = new HKSFaturaXML.AccountingCustomerPartyPartyPostalAddressCountry() { Name = cari.ulke },
                            StreetName = cari.sokak.ToString(),

                        }
                    }
                };
                var t2 = new HKSFaturaXML.AccountingSupplierParty()
                {
                    Party = new HKSFaturaXML.AccountingSupplierPartyParty()
                    {
                        Contact = new HKSFaturaXML.AccountingSupplierPartyPartyContact()
                        {
                            ElectronicMail = "gunduzmeypak@gmail.com",
                            Telefax = "000000000",
                            Telephone = "000",

                        },

                        PartyName = new HKSFaturaXML.AccountingSupplierPartyPartyPartyName()
                        {
                            Name = "Gündüz Meypak A.Ş."
                        },
                        PartyTaxScheme = new HKSFaturaXML.AccountingSupplierPartyPartyPartyTaxScheme()
                        {
                            TaxScheme = new HKSFaturaXML.AccountingSupplierPartyPartyPartyTaxSchemeTaxScheme()
                            {
                                Name = "Başkent"
                            }
                        },
                        PostalAddress = new HKSFaturaXML.AccountingSupplierPartyPartyPostalAddress()
                        {
                            BuildingName = "",
                            BuildingNumber = "0",
                            CityName = "Ankara",
                            CitySubdivisionName = "Çankaya",
                            Country = new HKSFaturaXML.AccountingSupplierPartyPartyPostalAddressCountry() { Name = "Türkiye" },
                            PostalZone = "0",
                            Region = "Kızılırmak",
                            Room = "0",
                            StreetName = "DumluPınar"


                        }

                    }
                };
                List<HKSFaturaXML.InvoiceLine> fatSatir = new List<HKSFaturaXML.InvoiceLine>();
                foreach (var item in faturadetay)
                {
                    fatSatir.Add(new HKSFaturaXML.InvoiceLine()
                    {

                        ID = new HKSFaturaXML.ID()
                        {
                            schemeID = "",
                            Value = item.stokid.ToString()
                        },
                        InvoicedQuantity = new HKSFaturaXML.InvoicedQuantity()
                        {
                            unitCode = "NIU",
                            Value = item.safi
                        },
                        Item = new HKSFaturaXML.InvoiceLineItem()
                        {
                            Name = item.stokadi

                        },
                        LineExtensionAmount = new HKSFaturaXML.LineExtensionAmount()
                        {
                            currencyID = "TRL",
                            Value = item.nettoplam
                        },
                        Price = new HKSFaturaXML.InvoiceLinePrice()
                        {
                            PriceAmount = new HKSFaturaXML.PriceAmount()
                            {
                                currencyID = "TRL",
                                Value = Convert.ToByte(item.birimfiyat)


                            }
                        },
                        TaxTotal = new HKSFaturaXML.InvoiceLineTaxTotal()
                        {
                            TaxAmount = new HKSFaturaXML.TaxAmount()
                            {
                                currencyID = "TRL",
                                Value = item.kdvtutari
                            },
                            TaxSubtotal = new HKSFaturaXML.InvoiceLineTaxTotalTaxSubtotal()
                            {
                                TaxAmount = new HKSFaturaXML.TaxAmount()
                                {
                                    currencyID = "TRL",
                                    Value = item.kdvtutari
                                },
                                Percent = item.kdv,
                                TaxableAmount = new HKSFaturaXML.TaxableAmount() { currencyID = "TRL", Value = item.nettoplam },
                                TaxCategory = new HKSFaturaXML.InvoiceLineTaxTotalTaxSubtotalTaxCategory()
                                {
                                    TaxScheme = new HKSFaturaXML.InvoiceLineTaxTotalTaxSubtotalTaxCategoryTaxScheme()
                                    {
                                        TaxTypeCode = "0015",
                                        Name = "KDV"
                                    }
                                }
                            }
                        }
                    });
                }


                var t3 = new HKSFaturaXML.AdditionalDocumentReference
                {

                };
                var t5 = fatSatir;
                var t6 = new HKSFaturaXML.LegalMonetaryTotal()
                {
                    AllowanceTotalAmount = new HKSFaturaXML.AllowanceTotalAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.iskontotoplam
                    },
                    LineExtensionAmount = new HKSFaturaXML.LineExtensionAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.nettoplam
                    },
                    PayableAmount = new HKSFaturaXML.PayableAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.geneltoplam
                    },
                    TaxExclusiveAmount = new HKSFaturaXML.TaxExclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.bruttoplam
                    },
                    TaxInclusiveAmount = new HKSFaturaXML.TaxInclusiveAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.bruttoplam + fatura.kdvtoplam
                    },

                };
                var t8 = new HKSFaturaXML.TaxTotal()
                {
                    TaxAmount = new HKSFaturaXML.TaxAmount()
                    {
                        currencyID = "TRL",
                        Value = fatura.kdvtoplam
                    },
                    TaxSubtotal = new HKSFaturaXML.TaxTotalTaxSubtotal()
                    {
                        CalculationSequenceNumeric = 1,
                        Percent = faturadetay.FirstOrDefault().kdv,
                        TaxableAmount = new HKSFaturaXML.TaxableAmount()
                        {
                            currencyID = "TRL",
                            Value = fatura.kdvtoplam
                        },
                        TaxAmount = new HKSFaturaXML.TaxAmount()
                        {
                            currencyID = "TRL",
                            Value = fatura.kdvtoplam
                        },
                        TaxCategory = new HKSFaturaXML.TaxTotalTaxSubtotalTaxCategory()
                        {
                            TaxScheme = new HKSFaturaXML.TaxTotalTaxSubtotalTaxCategoryTaxScheme()
                            {
                                Name = "KDV",
                                TaxTypeCode = "0015"
                            }
                        }
                    }
                };
                HKSFaturaXML.Invoice hksFatura = new HKSFaturaXML.Invoice()
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
                    ID = new HKSFaturaXML.ID()
                    {
                        schemeID = "",
                        Value = fatura.belgeno,
                    },

                    UBLExtensions = new HKSFaturaXML.UBLExtensions()
                    {
                        UBLExtension = new HKSFaturaXML.UBLExtensionsUBLExtension()
                        {
                            ExtensionContent = new UBLExtensionsUBLExtensionExtensionContent()
                            {
                                autogeneratedwildcard = new object()
                            }
                        }
                    },
                    DocumentCurrencyCode = "TRY",
                    Signature = new HKSFaturaXML.Signature()
                    {

                        ID = new HKSFaturaXML.ID()
                        {
                            schemeID = "VKN_TCKN",
                            Value = cari.vergino
                        },
                        SignatoryParty = new HKSFaturaXML.SignatureSignatoryParty()
                        {
                            PartyIdentification = new HKSFaturaXML.SignatureSignatoryPartyPartyIdentification()
                            {
                                ID = new HKSFaturaXML.ID()
                                {
                                    schemeID = "VKN",
                                    Value = cari.vergino
                                }
                            },
                            PostalAddress = new HKSFaturaXML.SignatureSignatoryPartyPostalAddress()
                            {
                                Room = "340",
                                BuildingName = "YDA CENTER",
                                BuildingNumber = cari.apt,
                                CityName = cari.il,
                                Country = new HKSFaturaXML.SignatureSignatoryPartyPostalAddressCountry() { Name = cari.ulke },
                                CitySubdivisionName = cari.ilce,
                                PostalZone = cari.postakod,
                                Region = cari.ilce,
                                StreetName = cari.adres,


                            }
                        }
                    }

                };



                server = new RichEditDocumentServer();
                var ss = hksFatura.SerializeToXml<HKSFaturaXML.Invoice>();

                File.WriteAllText("Employee.xml", ss.ToString(), Encoding.UTF8);

                //Create the DataSet from the XML file
                XslCompiledTransform proc = new XslCompiledTransform();
                proc.Load("Employee.xslt");
                proc.Transform(Application.StartupPath + "Employee.xml", Application.StartupPath + "output.html");

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
