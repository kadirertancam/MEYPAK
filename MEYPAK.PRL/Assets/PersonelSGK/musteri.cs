using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="musteri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class musteri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool AktifPasifField;

		[OptionalField]
		private bool BayiMiField;

		[OptionalField]
		private decimal BayiOdemeYuzdeField;

		[OptionalField]
		private int FirmaIdField;

		[OptionalField]
		private string adField;

		[OptionalField]
		private string bayiVknTcknField;

		[OptionalField]
		private string kaydedenAdField;

		[OptionalField]
		private string kaydedenSoyadField;

		[OptionalField]
		private string kaydedenTelField;

		[OptionalField]
		private string kepAdresiField;

		[OptionalField]
		private kredi[] krediListesiField;

		[OptionalField]
		private string kullaniciAdiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.kurumTuru kurumTuruField;

		[OptionalField]
		private string kurumsalEpostaField;

		[OptionalField]
		private string musteriAdiField;

		[OptionalField]
		private string musteriTemsilcisiField;

		[OptionalField]
		private string naceKoduField;

		[OptionalField]
		private int referansIdField;

		[OptionalField]
		private string sehirField;

		[OptionalField]
		private string sorumluAdField;

		[OptionalField]
		private string sorumluCepTelField;

		[OptionalField]
		private string sorumluEPostaField;

		[OptionalField]
		private string sorumluSoyadField;

		[OptionalField]
		private string sorumluTcknField;

		[OptionalField]
		private string soyadField;

		[OptionalField]
		private sozlesme[] sozlesmeListesiField;

		[OptionalField]
		private sube[] subeListesiField;

		[OptionalField]
		private string ticaretOdasiField;

		[OptionalField]
		private string ticaretSicilNoField;

		[OptionalField]
		private string unvanField;

		[OptionalField]
		private string vergiDairesiField;

		[OptionalField]
		private string vergiDairesiIlField;

		[OptionalField]
		private string vknTcknField;

		[DataMember]
		public string ad
		{
			get
			{
				return this.adField;
			}
			set
			{
				if (!object.ReferenceEquals(this.adField, value))
				{
					this.adField = value;
					this.RaisePropertyChanged("ad");
				}
			}
		}

		[DataMember]
		public bool AktifPasif
		{
			get
			{
				return this.AktifPasifField;
			}
			set
			{
				if (!this.AktifPasifField.Equals(value))
				{
					this.AktifPasifField = value;
					this.RaisePropertyChanged("AktifPasif");
				}
			}
		}

		[DataMember]
		public bool BayiMi
		{
			get
			{
				return this.BayiMiField;
			}
			set
			{
				if (!this.BayiMiField.Equals(value))
				{
					this.BayiMiField = value;
					this.RaisePropertyChanged("BayiMi");
				}
			}
		}

		[DataMember]
		public decimal BayiOdemeYuzde
		{
			get
			{
				return this.BayiOdemeYuzdeField;
			}
			set
			{
				if (!this.BayiOdemeYuzdeField.Equals(value))
				{
					this.BayiOdemeYuzdeField = value;
					this.RaisePropertyChanged("BayiOdemeYuzde");
				}
			}
		}

		[DataMember]
		public string bayiVknTckn
		{
			get
			{
				return this.bayiVknTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.bayiVknTcknField, value))
				{
					this.bayiVknTcknField = value;
					this.RaisePropertyChanged("bayiVknTckn");
				}
			}
		}

		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember]
		public int FirmaId
		{
			get
			{
				return this.FirmaIdField;
			}
			set
			{
				if (!this.FirmaIdField.Equals(value))
				{
					this.FirmaIdField = value;
					this.RaisePropertyChanged("FirmaId");
				}
			}
		}

		[DataMember]
		public string kaydedenAd
		{
			get
			{
				return this.kaydedenAdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kaydedenAdField, value))
				{
					this.kaydedenAdField = value;
					this.RaisePropertyChanged("kaydedenAd");
				}
			}
		}

		[DataMember]
		public string kaydedenSoyad
		{
			get
			{
				return this.kaydedenSoyadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kaydedenSoyadField, value))
				{
					this.kaydedenSoyadField = value;
					this.RaisePropertyChanged("kaydedenSoyad");
				}
			}
		}

		[DataMember]
		public string kaydedenTel
		{
			get
			{
				return this.kaydedenTelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kaydedenTelField, value))
				{
					this.kaydedenTelField = value;
					this.RaisePropertyChanged("kaydedenTel");
				}
			}
		}

		[DataMember]
		public string kepAdresi
		{
			get
			{
				return this.kepAdresiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kepAdresiField, value))
				{
					this.kepAdresiField = value;
					this.RaisePropertyChanged("kepAdresi");
				}
			}
		}

		[DataMember]
		public kredi[] krediListesi
		{
			get
			{
				return this.krediListesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.krediListesiField, value))
				{
					this.krediListesiField = value;
					this.RaisePropertyChanged("krediListesi");
				}
			}
		}

		[DataMember]
		public string kullaniciAdi
		{
			get
			{
				return this.kullaniciAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kullaniciAdiField, value))
				{
					this.kullaniciAdiField = value;
					this.RaisePropertyChanged("kullaniciAdi");
				}
			}
		}

		[DataMember]
		public string kurumsalEposta
		{
			get
			{
				return this.kurumsalEpostaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kurumsalEpostaField, value))
				{
					this.kurumsalEpostaField = value;
					this.RaisePropertyChanged("kurumsalEposta");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.kurumTuru kurumTuru
		{
			get
			{
				return this.kurumTuruField;
			}
			set
			{
				if (!this.kurumTuruField.Equals(value))
				{
					this.kurumTuruField = value;
					this.RaisePropertyChanged("kurumTuru");
				}
			}
		}

		[DataMember]
		public string musteriAdi
		{
			get
			{
				return this.musteriAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.musteriAdiField, value))
				{
					this.musteriAdiField = value;
					this.RaisePropertyChanged("musteriAdi");
				}
			}
		}

		[DataMember]
		public string musteriTemsilcisi
		{
			get
			{
				return this.musteriTemsilcisiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.musteriTemsilcisiField, value))
				{
					this.musteriTemsilcisiField = value;
					this.RaisePropertyChanged("musteriTemsilcisi");
				}
			}
		}

		[DataMember]
		public string naceKodu
		{
			get
			{
				return this.naceKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.naceKoduField, value))
				{
					this.naceKoduField = value;
					this.RaisePropertyChanged("naceKodu");
				}
			}
		}

		[DataMember]
		public int referansId
		{
			get
			{
				return this.referansIdField;
			}
			set
			{
				if (!this.referansIdField.Equals(value))
				{
					this.referansIdField = value;
					this.RaisePropertyChanged("referansId");
				}
			}
		}

		[DataMember]
		public string sehir
		{
			get
			{
				return this.sehirField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sehirField, value))
				{
					this.sehirField = value;
					this.RaisePropertyChanged("sehir");
				}
			}
		}

		[DataMember]
		public string sorumluAd
		{
			get
			{
				return this.sorumluAdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sorumluAdField, value))
				{
					this.sorumluAdField = value;
					this.RaisePropertyChanged("sorumluAd");
				}
			}
		}

		[DataMember]
		public string sorumluCepTel
		{
			get
			{
				return this.sorumluCepTelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sorumluCepTelField, value))
				{
					this.sorumluCepTelField = value;
					this.RaisePropertyChanged("sorumluCepTel");
				}
			}
		}

		[DataMember]
		public string sorumluEPosta
		{
			get
			{
				return this.sorumluEPostaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sorumluEPostaField, value))
				{
					this.sorumluEPostaField = value;
					this.RaisePropertyChanged("sorumluEPosta");
				}
			}
		}

		[DataMember]
		public string sorumluSoyad
		{
			get
			{
				return this.sorumluSoyadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sorumluSoyadField, value))
				{
					this.sorumluSoyadField = value;
					this.RaisePropertyChanged("sorumluSoyad");
				}
			}
		}

		[DataMember]
		public string sorumluTckn
		{
			get
			{
				return this.sorumluTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sorumluTcknField, value))
				{
					this.sorumluTcknField = value;
					this.RaisePropertyChanged("sorumluTckn");
				}
			}
		}

		[DataMember]
		public string soyad
		{
			get
			{
				return this.soyadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.soyadField, value))
				{
					this.soyadField = value;
					this.RaisePropertyChanged("soyad");
				}
			}
		}

		[DataMember]
		public sozlesme[] sozlesmeListesi
		{
			get
			{
				return this.sozlesmeListesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sozlesmeListesiField, value))
				{
					this.sozlesmeListesiField = value;
					this.RaisePropertyChanged("sozlesmeListesi");
				}
			}
		}

		[DataMember]
		public sube[] subeListesi
		{
			get
			{
				return this.subeListesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.subeListesiField, value))
				{
					this.subeListesiField = value;
					this.RaisePropertyChanged("subeListesi");
				}
			}
		}

		[DataMember]
		public string ticaretOdasi
		{
			get
			{
				return this.ticaretOdasiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ticaretOdasiField, value))
				{
					this.ticaretOdasiField = value;
					this.RaisePropertyChanged("ticaretOdasi");
				}
			}
		}

		[DataMember]
		public string ticaretSicilNo
		{
			get
			{
				return this.ticaretSicilNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ticaretSicilNoField, value))
				{
					this.ticaretSicilNoField = value;
					this.RaisePropertyChanged("ticaretSicilNo");
				}
			}
		}

		[DataMember]
		public string unvan
		{
			get
			{
				return this.unvanField;
			}
			set
			{
				if (!object.ReferenceEquals(this.unvanField, value))
				{
					this.unvanField = value;
					this.RaisePropertyChanged("unvan");
				}
			}
		}

		[DataMember]
		public string vergiDairesi
		{
			get
			{
				return this.vergiDairesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vergiDairesiField, value))
				{
					this.vergiDairesiField = value;
					this.RaisePropertyChanged("vergiDairesi");
				}
			}
		}

		[DataMember]
		public string vergiDairesiIl
		{
			get
			{
				return this.vergiDairesiIlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vergiDairesiIlField, value))
				{
					this.vergiDairesiIlField = value;
					this.RaisePropertyChanged("vergiDairesiIl");
				}
			}
		}

		[DataMember]
		public string vknTckn
		{
			get
			{
				return this.vknTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vknTcknField, value))
				{
					this.vknTcknField = value;
					this.RaisePropertyChanged("vknTckn");
				}
			}
		}

		public musteri()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}