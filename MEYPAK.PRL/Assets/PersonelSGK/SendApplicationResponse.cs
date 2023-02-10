using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="SendApplicationResponse", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class SendApplicationResponse : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private ApplicationReponseDocumentInfo[] DocumentsField;

		[OptionalField]
		private string ResponseCodeField;

		[OptionalField]
		private string ResponseDescriptionField;

		[DataMember]
		public int AppType
		{
			get
			{
				return this.AppTypeField;
			}
			set
			{
				if (!this.AppTypeField.Equals(value))
				{
					this.AppTypeField = value;
					this.RaisePropertyChanged("AppType");
				}
			}
		}

		[DataMember]
		public ApplicationReponseDocumentInfo[] Documents
		{
			get
			{
				return this.DocumentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentsField, value))
				{
					this.DocumentsField = value;
					this.RaisePropertyChanged("Documents");
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
		public string ResponseCode
		{
			get
			{
				return this.ResponseCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ResponseCodeField, value))
				{
					this.ResponseCodeField = value;
					this.RaisePropertyChanged("ResponseCode");
				}
			}
		}

		[DataMember]
		public string ResponseDescription
		{
			get
			{
				return this.ResponseDescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ResponseDescriptionField, value))
				{
					this.ResponseDescriptionField = value;
					this.RaisePropertyChanged("ResponseDescription");
				}
			}
		}

		public SendApplicationResponse()
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