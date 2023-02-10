using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="musteriOutput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class musteriOutput : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int IlIdField;

		[OptionalField]
		private int IlceIdField;

		[OptionalField]
		private bool hataField;

		[OptionalField]
		private string[] hataMesajiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.musteri musteriField;

		[OptionalField]
		private int referansIdField;

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
		public bool hata
		{
			get
			{
				return this.hataField;
			}
			set
			{
				if (!this.hataField.Equals(value))
				{
					this.hataField = value;
					this.RaisePropertyChanged("hata");
				}
			}
		}

		[DataMember]
		public string[] hataMesaji
		{
			get
			{
				return this.hataMesajiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.hataMesajiField, value))
				{
					this.hataMesajiField = value;
					this.RaisePropertyChanged("hataMesaji");
				}
			}
		}

		[DataMember]
		public int IlceId
		{
			get
			{
				return this.IlceIdField;
			}
			set
			{
				if (!this.IlceIdField.Equals(value))
				{
					this.IlceIdField = value;
					this.RaisePropertyChanged("IlceId");
				}
			}
		}

		[DataMember]
		public int IlId
		{
			get
			{
				return this.IlIdField;
			}
			set
			{
				if (!this.IlIdField.Equals(value))
				{
					this.IlIdField = value;
					this.RaisePropertyChanged("IlId");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.musteri musteri
		{
			get
			{
				return this.musteriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.musteriField, value))
				{
					this.musteriField = value;
					this.RaisePropertyChanged("musteri");
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

		public musteriOutput()
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