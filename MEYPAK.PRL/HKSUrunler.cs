public class HKSUrunler
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

        private BaseResponseMessageOf_UrunlerCevap baseResponseMessageOf_UrunlerCevapField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
        public BaseResponseMessageOf_UrunlerCevap BaseResponseMessageOf_UrunlerCevap
        {
            get
            {
                return this.baseResponseMessageOf_UrunlerCevapField;
            }
            set
            {
                this.baseResponseMessageOf_UrunlerCevapField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
    public partial class BaseResponseMessageOf_UrunlerCevap
    {

        private object hataKodlariField;

        private string islemKoduField;

        private BaseResponseMessageOf_UrunlerCevapSonuc sonucField;

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
        public BaseResponseMessageOf_UrunlerCevapSonuc Sonuc
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
    public partial class BaseResponseMessageOf_UrunlerCevapSonuc
    {

        private byte hataKoduField;

        private object mesajField;

        private UrunDTO[] urunlerField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("UrunDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model", IsNullable = false)]
        public UrunDTO[] Urunler
        {
            get
            {
                return this.urunlerField;
            }
            set
            {
                this.urunlerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model", IsNullable = false)]
    public partial class UrunDTO
    {

        private ushort idField;

        private string urunAdiField;

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
        public string UrunAdi
        {
            get
            {
                return this.urunAdiField;
            }
            set
            {
                this.urunAdiField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract", IsNullable = false)]
    public partial class Urunler
    {

        private UrunDTO[] urunDTOField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UrunDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.Model")]
        public UrunDTO[] UrunDTO
        {
            get
            {
                return this.urunDTOField;
            }
            set
            {
                this.urunDTOField = value;
            }
        }
    }

}