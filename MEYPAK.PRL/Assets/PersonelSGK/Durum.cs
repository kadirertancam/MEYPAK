using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Durum", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Durum : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string durumKodAciklamasiField;

		[OptionalField]
		private string durumKoduField;

		[OptionalField]
		private string hataDetayBilgisiField;

		[OptionalField]
		private bool sonucField;

		[DataMember]
		public string durumKodAciklamasi
		{
			get
			{
				return this.durumKodAciklamasiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.durumKodAciklamasiField, value))
				{
					this.durumKodAciklamasiField = value;
					this.RaisePropertyChanged("durumKodAciklamasi");
				}
			}
		}

		[DataMember]
		public string durumKodu
		{
			get
			{
				return this.durumKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.durumKoduField, value))
				{
					this.durumKoduField = value;
					this.RaisePropertyChanged("durumKodu");
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
		public string hataDetayBilgisi
		{
			get
			{
				return this.hataDetayBilgisiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.hataDetayBilgisiField, value))
				{
					this.hataDetayBilgisiField = value;
					this.RaisePropertyChanged("hataDetayBilgisi");
				}
			}
		}

		[DataMember]
		public bool sonuc
		{
			get
			{
				return this.sonucField;
			}
			set
			{
				if (!this.sonucField.Equals(value))
				{
					this.sonucField = value;
					this.RaisePropertyChanged("sonuc");
				}
			}
		}

		public Durum()
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