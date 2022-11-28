 
namespace MEYPAK.PRL.Assets
{
    public class HksUrunCinsi
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

            private BaseResponseMessageOf_UrunCinsleriCevap baseResponseMessageOf_UrunCinsleriCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_UrunCinsleriCevap BaseResponseMessageOf_UrunCinsleriCevap
            {
                get
                {
                    return this.baseResponseMessageOf_UrunCinsleriCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_UrunCinsleriCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_UrunCinsleriCevap
        {

            private object hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_UrunCinsleriCevapSonuc sonucField;

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
            public BaseResponseMessageOf_UrunCinsleriCevapSonuc Sonuc
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
        public partial class BaseResponseMessageOf_UrunCinsleriCevapSonuc
        {

            private byte hataKoduField;

            private object mesajField;

            private UrunCinsiDTO[] urunCinsleriField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract")]
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
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract", IsNullable = true)]
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
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract")]
            [System.Xml.Serialization.XmlArrayItemAttribute("UrunCinsiDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model", IsNullable = false)]
            public UrunCinsiDTO[] UrunCinsleri
            {
                get
                {
                    return this.urunCinsleriField;
                }
                set
                {
                    this.urunCinsleriField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model", IsNullable = false)]
        public partial class UrunCinsiDTO
        {

            private ushort idField;

            private bool ithalmiField;

            private byte uretimSekliIdField;

            private string urunCinsiAdiField;

            private ushort urunIdField;

            private uint urunKoduField;

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
            public bool Ithalmi
            {
                get
                {
                    return this.ithalmiField;
                }
                set
                {
                    this.ithalmiField = value;
                }
            }

            /// <remarks/>
            public byte UretimSekliId
            {
                get
                {
                    return this.uretimSekliIdField;
                }
                set
                {
                    this.uretimSekliIdField = value;
                }
            }

            /// <remarks/>
            public string UrunCinsiAdi
            {
                get
                {
                    return this.urunCinsiAdiField;
                }
                set
                {
                    this.urunCinsiAdiField = value;
                }
            }

            /// <remarks/>
            public ushort UrunId
            {
                get
                {
                    return this.urunIdField;
                }
                set
                {
                    this.urunIdField = value;
                }
            }

            /// <remarks/>
            public uint UrunKodu
            {
                get
                {
                    return this.urunKoduField;
                }
                set
                {
                    this.urunKoduField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract", IsNullable = false)]
        public partial class UrunCinsleri
        {

            private UrunCinsiDTO[] urunCinsiDTOField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("UrunCinsiDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model")]
            public UrunCinsiDTO[] UrunCinsiDTO
            {
                get
                {
                    return this.urunCinsiDTOField;
                }
                set
                {
                    this.urunCinsiDTOField = value;
                }
            }
        }


    }
}
