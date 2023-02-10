using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InvoiceModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InvoiceModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private AdditionalDocumentReference[] additionalDocumentReferencesField;

		[OptionalField]
		private BillingReference[] billingReferencesField;

		[OptionalField]
		private BuyerCustomerParty buyerCustomerField;

		[OptionalField]
		private Customer customerField;

		[OptionalField]
		private CustomerAgentParty customerAgentField;

		[OptionalField]
		private Despatchs[] despatchsField;

		[OptionalField]
		private InvoiceLine[] invoiceLinesField;

		[OptionalField]
		private InvoiceHeader invoiceheaderField;

		[OptionalField]
		private PaymentMeans[] paymentMeansField;

		[OptionalField]
		private Supplier supplierField;

		[OptionalField]
		private SupplierAgentParty supplierAgentField;

		[DataMember]
		public AdditionalDocumentReference[] additionalDocumentReferences
		{
			get
			{
				return this.additionalDocumentReferencesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.additionalDocumentReferencesField, value))
				{
					this.additionalDocumentReferencesField = value;
					this.RaisePropertyChanged("additionalDocumentReferences");
				}
			}
		}

		[DataMember]
		public BillingReference[] billingReferences
		{
			get
			{
				return this.billingReferencesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.billingReferencesField, value))
				{
					this.billingReferencesField = value;
					this.RaisePropertyChanged("billingReferences");
				}
			}
		}

		[DataMember]
		public BuyerCustomerParty buyerCustomer
		{
			get
			{
				return this.buyerCustomerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.buyerCustomerField, value))
				{
					this.buyerCustomerField = value;
					this.RaisePropertyChanged("buyerCustomer");
				}
			}
		}

		[DataMember]
		public Customer customer
		{
			get
			{
				return this.customerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.customerField, value))
				{
					this.customerField = value;
					this.RaisePropertyChanged("customer");
				}
			}
		}

		[DataMember]
		public CustomerAgentParty customerAgent
		{
			get
			{
				return this.customerAgentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.customerAgentField, value))
				{
					this.customerAgentField = value;
					this.RaisePropertyChanged("customerAgent");
				}
			}
		}

		[DataMember]
		public Despatchs[] despatchs
		{
			get
			{
				return this.despatchsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.despatchsField, value))
				{
					this.despatchsField = value;
					this.RaisePropertyChanged("despatchs");
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
		public InvoiceHeader invoiceheader
		{
			get
			{
				return this.invoiceheaderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.invoiceheaderField, value))
				{
					this.invoiceheaderField = value;
					this.RaisePropertyChanged("invoiceheader");
				}
			}
		}

		[DataMember]
		public InvoiceLine[] invoiceLines
		{
			get
			{
				return this.invoiceLinesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.invoiceLinesField, value))
				{
					this.invoiceLinesField = value;
					this.RaisePropertyChanged("invoiceLines");
				}
			}
		}

		[DataMember]
		public PaymentMeans[] paymentMeans
		{
			get
			{
				return this.paymentMeansField;
			}
			set
			{
				if (!object.ReferenceEquals(this.paymentMeansField, value))
				{
					this.paymentMeansField = value;
					this.RaisePropertyChanged("paymentMeans");
				}
			}
		}

		[DataMember]
		public Supplier supplier
		{
			get
			{
				return this.supplierField;
			}
			set
			{
				if (!object.ReferenceEquals(this.supplierField, value))
				{
					this.supplierField = value;
					this.RaisePropertyChanged("supplier");
				}
			}
		}

		[DataMember]
		public SupplierAgentParty supplierAgent
		{
			get
			{
				return this.supplierAgentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.supplierAgentField, value))
				{
					this.supplierAgentField = value;
					this.RaisePropertyChanged("supplierAgent");
				}
			}
		}

		public InvoiceModel()
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