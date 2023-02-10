using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="InvoiceIdAndDateModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class InvoiceIdAndDateModel : ResponseMessage
	{
		[OptionalField]
		private DateTime InvoiceDateField;

		[OptionalField]
		private string InvoiceIdField;

		[DataMember]
		public DateTime InvoiceDate
		{
			get
			{
				return this.InvoiceDateField;
			}
			set
			{
				if (!this.InvoiceDateField.Equals(value))
				{
					this.InvoiceDateField = value;
					base.RaisePropertyChanged("InvoiceDate");
				}
			}
		}

		[DataMember]
		public string InvoiceId
		{
			get
			{
				return this.InvoiceIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.InvoiceIdField, value))
				{
					this.InvoiceIdField = value;
					base.RaisePropertyChanged("InvoiceId");
				}
			}
		}

		public InvoiceIdAndDateModel()
		{
		}
	}
}