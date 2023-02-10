using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="AdditionalDocumentReference", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AdditionalDocumentReference : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string DocumentTypeField;

		[OptionalField]
		private string DocumentTypeCodeField;

		[OptionalField]
		private string IDField;

		[OptionalField]
		private string IssueDateField;

		[DataMember]
		public string DocumentType
		{
			get
			{
				return this.DocumentTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentTypeField, value))
				{
					this.DocumentTypeField = value;
					this.RaisePropertyChanged("DocumentType");
				}
			}
		}

		[DataMember]
		public string DocumentTypeCode
		{
			get
			{
				return this.DocumentTypeCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentTypeCodeField, value))
				{
					this.DocumentTypeCodeField = value;
					this.RaisePropertyChanged("DocumentTypeCode");
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
		public string ID
		{
			get
			{
				return this.IDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IDField, value))
				{
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}

		[DataMember]
		public string IssueDate
		{
			get
			{
				return this.IssueDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IssueDateField, value))
				{
					this.IssueDateField = value;
					this.RaisePropertyChanged("IssueDate");
				}
			}
		}

		public AdditionalDocumentReference()
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