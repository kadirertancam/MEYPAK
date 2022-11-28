
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

    private BaseResponseMessageOf_BildirimSorguCevap baseResponseMessageOf_BildirimSorguCevapField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
    public BaseResponseMessageOf_BildirimSorguCevap BaseResponseMessageOf_BildirimSorguCevap
    {
        get
        {
            return this.baseResponseMessageOf_BildirimSorguCevapField;
        }
        set
        {
            this.baseResponseMessageOf_BildirimSorguCevapField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
public partial class BaseResponseMessageOf_BildirimSorguCevap
{

    private object hataKodlariField;

    private string islemKoduField;

    private BaseResponseMessageOf_BildirimSorguCevapSonuc sonucField;

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
    public BaseResponseMessageOf_BildirimSorguCevapSonuc Sonuc
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
public partial class BaseResponseMessageOf_BildirimSorguCevapSonuc
{

    private BildirimSorguDTO[] bildirimlerField;

    private byte hataKoduField;

    private object mesajField;

    /// <remarks/> 
    [System.Xml.Serialization.XmlArrayAttribute(elementName: "Bildirimler", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
    [System.Xml.Serialization.XmlArrayItemAttribute("BildirimSorguDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = false)]
    public BildirimSorguDTO[] Bildirimler
    {
        get
        {
            return this.bildirimlerField;
        }
        set
        {
            this.bildirimlerField = value;
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
[System.Xml.Serialization.XmlRootAttribute(elementName: "BildirimSorguDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model", IsNullable = false)]
public partial class BildirimSorguDTO
{

    private bool analizStatusField;

    private string aracPlakaNoField;

    private string belgeNoField;

    private byte belgeTipiField;

    private System.DateTime bildirimTarihiField;

    private byte bildirimTuruField;

    private ulong bildirimciTcKimlikVergiNoField;

    private uint gidecekIsyeriIdField;

    private byte gidecekYerTuruIdField;

    private decimal kalanMiktarField;

    private ulong kunyeNoField;

    private string malinAdiField;

    private ushort malinCinsKodNoField;

    private string malinCinsiField;

    private ushort malinKodNoField;

    private decimal malinMiktariField;

    private ulong malinSahibiTcKimlikVergiNoField;

    private decimal malinSatisFiyatiField;

    private string malinTuruField;

    private byte malinTuruKodNoField;

    private byte miktarBirimIdField;

    private string miktarBirimiAdField;

    private decimal rusumMiktariField;

    private byte sifatField;

    private string uniqueIdField;

    private string ureticiTcKimlikVergiNoField;

    /// <remarks/>
    public bool AnalizStatus
    {
        get
        {
            return this.analizStatusField;
        }
        set
        {
            this.analizStatusField = value;
        }
    }

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
    public string BelgeNo
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
    public System.DateTime BildirimTarihi
    {
        get
        {
            return this.bildirimTarihiField;
        }
        set
        {
            this.bildirimTarihiField = value;
        }
    }

    /// <remarks/>
    public byte BildirimTuru
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
    public ulong BildirimciTcKimlikVergiNo
    {
        get
        {
            return this.bildirimciTcKimlikVergiNoField;
        }
        set
        {
            this.bildirimciTcKimlikVergiNoField = value;
        }
    }

    /// <remarks/>
    public uint GidecekIsyeriId
    {
        get
        {
            return this.gidecekIsyeriIdField;
        }
        set
        {
            this.gidecekIsyeriIdField = value;
        }
    }

    /// <remarks/>
    public byte GidecekYerTuruId
    {
        get
        {
            return this.gidecekYerTuruIdField;
        }
        set
        {
            this.gidecekYerTuruIdField = value;
        }
    }

    /// <remarks/>
    public decimal KalanMiktar
    {
        get
        {
            return this.kalanMiktarField;
        }
        set
        {
            this.kalanMiktarField = value;
        }
    }

    /// <remarks/>
    public ulong KunyeNo
    {
        get
        {
            return this.kunyeNoField;
        }
        set
        {
            this.kunyeNoField = value;
        }
    }

    /// <remarks/>
    public string MalinAdi
    {
        get
        {
            return this.malinAdiField;
        }
        set
        {
            this.malinAdiField = value;
        }
    }

    /// <remarks/>
    public ushort MalinCinsKodNo
    {
        get
        {
            return this.malinCinsKodNoField;
        }
        set
        {
            this.malinCinsKodNoField = value;
        }
    }

    /// <remarks/>
    public string MalinCinsi
    {
        get
        {
            return this.malinCinsiField;
        }
        set
        {
            this.malinCinsiField = value;
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
    public ulong MalinSahibiTcKimlikVergiNo
    {
        get
        {
            return this.malinSahibiTcKimlikVergiNoField;
        }
        set
        {
            this.malinSahibiTcKimlikVergiNoField = value;
        }
    }

    /// <remarks/>
    public decimal MalinSatisFiyati
    {
        get
        {
            return this.malinSatisFiyatiField;
        }
        set
        {
            this.malinSatisFiyatiField = value;
        }
    }

    /// <remarks/>
    public string MalinTuru
    {
        get
        {
            return this.malinTuruField;
        }
        set
        {
            this.malinTuruField = value;
        }
    }

    /// <remarks/>
    public byte MalinTuruKodNo
    {
        get
        {
            return this.malinTuruKodNoField;
        }
        set
        {
            this.malinTuruKodNoField = value;
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
    public string MiktarBirimiAd
    {
        get
        {
            return this.miktarBirimiAdField;
        }
        set
        {
            this.miktarBirimiAdField = value;
        }
    }

    /// <remarks/>
    public decimal RusumMiktari
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
    public byte Sifat
    {
        get
        {
            return this.sifatField;
        }
        set
        {
            this.sifatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
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
    public string UreticiTcKimlikVergiNo
    {
        get
        {
            return this.ureticiTcKimlikVergiNoField;
        }
        set
        {
            this.ureticiTcKimlikVergiNoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract")]
[System.Xml.Serialization.XmlRootAttribute(elementName: "Bildirimler", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract", IsNullable = false)]
public partial class Bildirimler
{

    private BildirimSorguDTO[] bildirimSorguDTOField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BildirimSorguDTO", Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.Model")]
    public BildirimSorguDTO[] BildirimSorguDTO
    {
        get
        {
            return this.bildirimSorguDTOField;
        }
        set
        {
            this.bildirimSorguDTOField = value;
        }
    }
}

