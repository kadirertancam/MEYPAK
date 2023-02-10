using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="AdresBilgileri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AdresBilgileri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string adresTipiField;

		[OptionalField]
		private string adresTipiAciklamasiField;

		[OptionalField]
		private string beldeBucakField;

		[OptionalField]
		private string caddeSokakField;

		[OptionalField]
		private string disKapiNoField;

		[OptionalField]
		private string icKapiNoField;

		[OptionalField]
		private string ilAdiField;

		[OptionalField]
		private string ilKoduField;

		[OptionalField]
		private string ilceAdiField;

		[OptionalField]
		private string ilceKoduField;

		[OptionalField]
		private string koyField;

		[OptionalField]
		private string mahalleSemtField;

		[DataMember]
		public string adresTipi
		{
			get
			{
				return this.adresTipiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.adresTipiField, value))
				{
					this.adresTipiField = value;
					this.RaisePropertyChanged("adresTipi");
				}
			}
		}

		[DataMember]
		public string adresTipiAciklamasi
		{
			get
			{
				return this.adresTipiAciklamasiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.adresTipiAciklamasiField, value))
				{
					this.adresTipiAciklamasiField = value;
					this.RaisePropertyChanged("adresTipiAciklamasi");
				}
			}
		}

		[DataMember]
		public string beldeBucak
		{
			get
			{
				return this.beldeBucakField;
			}
			set
			{
				if (!object.ReferenceEquals(this.beldeBucakField, value))
				{
					this.beldeBucakField = value;
					this.RaisePropertyChanged("beldeBucak");
				}
			}
		}

		[DataMember]
		public string caddeSokak
		{
			get
			{
				return this.caddeSokakField;
			}
			set
			{
				if (!object.ReferenceEquals(this.caddeSokakField, value))
				{
					this.caddeSokakField = value;
					this.RaisePropertyChanged("caddeSokak");
				}
			}
		}

		[DataMember]
		public string disKapiNo
		{
			get
			{
				return this.disKapiNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.disKapiNoField, value))
				{
					this.disKapiNoField = value;
					this.RaisePropertyChanged("disKapiNo");
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
		public string icKapiNo
		{
			get
			{
				return this.icKapiNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.icKapiNoField, value))
				{
					this.icKapiNoField = value;
					this.RaisePropertyChanged("icKapiNo");
				}
			}
		}

		[DataMember]
		public string ilAdi
		{
			get
			{
				return this.ilAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ilAdiField, value))
				{
					this.ilAdiField = value;
					this.RaisePropertyChanged("ilAdi");
				}
			}
		}

		[DataMember]
		public string ilceAdi
		{
			get
			{
				return this.ilceAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ilceAdiField, value))
				{
					this.ilceAdiField = value;
					this.RaisePropertyChanged("ilceAdi");
				}
			}
		}

		[DataMember]
		public string ilceKodu
		{
			get
			{
				return this.ilceKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ilceKoduField, value))
				{
					this.ilceKoduField = value;
					this.RaisePropertyChanged("ilceKodu");
				}
			}
		}

		[DataMember]
		public string ilKodu
		{
			get
			{
				return this.ilKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ilKoduField, value))
				{
					this.ilKoduField = value;
					this.RaisePropertyChanged("ilKodu");
				}
			}
		}

		[DataMember]
		public string koy
		{
			get
			{
				return this.koyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.koyField, value))
				{
					this.koyField = value;
					this.RaisePropertyChanged("koy");
				}
			}
		}

		[DataMember]
		public string mahalleSemt
		{
			get
			{
				return this.mahalleSemtField;
			}
			set
			{
				if (!object.ReferenceEquals(this.mahalleSemtField, value))
				{
					this.mahalleSemtField = value;
					this.RaisePropertyChanged("mahalleSemt");
				}
			}
		}

		public AdresBilgileri()
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