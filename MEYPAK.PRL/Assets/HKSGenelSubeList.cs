using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HKSGenelSubeList
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

            private BaseResponseMessageOf_SubelerCevap baseResponseMessageOf_SubelerCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_SubelerCevap BaseResponseMessageOf_SubelerCevap
            {
                get
                {
                    return this.baseResponseMessageOf_SubelerCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_SubelerCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_SubelerCevap
        {

            private object hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_SubelerCevapSonuc sonucField;

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
            public BaseResponseMessageOf_SubelerCevapSonuc Sonuc
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
        public partial class BaseResponseMessageOf_SubelerCevapSonuc
        {

            private byte hataKoduField;

            private object mesajField;

            private SubeDTO[] subelerField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract")]
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
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract", IsNullable = true)]
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

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract")]
            [System.Xml.Serialization.XmlArrayItemAttribute("SubeDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model", IsNullable = false)]
            public SubeDTO[] Subeler
            {
                get
                {
                    return this.subelerField;
                }
                set
                {
                    this.subelerField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model", IsNullable = false)]
        public partial class SubeDTO
        {

            private string adresField;

            private ushort beldeIdField;

            private uint idField;

            private byte ilIdField;

            private ushort ilceIdField;

            private byte isyeriTuruField;

            private string subeAdiField;

            /// <remarks/>
            public string Adres
            {
                get
                {
                    return this.adresField;
                }
                set
                {
                    this.adresField = value;
                }
            }

            /// <remarks/>
            public ushort BeldeId
            {
                get
                {
                    return this.beldeIdField;
                }
                set
                {
                    this.beldeIdField = value;
                }
            }

            /// <remarks/>
            public uint Id
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

            /// <remarks/>
            public byte IlId
            {
                get
                {
                    return this.ilIdField;
                }
                set
                {
                    this.ilIdField = value;
                }
            }

            /// <remarks/>
            public ushort IlceId
            {
                get
                {
                    return this.ilceIdField;
                }
                set
                {
                    this.ilceIdField = value;
                }
            }

            /// <remarks/>
            public byte IsyeriTuru
            {
                get
                {
                    return this.isyeriTuruField;
                }
                set
                {
                    this.isyeriTuruField = value;
                }
            }

            /// <remarks/>
            public string SubeAdi
            {
                get
                {
                    return this.subeAdiField;
                }
                set
                {
                    this.subeAdiField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract", IsNullable = false)]
        public partial class Subeler
        {

            private SubeDTO[] subeDTOField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubeDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model")]
            public SubeDTO[] SubeDTO
            {
                get
                {
                    return this.subeDTOField;
                }
                set
                {
                    this.subeDTOField = value;
                }
            }
        }


    }
}
