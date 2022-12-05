using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class KunyeListesi
    {
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
            public string BildirimciAdı { get; set; }

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
    }
}
