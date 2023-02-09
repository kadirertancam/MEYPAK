using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="IrsaliyeKalemleri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.IrsaliyeModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class IrsaliyeKalemleri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string Alici_Mal_KoduField;

		[OptionalField]
		private string BirimField;

		[OptionalField]
		private decimal Birim_FiyatField;

		[OptionalField]
		private string Mal_AciklamasiField;

		[OptionalField]
		private string Mal_AdiField;

		[OptionalField]
		private string Mal_MarkasiField;

		[OptionalField]
		private string Mal_ModeliField;

		[OptionalField]
		private string Mal_SinifiField;

		[OptionalField]
		private decimal Mal_TutariField;

		[OptionalField]
		private decimal MiktarField;

		[OptionalField]
		private string Para_BirimiField;

		[OptionalField]
		private string Satici_Mal_KoduField;

		[OptionalField]
		private string Satir_NotuField;

		[OptionalField]
		private int SiraNoField;

		[OptionalField]
		private decimal Sonra_Gonderilecek_MiktarField;

		[OptionalField]
		private string Uretici_BarkoduField;

		[DataMember]
		public string Alici_Mal_Kodu
		{
			get
			{
				return this.Alici_Mal_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Alici_Mal_KoduField, value))
				{
					this.Alici_Mal_KoduField = value;
					this.RaisePropertyChanged("Alici_Mal_Kodu");
				}
			}
		}

		[DataMember]
		public string Birim
		{
			get
			{
				return this.BirimField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BirimField, value))
				{
					this.BirimField = value;
					this.RaisePropertyChanged("Birim");
				}
			}
		}

		[DataMember]
		public decimal Birim_Fiyat
		{
			get
			{
				return this.Birim_FiyatField;
			}
			set
			{
				if (!this.Birim_FiyatField.Equals(value))
				{
					this.Birim_FiyatField = value;
					this.RaisePropertyChanged("Birim_Fiyat");
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
		public string Mal_Aciklamasi
		{
			get
			{
				return this.Mal_AciklamasiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Mal_AciklamasiField, value))
				{
					this.Mal_AciklamasiField = value;
					this.RaisePropertyChanged("Mal_Aciklamasi");
				}
			}
		}

		[DataMember]
		public string Mal_Adi
		{
			get
			{
				return this.Mal_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Mal_AdiField, value))
				{
					this.Mal_AdiField = value;
					this.RaisePropertyChanged("Mal_Adi");
				}
			}
		}

		[DataMember]
		public string Mal_Markasi
		{
			get
			{
				return this.Mal_MarkasiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Mal_MarkasiField, value))
				{
					this.Mal_MarkasiField = value;
					this.RaisePropertyChanged("Mal_Markasi");
				}
			}
		}

		[DataMember]
		public string Mal_Modeli
		{
			get
			{
				return this.Mal_ModeliField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Mal_ModeliField, value))
				{
					this.Mal_ModeliField = value;
					this.RaisePropertyChanged("Mal_Modeli");
				}
			}
		}

		[DataMember]
		public string Mal_Sinifi
		{
			get
			{
				return this.Mal_SinifiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Mal_SinifiField, value))
				{
					this.Mal_SinifiField = value;
					this.RaisePropertyChanged("Mal_Sinifi");
				}
			}
		}

		[DataMember]
		public decimal Mal_Tutari
		{
			get
			{
				return this.Mal_TutariField;
			}
			set
			{
				if (!this.Mal_TutariField.Equals(value))
				{
					this.Mal_TutariField = value;
					this.RaisePropertyChanged("Mal_Tutari");
				}
			}
		}

		[DataMember]
		public decimal Miktar
		{
			get
			{
				return this.MiktarField;
			}
			set
			{
				if (!this.MiktarField.Equals(value))
				{
					this.MiktarField = value;
					this.RaisePropertyChanged("Miktar");
				}
			}
		}

		[DataMember]
		public string Para_Birimi
		{
			get
			{
				return this.Para_BirimiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Para_BirimiField, value))
				{
					this.Para_BirimiField = value;
					this.RaisePropertyChanged("Para_Birimi");
				}
			}
		}

		[DataMember]
		public string Satici_Mal_Kodu
		{
			get
			{
				return this.Satici_Mal_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Satici_Mal_KoduField, value))
				{
					this.Satici_Mal_KoduField = value;
					this.RaisePropertyChanged("Satici_Mal_Kodu");
				}
			}
		}

		[DataMember]
		public string Satir_Notu
		{
			get
			{
				return this.Satir_NotuField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Satir_NotuField, value))
				{
					this.Satir_NotuField = value;
					this.RaisePropertyChanged("Satir_Notu");
				}
			}
		}

		[DataMember]
		public int SiraNo
		{
			get
			{
				return this.SiraNoField;
			}
			set
			{
				if (!this.SiraNoField.Equals(value))
				{
					this.SiraNoField = value;
					this.RaisePropertyChanged("SiraNo");
				}
			}
		}

		[DataMember]
		public decimal Sonra_Gonderilecek_Miktar
		{
			get
			{
				return this.Sonra_Gonderilecek_MiktarField;
			}
			set
			{
				if (!this.Sonra_Gonderilecek_MiktarField.Equals(value))
				{
					this.Sonra_Gonderilecek_MiktarField = value;
					this.RaisePropertyChanged("Sonra_Gonderilecek_Miktar");
				}
			}
		}

		[DataMember]
		public string Uretici_Barkodu
		{
			get
			{
				return this.Uretici_BarkoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Uretici_BarkoduField, value))
				{
					this.Uretici_BarkoduField = value;
					this.RaisePropertyChanged("Uretici_Barkodu");
				}
			}
		}

		public IrsaliyeKalemleri()
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