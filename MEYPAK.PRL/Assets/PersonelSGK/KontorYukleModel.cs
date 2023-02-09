using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="KontorYukleModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class KontorYukleModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private BirimTuru birimTuruField;

		[OptionalField]
		private IslemTuru islemTuruField;

		[OptionalField]
		private KrediTuru krediTuruField;

		[OptionalField]
		private string vkn_tcknField;

		[DataMember]
		public BirimTuru birimTuru
		{
			get
			{
				return this.birimTuruField;
			}
			set
			{
				if (!this.birimTuruField.Equals(value))
				{
					this.birimTuruField = value;
					this.RaisePropertyChanged("birimTuru");
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
		public IslemTuru islemTuru
		{
			get
			{
				return this.islemTuruField;
			}
			set
			{
				if (!this.islemTuruField.Equals(value))
				{
					this.islemTuruField = value;
					this.RaisePropertyChanged("islemTuru");
				}
			}
		}

		[DataMember]
		public KrediTuru krediTuru
		{
			get
			{
				return this.krediTuruField;
			}
			set
			{
				if (!object.ReferenceEquals(this.krediTuruField, value))
				{
					this.krediTuruField = value;
					this.RaisePropertyChanged("krediTuru");
				}
			}
		}

		[DataMember]
		public string vkn_tckn
		{
			get
			{
				return this.vkn_tcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vkn_tcknField, value))
				{
					this.vkn_tcknField = value;
					this.RaisePropertyChanged("vkn_tckn");
				}
			}
		}

		public KontorYukleModel()
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