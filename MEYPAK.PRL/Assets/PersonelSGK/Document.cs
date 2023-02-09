using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Document", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Document : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private DateTime? CancelDateField;

		[OptionalField]
		private bool? CancelOptionField;

		[OptionalField]
		private DateTime CreatedDateField;

		[OptionalField]
		private string DocumentCurrencyCodeField;

		[OptionalField]
		private string DocumentIdField;

		[OptionalField]
		private string DocumentTypeCodeField;

		[OptionalField]
		private string EnvelopeExpField;

		[OptionalField]
		private int EnvelopeStatusField;

		[OptionalField]
		private string EnvelopeUUIDField;

		[OptionalField]
		private bool IsAccountField;

		[OptionalField]
		private bool IsArchiveField;

		[OptionalField]
		private bool IsInternetSaleField;

		[OptionalField]
		private bool IsPrintedField;

		[OptionalField]
		private bool IsReadField;

		[OptionalField]
		private bool IsTransferredField;

		[OptionalField]
		private string IssueDateField;

		[OptionalField]
		private string LocalReferenceIdField;

		[OptionalField]
		private string MesssageField;

		[OptionalField]
		private decimal PayableAmountField;

		[OptionalField]
		private string ProfileIdField;

		[OptionalField]
		private string SendTypeField;

		[OptionalField]
		private string SourceAliasField;

		[OptionalField]
		private int StatusField;

		[OptionalField]
		private string StatusExpField;

		[OptionalField]
		private int SubeKoduField;

		[OptionalField]
		private string TargetAliasField;

		[OptionalField]
		private string TargetIdentifierField;

		[OptionalField]
		private string TargetTitleField;

		[OptionalField]
		private decimal TaxTotalField;

		[OptionalField]
		private string string_0;

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
		public DateTime? CancelDate
		{
			get
			{
				return this.CancelDateField;
			}
			set
			{
				if (!this.CancelDateField.Equals(value))
				{
					this.CancelDateField = value;
					this.RaisePropertyChanged("CancelDate");
				}
			}
		}

		[DataMember]
		public bool? CancelOption
		{
			get
			{
				return this.CancelOptionField;
			}
			set
			{
				if (!this.CancelOptionField.Equals(value))
				{
					this.CancelOptionField = value;
					this.RaisePropertyChanged("CancelOption");
				}
			}
		}

		[DataMember]
		public DateTime CreatedDate
		{
			get
			{
				return this.CreatedDateField;
			}
			set
			{
				if (!this.CreatedDateField.Equals(value))
				{
					this.CreatedDateField = value;
					this.RaisePropertyChanged("CreatedDate");
				}
			}
		}

		[DataMember]
		public string DocumentCurrencyCode
		{
			get
			{
				return this.DocumentCurrencyCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentCurrencyCodeField, value))
				{
					this.DocumentCurrencyCodeField = value;
					this.RaisePropertyChanged("DocumentCurrencyCode");
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

		[DataMember]
		public string EnvelopeExp
		{
			get
			{
				return this.EnvelopeExpField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EnvelopeExpField, value))
				{
					this.EnvelopeExpField = value;
					this.RaisePropertyChanged("EnvelopeExp");
				}
			}
		}

		[DataMember]
		public int EnvelopeStatus
		{
			get
			{
				return this.EnvelopeStatusField;
			}
			set
			{
				if (!this.EnvelopeStatusField.Equals(value))
				{
					this.EnvelopeStatusField = value;
					this.RaisePropertyChanged("EnvelopeStatus");
				}
			}
		}

		[DataMember]
		public string EnvelopeUUID
		{
			get
			{
				return this.EnvelopeUUIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EnvelopeUUIDField, value))
				{
					this.EnvelopeUUIDField = value;
					this.RaisePropertyChanged("EnvelopeUUID");
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
		public bool IsAccount
		{
			get
			{
				return this.IsAccountField;
			}
			set
			{
				if (!this.IsAccountField.Equals(value))
				{
					this.IsAccountField = value;
					this.RaisePropertyChanged("IsAccount");
				}
			}
		}

		[DataMember]
		public bool IsArchive
		{
			get
			{
				return this.IsArchiveField;
			}
			set
			{
				if (!this.IsArchiveField.Equals(value))
				{
					this.IsArchiveField = value;
					this.RaisePropertyChanged("IsArchive");
				}
			}
		}

		[DataMember]
		public bool IsInternetSale
		{
			get
			{
				return this.IsInternetSaleField;
			}
			set
			{
				if (!this.IsInternetSaleField.Equals(value))
				{
					this.IsInternetSaleField = value;
					this.RaisePropertyChanged("IsInternetSale");
				}
			}
		}

		[DataMember]
		public bool IsPrinted
		{
			get
			{
				return this.IsPrintedField;
			}
			set
			{
				if (!this.IsPrintedField.Equals(value))
				{
					this.IsPrintedField = value;
					this.RaisePropertyChanged("IsPrinted");
				}
			}
		}

		[DataMember]
		public bool IsRead
		{
			get
			{
				return this.IsReadField;
			}
			set
			{
				if (!this.IsReadField.Equals(value))
				{
					this.IsReadField = value;
					this.RaisePropertyChanged("IsRead");
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

		[DataMember]
		public bool IsTransferred
		{
			get
			{
				return this.IsTransferredField;
			}
			set
			{
				if (!this.IsTransferredField.Equals(value))
				{
					this.IsTransferredField = value;
					this.RaisePropertyChanged("IsTransferred");
				}
			}
		}

		[DataMember]
		public string LocalReferenceId
		{
			get
			{
				return this.LocalReferenceIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LocalReferenceIdField, value))
				{
					this.LocalReferenceIdField = value;
					this.RaisePropertyChanged("LocalReferenceId");
				}
			}
		}

		[DataMember]
		public string Messsage
		{
			get
			{
				return this.MesssageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MesssageField, value))
				{
					this.MesssageField = value;
					this.RaisePropertyChanged("Messsage");
				}
			}
		}

		[DataMember]
		public decimal PayableAmount
		{
			get
			{
				return this.PayableAmountField;
			}
			set
			{
				if (!this.PayableAmountField.Equals(value))
				{
					this.PayableAmountField = value;
					this.RaisePropertyChanged("PayableAmount");
				}
			}
		}

		[DataMember]
		public string ProfileId
		{
			get
			{
				return this.ProfileIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProfileIdField, value))
				{
					this.ProfileIdField = value;
					this.RaisePropertyChanged("ProfileId");
				}
			}
		}

		[DataMember]
		public string SendType
		{
			get
			{
				return this.SendTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SendTypeField, value))
				{
					this.SendTypeField = value;
					this.RaisePropertyChanged("SendType");
				}
			}
		}

		[DataMember]
		public string SourceAlias
		{
			get
			{
				return this.SourceAliasField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SourceAliasField, value))
				{
					this.SourceAliasField = value;
					this.RaisePropertyChanged("SourceAlias");
				}
			}
		}

		[DataMember]
		public int Status
		{
			get
			{
				return this.StatusField;
			}
			set
			{
				if (!this.StatusField.Equals(value))
				{
					this.StatusField = value;
					this.RaisePropertyChanged("Status");
				}
			}
		}

		[DataMember]
		public string StatusExp
		{
			get
			{
				return this.StatusExpField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StatusExpField, value))
				{
					this.StatusExpField = value;
					this.RaisePropertyChanged("StatusExp");
				}
			}
		}

		[DataMember]
		public int SubeKodu
		{
			get
			{
				return this.SubeKoduField;
			}
			set
			{
				if (!this.SubeKoduField.Equals(value))
				{
					this.SubeKoduField = value;
					this.RaisePropertyChanged("SubeKodu");
				}
			}
		}

		[DataMember]
		public string TargetAlias
		{
			get
			{
				return this.TargetAliasField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetAliasField, value))
				{
					this.TargetAliasField = value;
					this.RaisePropertyChanged("TargetAlias");
				}
			}
		}

		[DataMember]
		public string TargetIdentifier
		{
			get
			{
				return this.TargetIdentifierField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetIdentifierField, value))
				{
					this.TargetIdentifierField = value;
					this.RaisePropertyChanged("TargetIdentifier");
				}
			}
		}

		[DataMember]
		public string TargetTitle
		{
			get
			{
				return this.TargetTitleField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TargetTitleField, value))
				{
					this.TargetTitleField = value;
					this.RaisePropertyChanged("TargetTitle");
				}
			}
		}

		[DataMember]
		public decimal TaxTotal
		{
			get
			{
				return this.TaxTotalField;
			}
			set
			{
				if (!this.TaxTotalField.Equals(value))
				{
					this.TaxTotalField = value;
					this.RaisePropertyChanged("TaxTotal");
				}
			}
		}

		[DataMember]
		public string UUID
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
					this.RaisePropertyChanged("UUID");
				}
			}
		}

		public Document()
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