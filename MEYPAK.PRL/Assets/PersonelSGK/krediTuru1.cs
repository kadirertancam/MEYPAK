using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="krediTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class krediTuru1 : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int birimMiktariField;

		[OptionalField]
		private string faturaNoField;

		[OptionalField]
		private decimal fiyatField;

		[OptionalField]
		private odemeTuru1 odemeTuruField;

		[OptionalField]
		private int taksitSayisiField;

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
		public decimal fiyat
		{
			get
			{
				return this.fiyatField;
			}
			set
			{
				if (!this.fiyatField.Equals(value))
				{
					this.fiyatField = value;
					this.RaisePropertyChanged("fiyat");
				}
			}
		}

		[DataMember]
		public odemeTuru1 odemeTuru
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

		public krediTuru1()
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