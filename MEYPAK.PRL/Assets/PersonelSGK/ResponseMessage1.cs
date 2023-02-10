using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="ResponseMessage", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[KnownType(typeof(MukellefOutput))]
	[Serializable]
	public class ResponseMessage1 : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool IsSucceededField;

		[OptionalField]
		private string MessageField;

		[OptionalField]
		private string MessageCodeField;

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
		public bool IsSucceeded
		{
			get
			{
				return this.IsSucceededField;
			}
			set
			{
				if (!this.IsSucceededField.Equals(value))
				{
					this.IsSucceededField = value;
					this.RaisePropertyChanged("IsSucceeded");
				}
			}
		}

		[DataMember]
		public string Message
		{
			get
			{
				return this.MessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MessageField, value))
				{
					this.MessageField = value;
					this.RaisePropertyChanged("Message");
				}
			}
		}

		[DataMember]
		public string MessageCode
		{
			get
			{
				return this.MessageCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MessageCodeField, value))
				{
					this.MessageCodeField = value;
					this.RaisePropertyChanged("MessageCode");
				}
			}
		}

		public ResponseMessage1()
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