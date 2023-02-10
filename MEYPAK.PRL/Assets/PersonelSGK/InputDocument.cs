using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InputDocument", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InputDocument : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private int BrachCodeField;

		[OptionalField]
		private string DestinationIdentifierField;

		[OptionalField]
		private string DestinationUrnField;

		[OptionalField]
		private string DocumentDateField;

		[OptionalField]
		private string DocumentIdField;

		[OptionalField]
		private string DocumentUUIDField;

		[OptionalField]
		private string ESmmNoteField;

		[OptionalField]
		private bool IsDraftField;

		[OptionalField]
		private bool IsDraftSendField;

		[OptionalField]
		private string LocalIdField;

		[OptionalField]
		private string SourceUrnField;

		[OptionalField]
		private bool UpdateDocumentField;

		[OptionalField]
		private string XmlContentField;

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
		public int BrachCode
		{
			get
			{
				return this.BrachCodeField;
			}
			set
			{
				if (!this.BrachCodeField.Equals(value))
				{
					this.BrachCodeField = value;
					this.RaisePropertyChanged("BrachCode");
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

		[DataMember]
		public string DocumentDate
		{
			get
			{
				return this.DocumentDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentDateField, value))
				{
					this.DocumentDateField = value;
					this.RaisePropertyChanged("DocumentDate");
				}
			}
		}

		[DataMember]
		public string DocumentId
		{
			get
			{
				return this.DocumentIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentIdField, value))
				{
					this.DocumentIdField = value;
					this.RaisePropertyChanged("DocumentId");
				}
			}
		}

		[DataMember]
		public string DocumentUUID
		{
			get
			{
				return this.DocumentUUIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentUUIDField, value))
				{
					this.DocumentUUIDField = value;
					this.RaisePropertyChanged("DocumentUUID");
				}
			}
		}

		[DataMember]
		public string ESmmNote
		{
			get
			{
				return this.ESmmNoteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ESmmNoteField, value))
				{
					this.ESmmNoteField = value;
					this.RaisePropertyChanged("ESmmNote");
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

		[DataMember]
		public string XmlContent
		{
			get
			{
				return this.XmlContentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.XmlContentField, value))
				{
					this.XmlContentField = value;
					this.RaisePropertyChanged("XmlContent");
				}
			}
		}

		public InputDocument()
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