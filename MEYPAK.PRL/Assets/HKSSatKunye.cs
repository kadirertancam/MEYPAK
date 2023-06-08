using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HKSSatKunye
    {

        // NOT: Oluşturulan kod en az .NET Framework 4.5 veya.NET Core/Standard 2.0 gerektirebilir.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
        public partial class Envelope
        {

            private EnvelopeBody bodyField;

            /// <remarks/>
            public EnvelopeBody Body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public partial class EnvelopeBody
        {

            private BaseRequestMessageOf_ListOf_BildirimKayitIstek baseRequestMessageOf_ListOf_BildirimKayitIstekField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseRequestMessageOf_ListOf_BildirimKayitIstek BaseRequestMessageOf_ListOf_BildirimKayitIstek
            {
                get
                {
                    return this.baseRequestMessageOf_ListOf_BildirimKayitIstekField;
                }
                set
                {
                    this.baseRequestMessageOf_ListOf_BildirimKayitIstekField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseRequestMessageOf_ListOf_BildirimKayitIstek
        {

            private BaseRequestMessageOf_ListOf_BildirimKayitIstekIstek istekField;

            private string passwordField;

            private string servicePasswordField;

            private ulong userNameField;

            /// <remarks/>
            public BaseRequestMessageOf_ListOf_BildirimKayitIstekIstek Istek
            {
                get
                {
                    return this.istekField;
                }
                set
                {
                    this.istekField = value;
                }
            }

            /// <remarks/>
            public string Password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }

            /// <remarks/>
            public string ServicePassword
            {
                get
                {
                    return this.servicePasswordField;
                }
                set
                {
                    this.servicePasswordField = value;
                }
            }

            /// <remarks/>
            public ulong UserName
            {
                get
                {
                    return this.userNameField;
                }
                set
                {
                    this.userNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        public partial class BaseRequestMessageOf_ListOf_BildirimKayitIstekIstek
        {

            private BildirimKayitIstek bildirimKayitIstekField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
            public BildirimKayitIstek BildirimKayitIstek
            {
                get
                {
                    return this.bildirimKayitIstekField;
                }
                set
                {
                    this.bildirimKayitIstekField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = false)]
        public partial class BildirimKayitIstek
        {

            private BildirimKayitIstekBildirimMalBilgileri bildirimMalBilgileriField;

            private int bildirimTuruField;

            private BildirimKayitIstekBildirimciBilgileri bildirimciBilgileriField;

            private BildirimKayitIstekIkinciKisiBilgileri ikinciKisiBilgileriField;

            private BildirimKayitIstekMalinGidecekYerBilgileri malinGidecekYerBilgileriField;

            private string referansBildirimKunyeNoField;

            private string uniqueIdField;

            /// <remarks/>
            public BildirimKayitIstekBildirimMalBilgileri BildirimMalBilgileri
            {
                get
                {
                    return this.bildirimMalBilgileriField;
                }
                set
                {
                    this.bildirimMalBilgileriField = value;
                }
            }

            /// <remarks/>
            public int BildirimTuru
            {
                get
                {
                    return this.bildirimTuruField;
                }
                set
                {
                    this.bildirimTuruField = value;
                }
            }

            /// <remarks/>
            public BildirimKayitIstekBildirimciBilgileri BildirimciBilgileri
            {
                get
                {
                    return this.bildirimciBilgileriField;
                }
                set
                {
                    this.bildirimciBilgileriField = value;
                }
            }

            /// <remarks/>
            public BildirimKayitIstekIkinciKisiBilgileri IkinciKisiBilgileri
            {
                get
                {
                    return this.ikinciKisiBilgileriField;
                }
                set
                {
                    this.ikinciKisiBilgileriField = value;
                }
            }

            /// <remarks/>
            public BildirimKayitIstekMalinGidecekYerBilgileri MalinGidecekYerBilgileri
            {
                get
                {
                    return this.malinGidecekYerBilgileriField;
                }
                set
                {
                    this.malinGidecekYerBilgileriField = value;
                }
            }

            /// <remarks/>
            public string ReferansBildirimKunyeNo
            {
                get
                {
                    return this.referansBildirimKunyeNoField;
                }
                set
                {
                    this.referansBildirimKunyeNoField = value;
                }
            }

            /// <remarks/>
            public string UniqueId
            {
                get
                {
                    return this.uniqueIdField;
                }
                set
                {
                    this.uniqueIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        public partial class BildirimKayitIstekBildirimMalBilgileri
        {

            private double malinMiktariField;

            private double malinSatisFiyatField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public double MalinMiktari
            {
                get
                {
                    return this.malinMiktariField;
                }
                set
                {
                    this.malinMiktariField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public double MalinSatisFiyat
            {
                get
                {
                    return this.malinSatisFiyatField;
                }
                set
                {
                    this.malinSatisFiyatField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        public partial class BildirimKayitIstekBildirimciBilgileri
        {

            private int kisiSifatField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int KisiSifat
            {
                get
                {
                    return this.kisiSifatField;
                }
                set
                {
                    this.kisiSifatField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        public partial class BildirimKayitIstekIkinciKisiBilgileri
        {

            private string adSoyadField;

            private string cepTelField;

            private string epostaField;

            private int kisiSifatField;

            private string tcKimlikVergiNoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public string AdSoyad
            {
                get
                {
                    return this.adSoyadField;
                }
                set
                {
                    this.adSoyadField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public string CepTel
            {
                get
                {
                    return this.cepTelField;
                }
                set
                {
                    this.cepTelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public string Eposta
            {
                get
                {
                    return this.epostaField;
                }
                set
                {
                    this.epostaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int KisiSifat
            {
                get
                {
                    return this.kisiSifatField;
                }
                set
                {
                    this.kisiSifatField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public string TcKimlikVergiNo
            {
                get
                {
                    return this.tcKimlikVergiNoField;
                }
                set
                {
                    this.tcKimlikVergiNoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        public partial class BildirimKayitIstekMalinGidecekYerBilgileri
        {

            private string aracPlakaNoField;

            private object belgeNoField;

            private int gidecekYerBeldeIdField;

            private int gidecekYerIlIdField;

            private int gidecekYerIlceIdField;

            private int gidecekYerIsletmeTuruIdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public string AracPlakaNo
            {
                get
                {
                    return this.aracPlakaNoField;
                }
                set
                {
                    this.aracPlakaNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = true)]
            public object BelgeNo
            {
                get
                {
                    return this.belgeNoField;
                }
                set
                {
                    this.belgeNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int GidecekYerBeldeId
            {
                get
                {
                    return this.gidecekYerBeldeIdField;
                }
                set
                {
                    this.gidecekYerBeldeIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int GidecekYerIlId
            {
                get
                {
                    return this.gidecekYerIlIdField;
                }
                set
                {
                    this.gidecekYerIlIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int GidecekYerIlceId
            {
                get
                {
                    return this.gidecekYerIlceIdField;
                }
                set
                {
                    this.gidecekYerIlceIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public int GidecekYerIsletmeTuruId
            {
                get
                {
                    return this.gidecekYerIsletmeTuruIdField;
                }
                set
                {
                    this.gidecekYerIsletmeTuruIdField = value;
                }
            }
        }



    }
}
