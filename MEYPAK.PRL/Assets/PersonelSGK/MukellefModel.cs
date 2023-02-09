using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MukellefModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MukellefModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string adField;

		[OptionalField]
		private AdresBilgileri[] adresBilgileriField;

		[OptionalField]
		private string babaAdiField;

		[OptionalField]
		private string dogumYeriField;

		[OptionalField]
		private Durum durumField;

		[OptionalField]
		private string faalTerkDurumuField;

		[OptionalField]
		private string iseBaslamaTarihiField;

		[OptionalField]
		private string isiBirakmaTarihiField;

		[OptionalField]
		private string kimlikPotansiyelField;

		[OptionalField]
		private string kimlikUnvaniField;

		[OptionalField]
		private string kurulusTarihiField;

		[OptionalField]
		private NACEFaaliyetKoduveTanimi[] nACEFaaliyetKoduveTanimiField;

		[OptionalField]
		private string sirketinTuruField;

		[OptionalField]
		private string soyadField;

		[OptionalField]
		private string tamDarMukellefiyetField;

		[OptionalField]
		private string tcknField;

		[OptionalField]
		private string unvanField;

		[OptionalField]
		private string vergiDairesiAdiField;

		[OptionalField]
		private string vergiDairesiKoduField;

		[OptionalField]
		private string vknField;

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
		public AdresBilgileri[] adresBilgileri
		{
			get
			{
				return this.adresBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.adresBilgileriField, value))
				{
					this.adresBilgileriField = value;
					this.RaisePropertyChanged("adresBilgileri");
				}
			}
		}

		[DataMember]
		public string babaAdi
		{
			get
			{
				return this.babaAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.babaAdiField, value))
				{
					this.babaAdiField = value;
					this.RaisePropertyChanged("babaAdi");
				}
			}
		}

		[DataMember]
		public string dogumYeri
		{
			get
			{
				return this.dogumYeriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.dogumYeriField, value))
				{
					this.dogumYeriField = value;
					this.RaisePropertyChanged("dogumYeri");
				}
			}
		}

		[DataMember]
		public Durum durum
		{
			get
			{
				return this.durumField;
			}
			set
			{
				if (!object.ReferenceEquals(this.durumField, value))
				{
					this.durumField = value;
					this.RaisePropertyChanged("durum");
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
		public string faalTerkDurumu
		{
			get
			{
				return this.faalTerkDurumuField;
			}
			set
			{
				if (!object.ReferenceEquals(this.faalTerkDurumuField, value))
				{
					this.faalTerkDurumuField = value;
					this.RaisePropertyChanged("faalTerkDurumu");
				}
			}
		}

		[DataMember]
		public string iseBaslamaTarihi
		{
			get
			{
				return this.iseBaslamaTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.iseBaslamaTarihiField, value))
				{
					this.iseBaslamaTarihiField = value;
					this.RaisePropertyChanged("iseBaslamaTarihi");
				}
			}
		}

		[DataMember]
		public string isiBirakmaTarihi
		{
			get
			{
				return this.isiBirakmaTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.isiBirakmaTarihiField, value))
				{
					this.isiBirakmaTarihiField = value;
					this.RaisePropertyChanged("isiBirakmaTarihi");
				}
			}
		}

		[DataMember]
		public string kimlikPotansiyel
		{
			get
			{
				return this.kimlikPotansiyelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kimlikPotansiyelField, value))
				{
					this.kimlikPotansiyelField = value;
					this.RaisePropertyChanged("kimlikPotansiyel");
				}
			}
		}

		[DataMember]
		public string kimlikUnvani
		{
			get
			{
				return this.kimlikUnvaniField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kimlikUnvaniField, value))
				{
					this.kimlikUnvaniField = value;
					this.RaisePropertyChanged("kimlikUnvani");
				}
			}
		}

		[DataMember]
		public string kurulusTarihi
		{
			get
			{
				return this.kurulusTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kurulusTarihiField, value))
				{
					this.kurulusTarihiField = value;
					this.RaisePropertyChanged("kurulusTarihi");
				}
			}
		}

		[DataMember]
		public NACEFaaliyetKoduveTanimi[] nACEFaaliyetKoduveTanimi
		{
			get
			{
				return this.nACEFaaliyetKoduveTanimiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.nACEFaaliyetKoduveTanimiField, value))
				{
					this.nACEFaaliyetKoduveTanimiField = value;
					this.RaisePropertyChanged("nACEFaaliyetKoduveTanimi");
				}
			}
		}

		[DataMember]
		public string sirketinTuru
		{
			get
			{
				return this.sirketinTuruField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sirketinTuruField, value))
				{
					this.sirketinTuruField = value;
					this.RaisePropertyChanged("sirketinTuru");
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
		public string tamDarMukellefiyet
		{
			get
			{
				return this.tamDarMukellefiyetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.tamDarMukellefiyetField, value))
				{
					this.tamDarMukellefiyetField = value;
					this.RaisePropertyChanged("tamDarMukellefiyet");
				}
			}
		}

		[DataMember]
		public string tckn
		{
			get
			{
				return this.tcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.tcknField, value))
				{
					this.tcknField = value;
					this.RaisePropertyChanged("tckn");
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
		public string vergiDairesiAdi
		{
			get
			{
				return this.vergiDairesiAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vergiDairesiAdiField, value))
				{
					this.vergiDairesiAdiField = value;
					this.RaisePropertyChanged("vergiDairesiAdi");
				}
			}
		}

		[DataMember]
		public string vergiDairesiKodu
		{
			get
			{
				return this.vergiDairesiKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vergiDairesiKoduField, value))
				{
					this.vergiDairesiKoduField = value;
					this.RaisePropertyChanged("vergiDairesiKodu");
				}
			}
		}

		[DataMember]
		public string vkn
		{
			get
			{
				return this.vknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vknField, value))
				{
					this.vknField = value;
					this.RaisePropertyChanged("vkn");
				}
			}
		}

		public MukellefModel()
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