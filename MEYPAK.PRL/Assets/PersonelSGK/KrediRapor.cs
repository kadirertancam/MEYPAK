using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="KrediRapor", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class KrediRapor : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private decimal BirimMiktariField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.BirimTuru BirimTuruField;

		[OptionalField]
		private decimal FiyatField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.IslemTuru IslemTuruField;

		[OptionalField]
		private string KullanimBaslangicTarihiField;

		[OptionalField]
		private string KullanimBitisTarihiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.OdemeTuru OdemeTuruField;

		[OptionalField]
		private string SatinAlmaTarihiField;

		[OptionalField]
		private int TaksitSayisiField;

		[OptionalField]
		private string VknTcknField;

		[DataMember]
		public decimal BirimMiktari
		{
			get
			{
				return this.BirimMiktariField;
			}
			set
			{
				if (!this.BirimMiktariField.Equals(value))
				{
					this.BirimMiktariField = value;
					this.RaisePropertyChanged("BirimMiktari");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.BirimTuru BirimTuru
		{
			get
			{
				return this.BirimTuruField;
			}
			set
			{
				if (!this.BirimTuruField.Equals(value))
				{
					this.BirimTuruField = value;
					this.RaisePropertyChanged("BirimTuru");
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
		public decimal Fiyat
		{
			get
			{
				return this.FiyatField;
			}
			set
			{
				if (!this.FiyatField.Equals(value))
				{
					this.FiyatField = value;
					this.RaisePropertyChanged("Fiyat");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.IslemTuru IslemTuru
		{
			get
			{
				return this.IslemTuruField;
			}
			set
			{
				if (!this.IslemTuruField.Equals(value))
				{
					this.IslemTuruField = value;
					this.RaisePropertyChanged("IslemTuru");
				}
			}
		}

		[DataMember]
		public string KullanimBaslangicTarihi
		{
			get
			{
				return this.KullanimBaslangicTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KullanimBaslangicTarihiField, value))
				{
					this.KullanimBaslangicTarihiField = value;
					this.RaisePropertyChanged("KullanimBaslangicTarihi");
				}
			}
		}

		[DataMember]
		public string KullanimBitisTarihi
		{
			get
			{
				return this.KullanimBitisTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KullanimBitisTarihiField, value))
				{
					this.KullanimBitisTarihiField = value;
					this.RaisePropertyChanged("KullanimBitisTarihi");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.OdemeTuru OdemeTuru
		{
			get
			{
				return this.OdemeTuruField;
			}
			set
			{
				if (!this.OdemeTuruField.Equals(value))
				{
					this.OdemeTuruField = value;
					this.RaisePropertyChanged("OdemeTuru");
				}
			}
		}

		[DataMember]
		public string SatinAlmaTarihi
		{
			get
			{
				return this.SatinAlmaTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SatinAlmaTarihiField, value))
				{
					this.SatinAlmaTarihiField = value;
					this.RaisePropertyChanged("SatinAlmaTarihi");
				}
			}
		}

		[DataMember]
		public int TaksitSayisi
		{
			get
			{
				return this.TaksitSayisiField;
			}
			set
			{
				if (!this.TaksitSayisiField.Equals(value))
				{
					this.TaksitSayisiField = value;
					this.RaisePropertyChanged("TaksitSayisi");
				}
			}
		}

		[DataMember]
		public string VknTckn
		{
			get
			{
				return this.VknTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VknTcknField, value))
				{
					this.VknTcknField = value;
					this.RaisePropertyChanged("VknTckn");
				}
			}
		}

		public KrediRapor()
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