using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="SoforBilgileri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.IrsaliyeModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class SoforBilgileri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AdField;

		[OptionalField]
		private string SoyadField;

		[OptionalField]
		private string string_0;

		[DataMember]
		public string Ad
		{
			get
			{
				return this.AdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AdField, value))
				{
					this.AdField = value;
					this.RaisePropertyChanged("Ad");
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
		public string Soyad
		{
			get
			{
				return this.SoyadField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SoyadField, value))
				{
					this.SoyadField = value;
					this.RaisePropertyChanged("Soyad");
				}
			}
		}

		[DataMember]
		public string TCKN
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (!object.ReferenceEquals(this.string_0, value))
				{
					this.string_0 = value;
					this.RaisePropertyChanged("TCKN");
				}
			}
		}

		public SoforBilgileri()
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