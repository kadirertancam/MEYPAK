using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HalİçiİsYerleri
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

            private BaseResponseMessageOf_HalIciIsyeriCevap baseResponseMessageOf_HalIciIsyeriCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_HalIciIsyeriCevap BaseResponseMessageOf_HalIciIsyeriCevap
            {
                get
                {
                    return this.baseResponseMessageOf_HalIciIsyeriCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_HalIciIsyeriCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_HalIciIsyeriCevap
        {

            private object hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_HalIciIsyeriCevapSonuc sonucField;

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
            public BaseResponseMessageOf_HalIciIsyeriCevapSonuc Sonuc
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
        public partial class BaseResponseMessageOf_HalIciIsyeriCevapSonuc
        {

            private byte hataKoduField;

            private Isyerleri isyerleriField;

            private object mesajField;

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
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract")]
            public Isyerleri Isyerleri
            {
                get
                {
                    return this.isyerleriField;
                }
                set
                {
                    this.isyerleriField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract", IsNullable = false)]
        public partial class Isyerleri
        {

            private HalIciIsyeriDTO halIciIsyeriDTOField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model")]
            public HalIciIsyeriDTO HalIciIsyeriDTO
            {
                get
                {
                    return this.halIciIsyeriDTOField;
                }
                set
                {
                    this.halIciIsyeriDTOField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.Model", IsNullable = false)]
        public partial class HalIciIsyeriDTO
        {

            private string halAdiField;

            private ushort halIdField;

            private ushort idField;

            private string isyeriAdiField;

            private ulong tcKimlikVergiNoField;

            /// <remarks/>
            public string HalAdi
            {
                get
                {
                    return this.halAdiField;
                }
                set
                {
                    this.halAdiField = value;
                }
            }

            /// <remarks/>
            public ushort HalId
            {
                get
                {
                    return this.halIdField;
                }
                set
                {
                    this.halIdField = value;
                }
            }

            /// <remarks/>
            public ushort Id
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
            public string IsyeriAdi
            {
                get
                {
                    return this.isyeriAdiField;
                }
                set
                {
                    this.isyeriAdiField = value;
                }
            }

            /// <remarks/>
            public ulong TcKimlikVergiNo
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


    }
}
