using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HKSBildirimTurleri
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

            private BaseResponseMessageOf_BildirimTurleriCevap baseResponseMessageOf_BildirimTurleriCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_BildirimTurleriCevap BaseResponseMessageOf_BildirimTurleriCevap
            {
                get
                {
                    return this.baseResponseMessageOf_BildirimTurleriCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_BildirimTurleriCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_BildirimTurleriCevap
        {

            private object hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_BildirimTurleriCevapSonuc sonucField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
            public object HataKodlari
            {
                get
                {
                    return this.hataKodlariField;
                }
                set
                {
                    this.hataKodlariField = value;
                }
            }

            /// <remarks/>
            public string IslemKodu
            {
                get
                {
                    return this.islemKoduField;
                }
                set
                {
                    this.islemKoduField = value;
                }
            }

            /// <remarks/>
            public BaseResponseMessageOf_BildirimTurleriCevapSonuc Sonuc
            {
                get
                {
                    return this.sonucField;
                }
                set
                {
                    this.sonucField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        public partial class BaseResponseMessageOf_BildirimTurleriCevapSonuc
        {

            private BildirimTuruDTO[] bildirimTurleriField;

            private byte hataKoduField;

            private object mesajField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
            [System.Xml.Serialization.XmlArrayItemAttribute("BildirimTuruDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = false)]
            public BildirimTuruDTO[] BildirimTurleri
            {
                get
                {
                    return this.bildirimTurleriField;
                }
                set
                {
                    this.bildirimTurleriField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
            public byte HataKodu
            {
                get
                {
                    return this.hataKoduField;
                }
                set
                {
                    this.hataKoduField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = true)]
            public object Mesaj
            {
                get
                {
                    return this.mesajField;
                }
                set
                {
                    this.mesajField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = false)]
        public partial class BildirimTuruDTO
        {

            private string bildirimTuruAdiField;

            private byte idField;

            /// <remarks/>
            public string BildirimTuruAdi
            {
                get
                {
                    return this.bildirimTuruAdiField;
                }
                set
                {
                    this.bildirimTuruAdiField = value;
                }
            }

            /// <remarks/>
            public byte Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = false)]
        public partial class BildirimTurleri
        {

            private BildirimTuruDTO[] bildirimTuruDTOField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("BildirimTuruDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public BildirimTuruDTO[] BildirimTuruDTO
            {
                get
                {
                    return this.bildirimTuruDTOField;
                }
                set
                {
                    this.bildirimTuruDTOField = value;
                }
            }
        }


    }
}
