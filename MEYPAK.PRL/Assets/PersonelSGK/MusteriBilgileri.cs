using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MusteriBilgileri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MusteriBilgileri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AdiField;

		[OptionalField]
		private string FirmaAdiField;

		[OptionalField]
		private string SoyadiField;

		[OptionalField]
		private string VergiNoTCKimlikNoField;

		[DataMember]
		public string Adi
		{
			get
			{
				return this.AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AdiField, value))
				{
					this.AdiField = value;
					this.RaisePropertyChanged("Adi");
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
		public string FirmaAdi
		{
			get
			{
				return this.FirmaAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FirmaAdiField, value))
				{
					this.FirmaAdiField = value;
					this.RaisePropertyChanged("FirmaAdi");
				}
			}
		}

		[DataMember]
		public string Soyadi
		{
			get
			{
				return this.SoyadiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SoyadiField, value))
				{
					this.SoyadiField = value;
					this.RaisePropertyChanged("Soyadi");
				}
			}
		}

		[DataMember]
		public string VergiNoTCKimlikNo
		{
			get
			{
				return this.VergiNoTCKimlikNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VergiNoTCKimlikNoField, value))
				{
					this.VergiNoTCKimlikNoField = value;
					this.RaisePropertyChanged("VergiNoTCKimlikNo");
				}
			}
		}

		public MusteriBilgileri()
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