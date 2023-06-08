using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HKSBildirimKayitKisiCevap
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

            private BaseResponseMessageOf_KayitliKisiSorguCevap baseResponseMessageOf_KayitliKisiSorguCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_KayitliKisiSorguCevap BaseResponseMessageOf_KayitliKisiSorguCevap
            {
                get
                {
                    return this.baseResponseMessageOf_KayitliKisiSorguCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_KayitliKisiSorguCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_KayitliKisiSorguCevap
        {

            private object hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_KayitliKisiSorguCevapSonuc sonucField;

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
            public BaseResponseMessageOf_KayitliKisiSorguCevapSonuc Sonuc
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
        public partial class BaseResponseMessageOf_KayitliKisiSorguCevapSonuc
        {

            private byte hataKoduField;

            private object mesajField;

            private TcKimlikVergiNolar tcKimlikVergiNolarField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
            public TcKimlikVergiNolar TcKimlikVergiNolar
            {
                get
                {
                    return this.tcKimlikVergiNolarField;
                }
                set
                {
                    this.tcKimlikVergiNolarField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = false)]
        public partial class TcKimlikVergiNolar
        {

            private KayitliKisiSorguDTO kayitliKisiSorguDTOField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
            public KayitliKisiSorguDTO KayitliKisiSorguDTO
            {
                get
                {
                    return this.kayitliKisiSorguDTOField;
                }
                set
                {
                    this.kayitliKisiSorguDTOField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = false)]
        public partial class KayitliKisiSorguDTO
        {

            private bool kayitliKisiMiField;

            private byte[] sifatlariField;

            private ulong tcKimlikVergiNoField;

            /// <remarks/>
            public bool KayitliKisiMi
            {
                get
                {
                    return this.kayitliKisiMiField;
                }
                set
                {
                    this.kayitliKisiMiField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute()]
            [System.Xml.Serialization.XmlArrayItemAttribute("int", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
            public byte[] Sifatlari
            {
                get
                {
                    return this.sifatlariField;
                }
                set
                {
                    this.sifatlariField = value;
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
