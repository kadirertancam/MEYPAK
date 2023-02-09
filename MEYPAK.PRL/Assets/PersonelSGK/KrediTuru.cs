using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="KrediTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class KrediTuru : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string baslangicTarihiField;

		[OptionalField]
		private decimal birimFiyatField;

		[OptionalField]
		private int birimMiktariField;

		[OptionalField]
		private string faturaNoField;

		[OptionalField]
		private OdemeTuru odemeTuruField;

		[OptionalField]
		private string sonKullanimTarihiField;

		[OptionalField]
		private int taksitSayisiField;

		[DataMember]
		public string baslangicTarihi
		{
			get
			{
				return this.baslangicTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.baslangicTarihiField, value))
				{
					this.baslangicTarihiField = value;
					this.RaisePropertyChanged("baslangicTarihi");
				}
			}
		}

		[DataMember]
		public decimal birimFiyat
		{
			get
			{
				return this.birimFiyatField;
			}
			set
			{
				if (!this.birimFiyatField.Equals(value))
				{
					this.birimFiyatField = value;
					this.RaisePropertyChanged("birimFiyat");
				}
			}
		}

		[DataMember]
		public int birimMiktari
		{
			get
			{
				return this.birimMiktariField;
			}
			set
			{
				if (!this.birimMiktariField.Equals(value))
				{
					this.birimMiktariField = value;
					this.RaisePropertyChanged("birimMiktari");
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
		public string faturaNo
		{
			get
			{
				return this.faturaNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.faturaNoField, value))
				{
					this.faturaNoField = value;
					this.RaisePropertyChanged("faturaNo");
				}
			}
		}

		[DataMember]
		public OdemeTuru odemeTuru
		{
			get
			{
				return this.odemeTuruField;
			}
			set
			{
				if (!this.odemeTuruField.Equals(value))
				{
					this.odemeTuruField = value;
					this.RaisePropertyChanged("odemeTuru");
				}
			}
		}

		[DataMember]
		public string sonKullanimTarihi
		{
			get
			{
				return this.sonKullanimTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sonKullanimTarihiField, value))
				{
					this.sonKullanimTarihiField = value;
					this.RaisePropertyChanged("sonKullanimTarihi");
				}
			}
		}

		[DataMember]
		public int taksitSayisi
		{
			get
			{
				return this.taksitSayisiField;
			}
			set
			{
				if (!this.taksitSayisiField.Equals(value))
				{
					this.taksitSayisiField = value;
					this.RaisePropertyChanged("taksitSayisi");
				}
			}
		}

		public KrediTuru()
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