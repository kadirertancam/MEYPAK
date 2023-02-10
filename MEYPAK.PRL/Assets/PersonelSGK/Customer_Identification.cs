using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Customer_Identification", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Customer_Identification : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string SchemeIDField;

		[OptionalField]
		private string ValueField;

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
		public string SchemeID
		{
			get
			{
				return this.SchemeIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SchemeIDField, value))
				{
					this.SchemeIDField = value;
					this.RaisePropertyChanged("SchemeID");
				}
			}
		}

		[DataMember]
		public string Value
		{
			get
			{
				return this.ValueField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ValueField, value))
				{
					this.ValueField = value;
					this.RaisePropertyChanged("Value");
				}
			}
		}

		public Customer_Identification()
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