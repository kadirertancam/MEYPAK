using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InputInvoiceModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InputInvoiceModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private string DestinationIdentifierField;

		[OptionalField]
		private string DestinationUrnField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.InvoiceModel InvoiceModelField;

		[OptionalField]
		private bool IsDraftField;

		[OptionalField]
		private bool IsDraftSendField;

		[OptionalField]
		private bool IsPreviewField;

		[OptionalField]
		private string LocalIdField;

		[OptionalField]
		private string SourceUrnField;

		[OptionalField]
		private bool UpdateDocumentField;

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
		public string DestinationIdentifier
		{
			get
			{
				return this.DestinationIdentifierField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DestinationIdentifierField, value))
				{
					this.DestinationIdentifierField = value;
					this.RaisePropertyChanged("DestinationIdentifier");
				}
			}
		}

		[DataMember]
		public string DestinationUrn
		{
			get
			{
				return this.DestinationUrnField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DestinationUrnField, value))
				{
					this.DestinationUrnField = value;
					this.RaisePropertyChanged("DestinationUrn");
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
		public OPTYPE.HizliTeknoloji.InvoiceModel InvoiceModel
		{
			get
			{
				return this.InvoiceModelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InvoiceModelField, value))
				{
					this.InvoiceModelField = value;
					this.RaisePropertyChanged("InvoiceModel");
				}
			}
		}

		[DataMember]
		public bool IsDraft
		{
			get
			{
				return this.IsDraftField;
			}
			set
			{
				if (!this.IsDraftField.Equals(value))
				{
					this.IsDraftField = value;
					this.RaisePropertyChanged("IsDraft");
				}
			}
		}

		[DataMember]
		public bool IsDraftSend
		{
			get
			{
				return this.IsDraftSendField;
			}
			set
			{
				if (!this.IsDraftSendField.Equals(value))
				{
					this.IsDraftSendField = value;
					this.RaisePropertyChanged("IsDraftSend");
				}
			}
		}

		[DataMember]
		public bool IsPreview
		{
			get
			{
				return this.IsPreviewField;
			}
			set
			{
				if (!this.IsPreviewField.Equals(value))
				{
					this.IsPreviewField = value;
					this.RaisePropertyChanged("IsPreview");
				}
			}
		}

		[DataMember]
		public string LocalId
		{
			get
			{
				return this.LocalIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LocalIdField, value))
				{
					this.LocalIdField = value;
					this.RaisePropertyChanged("LocalId");
				}
			}
		}

		[DataMember]
		public string SourceUrn
		{
			get
			{
				return this.SourceUrnField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SourceUrnField, value))
				{
					this.SourceUrnField = value;
					this.RaisePropertyChanged("SourceUrn");
				}
			}
		}

		[DataMember]
		public bool UpdateDocument
		{
			get
			{
				return this.UpdateDocumentField;
			}
			set
			{
				if (!this.UpdateDocumentField.Equals(value))
				{
					this.UpdateDocumentField = value;
					this.RaisePropertyChanged("UpdateDocument");
				}
			}
		}

		public InputInvoiceModel()
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