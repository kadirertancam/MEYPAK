using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InvoiceLine", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InvoiceLine : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private decimal Allowance_AmountField;

		[OptionalField]
		private decimal Allowance_PercentField;

		[OptionalField]
		private string Allowance_ReasonField;

		[OptionalField]
		private int IDField;

		[OptionalField]
		private string Item_BrandField;

		[OptionalField]
		private string Item_ClassificationField;

		[OptionalField]
		private string Item_DescriptionField;

		[OptionalField]
		private string Item_ID_BuyerField;

		[OptionalField]
		private string Item_ID_SellerField;

		[OptionalField]
		private string Item_ModelField;

		[OptionalField]
		private string Item_NameField;

		[OptionalField]
		private string LineCurrencyCodeField;

		[OptionalField]
		private string LineNoteField;

		[OptionalField]
		private string Manufacturers_ItemIdentificationField;

		[OptionalField]
		private decimal Price_AmountField;

		[OptionalField]
		private decimal Price_TotalField;

		[OptionalField]
		private decimal Quantity_AmountField;

		[OptionalField]
		private string Quantity_Unit_UserField;

		[OptionalField]
		private ExportLine exportLineField;

		[OptionalField]
		private ItemIdentification[] itemIdentificationsField;

		[OptionalField]
		private AllowanceCharge[] lineAllowanceChargesField;

		[OptionalField]
		private LineTax[] lineTaxesField;

		[DataMember]
		public decimal Allowance_Amount
		{
			get
			{
				return this.Allowance_AmountField;
			}
			set
			{
				if (!this.Allowance_AmountField.Equals(value))
				{
					this.Allowance_AmountField = value;
					this.RaisePropertyChanged("Allowance_Amount");
				}
			}
		}

		[DataMember]
		public decimal Allowance_Percent
		{
			get
			{
				return this.Allowance_PercentField;
			}
			set
			{
				if (!this.Allowance_PercentField.Equals(value))
				{
					this.Allowance_PercentField = value;
					this.RaisePropertyChanged("Allowance_Percent");
				}
			}
		}

		[DataMember]
		public string Allowance_Reason
		{
			get
			{
				return this.Allowance_ReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Allowance_ReasonField, value))
				{
					this.Allowance_ReasonField = value;
					this.RaisePropertyChanged("Allowance_Reason");
				}
			}
		}

		[DataMember]
		public ExportLine exportLine
		{
			get
			{
				return this.exportLineField;
			}
			set
			{
				if (!object.ReferenceEquals(this.exportLineField, value))
				{
					this.exportLineField = value;
					this.RaisePropertyChanged("exportLine");
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
		public int ID
		{
			get
			{
				return this.IDField;
			}
			set
			{
				if (!this.IDField.Equals(value))
				{
					this.IDField = value;
					this.RaisePropertyChanged("ID");
				}
			}
		}

		[DataMember]
		public string Item_Brand
		{
			get
			{
				return this.Item_BrandField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_BrandField, value))
				{
					this.Item_BrandField = value;
					this.RaisePropertyChanged("Item_Brand");
				}
			}
		}

		[DataMember]
		public string Item_Classification
		{
			get
			{
				return this.Item_ClassificationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_ClassificationField, value))
				{
					this.Item_ClassificationField = value;
					this.RaisePropertyChanged("Item_Classification");
				}
			}
		}

		[DataMember]
		public string Item_Description
		{
			get
			{
				return this.Item_DescriptionField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_DescriptionField, value))
				{
					this.Item_DescriptionField = value;
					this.RaisePropertyChanged("Item_Description");
				}
			}
		}

		[DataMember]
		public string Item_ID_Buyer
		{
			get
			{
				return this.Item_ID_BuyerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_ID_BuyerField, value))
				{
					this.Item_ID_BuyerField = value;
					this.RaisePropertyChanged("Item_ID_Buyer");
				}
			}
		}

		[DataMember]
		public string Item_ID_Seller
		{
			get
			{
				return this.Item_ID_SellerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_ID_SellerField, value))
				{
					this.Item_ID_SellerField = value;
					this.RaisePropertyChanged("Item_ID_Seller");
				}
			}
		}

		[DataMember]
		public string Item_Model
		{
			get
			{
				return this.Item_ModelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_ModelField, value))
				{
					this.Item_ModelField = value;
					this.RaisePropertyChanged("Item_Model");
				}
			}
		}

		[DataMember]
		public string Item_Name
		{
			get
			{
				return this.Item_NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Item_NameField, value))
				{
					this.Item_NameField = value;
					this.RaisePropertyChanged("Item_Name");
				}
			}
		}

		[DataMember]
		public ItemIdentification[] itemIdentifications
		{
			get
			{
				return this.itemIdentificationsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.itemIdentificationsField, value))
				{
					this.itemIdentificationsField = value;
					this.RaisePropertyChanged("itemIdentifications");
				}
			}
		}

		[DataMember]
		public AllowanceCharge[] lineAllowanceCharges
		{
			get
			{
				return this.lineAllowanceChargesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.lineAllowanceChargesField, value))
				{
					this.lineAllowanceChargesField = value;
					this.RaisePropertyChanged("lineAllowanceCharges");
				}
			}
		}

		[DataMember]
		public string LineCurrencyCode
		{
			get
			{
				return this.LineCurrencyCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LineCurrencyCodeField, value))
				{
					this.LineCurrencyCodeField = value;
					this.RaisePropertyChanged("LineCurrencyCode");
				}
			}
		}

		[DataMember]
		public string LineNote
		{
			get
			{
				return this.LineNoteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.LineNoteField, value))
				{
					this.LineNoteField = value;
					this.RaisePropertyChanged("LineNote");
				}
			}
		}

		[DataMember]
		public LineTax[] lineTaxes
		{
			get
			{
				return this.lineTaxesField;
			}
			set
			{
				if (!object.ReferenceEquals(this.lineTaxesField, value))
				{
					this.lineTaxesField = value;
					this.RaisePropertyChanged("lineTaxes");
				}
			}
		}

		[DataMember]
		public string Manufacturers_ItemIdentification
		{
			get
			{
				return this.Manufacturers_ItemIdentificationField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Manufacturers_ItemIdentificationField, value))
				{
					this.Manufacturers_ItemIdentificationField = value;
					this.RaisePropertyChanged("Manufacturers_ItemIdentification");
				}
			}
		}

		[DataMember]
		public decimal Price_Amount
		{
			get
			{
				return this.Price_AmountField;
			}
			set
			{
				if (!this.Price_AmountField.Equals(value))
				{
					this.Price_AmountField = value;
					this.RaisePropertyChanged("Price_Amount");
				}
			}
		}

		[DataMember]
		public decimal Price_Total
		{
			get
			{
				return this.Price_TotalField;
			}
			set
			{
				if (!this.Price_TotalField.Equals(value))
				{
					this.Price_TotalField = value;
					this.RaisePropertyChanged("Price_Total");
				}
			}
		}

		[DataMember]
		public decimal Quantity_Amount
		{
			get
			{
				return this.Quantity_AmountField;
			}
			set
			{
				if (!this.Quantity_AmountField.Equals(value))
				{
					this.Quantity_AmountField = value;
					this.RaisePropertyChanged("Quantity_Amount");
				}
			}
		}

		[DataMember]
		public string Quantity_Unit_User
		{
			get
			{
				return this.Quantity_Unit_UserField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Quantity_Unit_UserField, value))
				{
					this.Quantity_Unit_UserField = value;
					this.RaisePropertyChanged("Quantity_Unit_User");
				}
			}
		}

		public InvoiceLine()
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