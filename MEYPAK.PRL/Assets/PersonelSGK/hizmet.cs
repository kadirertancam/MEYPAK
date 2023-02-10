using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="hizmet", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class hizmet : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string aciklamaField;

		[OptionalField]
		private etiketler[] etiketListesiField;

		[OptionalField]
		private decimal fiyatField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.hizmetTuru hizmetTuruField;

		[OptionalField]
		private int referansIdField;

		[DataMember]
		public string aciklama
		{
			get
			{
				return this.aciklamaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.aciklamaField, value))
				{
					this.aciklamaField = value;
					this.RaisePropertyChanged("aciklama");
				}
			}
		}

		[DataMember]
		public etiketler[] etiketListesi
		{
			get
			{
				return this.etiketListesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.etiketListesiField, value))
				{
					this.etiketListesiField = value;
					this.RaisePropertyChanged("etiketListesi");
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
		public OPTYPE.HizliTeknoloji.hizmetTuru hizmetTuru
		{
			get
			{
				return this.hizmetTuruField;
			}
			set
			{
				if (!this.hizmetTuruField.Equals(value))
				{
					this.hizmetTuruField = value;
					this.RaisePropertyChanged("hizmetTuru");
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

		public hizmet()
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