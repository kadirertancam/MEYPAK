using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InvoiceHeader", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InvoiceHeader : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private decimal AllowanceTotalAmountField;

		[OptionalField]
		private decimal CalculationRateField;

		[OptionalField]
		private string DestinationUrnField;

		[OptionalField]
		private string DocumentCurrencyCodeField;

		[OptionalField]
		private string EArchiveSendTypeField;

		[OptionalField]
		private string InvoiceTypeCodeField;

		[OptionalField]
		private string Invoice_IDField;

		[OptionalField]
		private bool IsInternetSaleField;

		[OptionalField]
		private string IsInternet_ActualDespatchDateField;

		[OptionalField]
		private string IsInternet_Delivery_FamilyNameField;

		[OptionalField]
		private string IsInternet_Delivery_FirstNameField;

		[OptionalField]
		private string IsInternet_Delivery_PartyNameField;

		[OptionalField]
		private string IsInternet_Delivery_TcknVknField;

		[OptionalField]
		private string IsInternet_InstructionNoteField;

		[OptionalField]
		private string IsInternet_PaymentDueDateField;

		[OptionalField]
		private string IsInternet_PaymentMeansCodeField;

		[OptionalField]
		private string IsInternet_WebsiteURIField;

		[OptionalField]
		private string IssueDateField;

		[OptionalField]
		private string IssueTimeField;

		[OptionalField]
		private decimal LineExtensionAmountField;

		[OptionalField]
		private string NoteField;

		[OptionalField]
		private NoteModel[] NotesField;

		[OptionalField]
		private string OrderReferenceDateField;

		[OptionalField]
		private string OrderReferenceIdField;

		[OptionalField]
		private decimal PayableAmountField;

		[OptionalField]
		private string PrefixField;

		[OptionalField]
		private string ProfileIDField;

		[OptionalField]
		private string Sgk_AccountingCostField;

		[OptionalField]
		private string Sgk_DosyaNoField;

		[OptionalField]
		private string Sgk_Mukellef_AdiField;

		[OptionalField]
		private string Sgk_Mukellef_KoduField;

		[OptionalField]
		private string Sgk_Period_EndDateField;

		[OptionalField]
		private string Sgk_Period_StartDateField;

		[OptionalField]
		private string SourceUrnField;

		[OptionalField]
		private int SubeKoduField;

		[OptionalField]
		private decimal TaxInclusiveAmountField;

		[OptionalField]
		private string string_0;

		[OptionalField]
		private bool UpdateDocumentField;

		[OptionalField]
		private string XSLT_AdiField;

		[OptionalField]
		private byte[] XSLT_DocField;

		[DataMember]
		public decimal AllowanceTotalAmount
		{
			get
			{
				return this.AllowanceTotalAmountField;
			}
			set
			{
				if (!this.AllowanceTotalAmountField.Equals(value))
				{
					this.AllowanceTotalAmountField = value;
					this.RaisePropertyChanged("AllowanceTotalAmount");
				}
			}
		}

		[DataMember]
		public decimal CalculationRate
		{
			get
			{
				return this.CalculationRateField;
			}
			set
			{
				if (!this.CalculationRateField.Equals(value))
				{
					this.CalculationRateField = value;
					this.RaisePropertyChanged("CalculationRate");
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
		public string EArchiveSendType
		{
			get
			{
				return this.EArchiveSendTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EArchiveSendTypeField, value))
				{
					this.EArchiveSendTypeField = value;
					this.RaisePropertyChanged("EArchiveSendType");
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
		public string Invoice_ID
		{
			get
			{
				return this.Invoice_IDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Invoice_IDField, value))
				{
					this.Invoice_IDField = value;
					this.RaisePropertyChanged("Invoice_ID");
				}
			}
		}

		[DataMember]
		public string InvoiceTypeCode
		{
			get
			{
				return this.InvoiceTypeCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InvoiceTypeCodeField, value))
				{
					this.InvoiceTypeCodeField = value;
					this.RaisePropertyChanged("InvoiceTypeCode");
				}
			}
		}

		[DataMember]
		public string IsInternet_ActualDespatchDate
		{
			get
			{
				return this.IsInternet_ActualDespatchDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_ActualDespatchDateField, value))
				{
					this.IsInternet_ActualDespatchDateField = value;
					this.RaisePropertyChanged("IsInternet_ActualDespatchDate");
				}
			}
		}

		[DataMember]
		public string IsInternet_Delivery_FamilyName
		{
			get
			{
				return this.IsInternet_Delivery_FamilyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_Delivery_FamilyNameField, value))
				{
					this.IsInternet_Delivery_FamilyNameField = value;
					this.RaisePropertyChanged("IsInternet_Delivery_FamilyName");
				}
			}
		}

		[DataMember]
		public string IsInternet_Delivery_FirstName
		{
			get
			{
				return this.IsInternet_Delivery_FirstNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_Delivery_FirstNameField, value))
				{
					this.IsInternet_Delivery_FirstNameField = value;
					this.RaisePropertyChanged("IsInternet_Delivery_FirstName");
				}
			}
		}

		[DataMember]
		public string IsInternet_Delivery_PartyName
		{
			get
			{
				return this.IsInternet_Delivery_PartyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_Delivery_PartyNameField, value))
				{
					this.IsInternet_Delivery_PartyNameField = value;
					this.RaisePropertyChanged("IsInternet_Delivery_PartyName");
				}
			}
		}

		[DataMember]
		public string IsInternet_Delivery_TcknVkn
		{
			get
			{
				return this.IsInternet_Delivery_TcknVknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_Delivery_TcknVknField, value))
				{
					this.IsInternet_Delivery_TcknVknField = value;
					this.RaisePropertyChanged("IsInternet_Delivery_TcknVkn");
				}
			}
		}

		[DataMember]
		public string IsInternet_InstructionNote
		{
			get
			{
				return this.IsInternet_InstructionNoteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_InstructionNoteField, value))
				{
					this.IsInternet_InstructionNoteField = value;
					this.RaisePropertyChanged("IsInternet_InstructionNote");
				}
			}
		}

		[DataMember]
		public string IsInternet_PaymentDueDate
		{
			get
			{
				return this.IsInternet_PaymentDueDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_PaymentDueDateField, value))
				{
					this.IsInternet_PaymentDueDateField = value;
					this.RaisePropertyChanged("IsInternet_PaymentDueDate");
				}
			}
		}

		[DataMember]
		public string IsInternet_PaymentMeansCode
		{
			get
			{
				return this.IsInternet_PaymentMeansCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_PaymentMeansCodeField, value))
				{
					this.IsInternet_PaymentMeansCodeField = value;
					this.RaisePropertyChanged("IsInternet_PaymentMeansCode");
				}
			}
		}

		[DataMember]
		public string IsInternet_WebsiteURI
		{
			get
			{
				return this.IsInternet_WebsiteURIField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IsInternet_WebsiteURIField, value))
				{
					this.IsInternet_WebsiteURIField = value;
					this.RaisePropertyChanged("IsInternet_WebsiteURI");
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
		public string IssueTime
		{
			get
			{
				return this.IssueTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IssueTimeField, value))
				{
					this.IssueTimeField = value;
					this.RaisePropertyChanged("IssueTime");
				}
			}
		}

		[DataMember]
		public decimal LineExtensionAmount
		{
			get
			{
				return this.LineExtensionAmountField;
			}
			set
			{
				if (!this.LineExtensionAmountField.Equals(value))
				{
					this.LineExtensionAmountField = value;
					this.RaisePropertyChanged("LineExtensionAmount");
				}
			}
		}

		[DataMember]
		public string Note
		{
			get
			{
				return this.NoteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NoteField, value))
				{
					this.NoteField = value;
					this.RaisePropertyChanged("Note");
				}
			}
		}

		[DataMember]
		public NoteModel[] Notes
		{
			get
			{
				return this.NotesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NotesField, value))
				{
					this.NotesField = value;
					this.RaisePropertyChanged("Notes");
				}
			}
		}

		[DataMember]
		public string OrderReferenceDate
		{
			get
			{
				return this.OrderReferenceDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrderReferenceDateField, value))
				{
					this.OrderReferenceDateField = value;
					this.RaisePropertyChanged("OrderReferenceDate");
				}
			}
		}

		[DataMember]
		public string OrderReferenceId
		{
			get
			{
				return this.OrderReferenceIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrderReferenceIdField, value))
				{
					this.OrderReferenceIdField = value;
					this.RaisePropertyChanged("OrderReferenceId");
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
		public string Prefix
		{
			get
			{
				return this.PrefixField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PrefixField, value))
				{
					this.PrefixField = value;
					this.RaisePropertyChanged("Prefix");
				}
			}
		}

		[DataMember]
		public string ProfileID
		{
			get
			{
				return this.ProfileIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ProfileIDField, value))
				{
					this.ProfileIDField = value;
					this.RaisePropertyChanged("ProfileID");
				}
			}
		}

		[DataMember]
		public string Sgk_AccountingCost
		{
			get
			{
				return this.Sgk_AccountingCostField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_AccountingCostField, value))
				{
					this.Sgk_AccountingCostField = value;
					this.RaisePropertyChanged("Sgk_AccountingCost");
				}
			}
		}

		[DataMember]
		public string Sgk_DosyaNo
		{
			get
			{
				return this.Sgk_DosyaNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_DosyaNoField, value))
				{
					this.Sgk_DosyaNoField = value;
					this.RaisePropertyChanged("Sgk_DosyaNo");
				}
			}
		}

		[DataMember]
		public string Sgk_Mukellef_Adi
		{
			get
			{
				return this.Sgk_Mukellef_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_Mukellef_AdiField, value))
				{
					this.Sgk_Mukellef_AdiField = value;
					this.RaisePropertyChanged("Sgk_Mukellef_Adi");
				}
			}
		}

		[DataMember]
		public string Sgk_Mukellef_Kodu
		{
			get
			{
				return this.Sgk_Mukellef_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_Mukellef_KoduField, value))
				{
					this.Sgk_Mukellef_KoduField = value;
					this.RaisePropertyChanged("Sgk_Mukellef_Kodu");
				}
			}
		}

		[DataMember]
		public string Sgk_Period_EndDate
		{
			get
			{
				return this.Sgk_Period_EndDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_Period_EndDateField, value))
				{
					this.Sgk_Period_EndDateField = value;
					this.RaisePropertyChanged("Sgk_Period_EndDate");
				}
			}
		}

		[DataMember]
		public string Sgk_Period_StartDate
		{
			get
			{
				return this.Sgk_Period_StartDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Sgk_Period_StartDateField, value))
				{
					this.Sgk_Period_StartDateField = value;
					this.RaisePropertyChanged("Sgk_Period_StartDate");
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
		public decimal TaxInclusiveAmount
		{
			get
			{
				return this.TaxInclusiveAmountField;
			}
			set
			{
				if (!this.TaxInclusiveAmountField.Equals(value))
				{
					this.TaxInclusiveAmountField = value;
					this.RaisePropertyChanged("TaxInclusiveAmount");
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

		[DataMember]
		public string XSLT_Adi
		{
			get
			{
				return this.XSLT_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.XSLT_AdiField, value))
				{
					this.XSLT_AdiField = value;
					this.RaisePropertyChanged("XSLT_Adi");
				}
			}
		}

		[DataMember]
		public byte[] XSLT_Doc
		{
			get
			{
				return this.XSLT_DocField;
			}
			set
			{
				if (!object.ReferenceEquals(this.XSLT_DocField, value))
				{
					this.XSLT_DocField = value;
					this.RaisePropertyChanged("XSLT_Doc");
				}
			}
		}

		public InvoiceHeader()
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