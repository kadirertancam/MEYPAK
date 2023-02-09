using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="etiketler", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class etiketler : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string etiketField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.etiketTuru etiketTuruField;

		[OptionalField]
		private int referansIdField;

		[DataMember]
		public string etiket
		{
			get
			{
				return this.etiketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.etiketField, value))
				{
					this.etiketField = value;
					this.RaisePropertyChanged("etiket");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.etiketTuru etiketTuru
		{
			get
			{
				return this.etiketTuruField;
			}
			set
			{
				if (!this.etiketTuruField.Equals(value))
				{
					this.etiketTuruField = value;
					this.RaisePropertyChanged("etiketTuru");
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

		public etiketler()
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