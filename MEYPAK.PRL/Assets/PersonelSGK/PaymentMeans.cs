using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="PaymentMeans", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class PaymentMeans : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string InstructionNoteField;

		[OptionalField]
		private string PayeeFinancialAccountField;

		[OptionalField]
		private string PayeeFinancialCurrencyCodeField;

		[OptionalField]
		private string PaymentChannelCodeField;

		[OptionalField]
		private DateTime PaymentDueDateField;

		[OptionalField]
		private string PaymentMeansCodeField;

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
		public string InstructionNote
		{
			get
			{
				return this.InstructionNoteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InstructionNoteField, value))
				{
					this.InstructionNoteField = value;
					this.RaisePropertyChanged("InstructionNote");
				}
			}
		}

		[DataMember]
		public string PayeeFinancialAccount
		{
			get
			{
				return this.PayeeFinancialAccountField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PayeeFinancialAccountField, value))
				{
					this.PayeeFinancialAccountField = value;
					this.RaisePropertyChanged("PayeeFinancialAccount");
				}
			}
		}

		[DataMember]
		public string PayeeFinancialCurrencyCode
		{
			get
			{
				return this.PayeeFinancialCurrencyCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PayeeFinancialCurrencyCodeField, value))
				{
					this.PayeeFinancialCurrencyCodeField = value;
					this.RaisePropertyChanged("PayeeFinancialCurrencyCode");
				}
			}
		}

		[DataMember]
		public string PaymentChannelCode
		{
			get
			{
				return this.PaymentChannelCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PaymentChannelCodeField, value))
				{
					this.PaymentChannelCodeField = value;
					this.RaisePropertyChanged("PaymentChannelCode");
				}
			}
		}

		[DataMember]
		public DateTime PaymentDueDate
		{
			get
			{
				return this.PaymentDueDateField;
			}
			set
			{
				if (!this.PaymentDueDateField.Equals(value))
				{
					this.PaymentDueDateField = value;
					this.RaisePropertyChanged("PaymentDueDate");
				}
			}
		}

		[DataMember]
		public string PaymentMeansCode
		{
			get
			{
				return this.PaymentMeansCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PaymentMeansCodeField, value))
				{
					this.PaymentMeansCodeField = value;
					this.RaisePropertyChanged("PaymentMeansCode");
				}
			}
		}

		public PaymentMeans()
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