using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="CustomerAgentParty", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CustomerAgentParty : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Customer customerAgentPartyField;

		[DataMember]
		public Customer customerAgentParty
		{
			get
			{
				return this.customerAgentPartyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.customerAgentPartyField, value))
				{
					this.customerAgentPartyField = value;
					this.RaisePropertyChanged("customerAgentParty");
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

		public CustomerAgentParty()
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