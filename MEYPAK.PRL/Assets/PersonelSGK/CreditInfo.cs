using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="CreditInfo", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CreditInfo : ResponseMessage
	{
		[OptionalField]
		private decimal remainCreditField;

		[OptionalField]
		private decimal totalCreditField;

		[DataMember]
		public decimal remainCredit
		{
			get
			{
				return this.remainCreditField;
			}
			set
			{
				if (!this.remainCreditField.Equals(value))
				{
					this.remainCreditField = value;
					base.RaisePropertyChanged("remainCredit");
				}
			}
		}

		[DataMember]
		public decimal totalCredit
		{
			get
			{
				return this.totalCreditField;
			}
			set
			{
				if (!this.totalCreditField.Equals(value))
				{
					this.totalCreditField = value;
					base.RaisePropertyChanged("totalCredit");
				}
			}
		}

		public CreditInfo()
		{
		}
	}
}