using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="kredi", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class kredi : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private birimTuru1 birimTuruField;

		[OptionalField]
		private islemTuru1 islemTuruField;

		[OptionalField]
		private krediTuru1 krediTuruField;

		[DataMember]
		public birimTuru1 birimTuru
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
		public islemTuru1 islemTuru
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
		public krediTuru1 krediTuru
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

		public kredi()
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