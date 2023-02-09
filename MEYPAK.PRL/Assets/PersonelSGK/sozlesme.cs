using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="sozlesme", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class sozlesme : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private hizmet[] hizmetListesiField;

		[OptionalField]
		private bool otomatikYenilenmeField;

		[OptionalField]
		private int referansIdField;

		[OptionalField]
		private string sozlesmeBaslangicTarihiField;

		[OptionalField]
		private string sozlesmeBitisTarihiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.tarifeTuru tarifeTuruField;

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
		public hizmet[] hizmetListesi
		{
			get
			{
				return this.hizmetListesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.hizmetListesiField, value))
				{
					this.hizmetListesiField = value;
					this.RaisePropertyChanged("hizmetListesi");
				}
			}
		}

		[DataMember]
		public bool otomatikYenilenme
		{
			get
			{
				return this.otomatikYenilenmeField;
			}
			set
			{
				if (!this.otomatikYenilenmeField.Equals(value))
				{
					this.otomatikYenilenmeField = value;
					this.RaisePropertyChanged("otomatikYenilenme");
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

		[DataMember]
		public string sozlesmeBaslangicTarihi
		{
			get
			{
				return this.sozlesmeBaslangicTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sozlesmeBaslangicTarihiField, value))
				{
					this.sozlesmeBaslangicTarihiField = value;
					this.RaisePropertyChanged("sozlesmeBaslangicTarihi");
				}
			}
		}

		[DataMember]
		public string sozlesmeBitisTarihi
		{
			get
			{
				return this.sozlesmeBitisTarihiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sozlesmeBitisTarihiField, value))
				{
					this.sozlesmeBitisTarihiField = value;
					this.RaisePropertyChanged("sozlesmeBitisTarihi");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.tarifeTuru tarifeTuru
		{
			get
			{
				return this.tarifeTuruField;
			}
			set
			{
				if (!this.tarifeTuruField.Equals(value))
				{
					this.tarifeTuruField = value;
					this.RaisePropertyChanged("tarifeTuru");
				}
			}
		}

		public sozlesme()
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