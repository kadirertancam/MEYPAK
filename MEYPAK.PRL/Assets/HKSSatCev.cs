using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MEYPAK.PRL.Assets
{
    public class HKSSatCev
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

            private BaseResponseMessageOf_ListOf_BildirimKayitCevap baseResponseMessageOf_ListOf_BildirimKayitCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseResponseMessageOf_ListOf_BildirimKayitCevap BaseResponseMessageOf_ListOf_BildirimKayitCevap
            {
                get
                {
                    return this.baseResponseMessageOf_ListOf_BildirimKayitCevapField;
                }
                set
                {
                    this.baseResponseMessageOf_ListOf_BildirimKayitCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseResponseMessageOf_ListOf_BildirimKayitCevap
        {

            private BaseResponseMessageOf_ListOf_BildirimKayitCevapHataKodlari hataKodlariField;

            private string islemKoduField;

            private BaseResponseMessageOf_ListOf_BildirimKayitCevapSonuc sonucField;

            /// <remarks/>
            public BaseResponseMessageOf_ListOf_BildirimKayitCevapHataKodlari HataKodlari
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
            public BaseResponseMessageOf_ListOf_BildirimKayitCevapSonuc Sonuc
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
        public partial class BaseResponseMessageOf_ListOf_BildirimKayitCevapHataKodlari
        {

            private ErrorModel errorModelField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Core.ServiceContract")]
            public ErrorModel ErrorModel
            {
                get
                {
                    return this.errorModelField;
                }
                set
                {
                    this.errorModelField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Core.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Core.ServiceContract", IsNullable = false)]
        public partial class ErrorModel
        {

            private byte hataKoduField;

            private string mesajField;

            /// <remarks/>
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
            public string Mesaj
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
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        public partial class BaseResponseMessageOf_ListOf_BildirimKayitCevapSonuc
        {

            private BildirimKayitCevap bildirimKayitCevapField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
            public BildirimKayitCevap BildirimKayitCevap
            {
                get
                {
                    return this.bildirimKayitCevapField;
                }
                set
                {
                    this.bildirimKayitCevapField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = false)]
        public partial class BildirimKayitCevap
        {

            private string aracPlakaNoField;

            private object belgeNoField;

            private byte belgeTipiField;

            private byte hataKoduField;

            private System.DateTime kayitTarihiField;

            private ushort malinCinsiIdField;

            private ushort malinKodNoField;

            private decimal malinMiktariField;

            private string malinSahibAdiField;

            private object mesajField;

            private byte miktarBirimIdField;

            private byte rusumMiktariField;

            private string uniqueIdField;

            private string ureticisininAdUnvaniField;

            private ushort uretimBeldeIdField;

            private byte uretimIlIdField;

            private byte uretimIlceIdField;

            private byte uretimSekliField;

            private ulong yeniKunyeNoField;

            /// <remarks/>
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
            [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
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
            public byte BelgeTipi
            {
                get
                {
                    return this.belgeTipiField;
                }
                set
                {
                    this.belgeTipiField = value;
                }
            }

            /// <remarks/>
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
            public System.DateTime KayitTarihi
            {
                get
                {
                    return this.kayitTarihiField;
                }
                set
                {
                    this.kayitTarihiField = value;
                }
            }

            /// <remarks/>
            public ushort MalinCinsiId
            {
                get
                {
                    return this.malinCinsiIdField;
                }
                set
                {
                    this.malinCinsiIdField = value;
                }
            }

            /// <remarks/>
            public ushort MalinKodNo
            {
                get
                {
                    return this.malinKodNoField;
                }
                set
                {
                    this.malinKodNoField = value;
                }
            }

            /// <remarks/>
            public decimal MalinMiktari
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
            public string MalinSahibAdi
            {
                get
                {
                    return this.malinSahibAdiField;
                }
                set
                {
                    this.malinSahibAdiField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
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
            public byte MiktarBirimId
            {
                get
                {
                    return this.miktarBirimIdField;
                }
                set
                {
                    this.miktarBirimIdField = value;
                }
            }

            /// <remarks/>
            public byte RusumMiktari
            {
                get
                {
                    return this.rusumMiktariField;
                }
                set
                {
                    this.rusumMiktariField = value;
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

            /// <remarks/>
            public string UreticisininAdUnvani
            {
                get
                {
                    return this.ureticisininAdUnvaniField;
                }
                set
                {
                    this.ureticisininAdUnvaniField = value;
                }
            }

            /// <remarks/>
            public ushort UretimBeldeId
            {
                get
                {
                    return this.uretimBeldeIdField;
                }
                set
                {
                    this.uretimBeldeIdField = value;
                }
            }

            /// <remarks/>
            public byte UretimIlId
            {
                get
                {
                    return this.uretimIlIdField;
                }
                set
                {
                    this.uretimIlIdField = value;
                }
            }

            /// <remarks/>
            public byte UretimIlceId
            {
                get
                {
                    return this.uretimIlceIdField;
                }
                set
                {
                    this.uretimIlceIdField = value;
                }
            }

            /// <remarks/>
            public byte UretimSekli
            {
                get
                {
                    return this.uretimSekliField;
                }
                set
                {
                    this.uretimSekliField = value;
                }
            }

            /// <remarks/>
            public ulong YeniKunyeNo
            {
                get
                {
                    return this.yeniKunyeNoField;
                }
                set
                {
                    this.yeniKunyeNoField = value;
                }
            }
        }


    }
}
