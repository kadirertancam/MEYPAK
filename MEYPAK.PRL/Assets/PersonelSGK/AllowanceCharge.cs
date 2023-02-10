using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="AllowanceCharge", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AllowanceCharge : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AllowanceChargeReasonField;

		[OptionalField]
		private decimal AmountField;

		[OptionalField]
		private decimal BaseAmountField;

		[OptionalField]
		private bool ChargeIndicatorField;

		[OptionalField]
		private decimal MultiplierFactorNumericField;

		[DataMember]
		public string AllowanceChargeReason
		{
			get
			{
				return this.AllowanceChargeReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AllowanceChargeReasonField, value))
				{
					this.AllowanceChargeReasonField = value;
					this.RaisePropertyChanged("AllowanceChargeReason");
				}
			}
		}

		[DataMember]
		public decimal Amount
		{
			get
			{
				return this.AmountField;
			}
			set
			{
				if (!this.AmountField.Equals(value))
				{
					this.AmountField = value;
					this.RaisePropertyChanged("Amount");
				}
			}
		}

		[DataMember]
		public decimal BaseAmount
		{
			get
			{
				return this.BaseAmountField;
			}
			set
			{
				if (!this.BaseAmountField.Equals(value))
				{
					this.BaseAmountField = value;
					this.RaisePropertyChanged("BaseAmount");
				}
			}
		}

		[DataMember]
		public bool ChargeIndicator
		{
			get
			{
				return this.ChargeIndicatorField;
			}
			set
			{
				if (!this.ChargeIndicatorField.Equals(value))
				{
					this.ChargeIndicatorField = value;
					this.RaisePropertyChanged("ChargeIndicator");
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
		public decimal MultiplierFactorNumeric
		{
			get
			{
				return this.MultiplierFactorNumericField;
			}
			set
			{
				if (!this.MultiplierFactorNumericField.Equals(value))
				{
					this.MultiplierFactorNumericField = value;
					this.RaisePropertyChanged("MultiplierFactorNumeric");
				}
			}
		}

		public AllowanceCharge()
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