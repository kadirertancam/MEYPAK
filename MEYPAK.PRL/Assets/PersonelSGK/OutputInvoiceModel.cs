using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="OutputInvoiceModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class OutputInvoiceModel : ResponseMessage
	{
		[OptionalField]
		private string HtmlContentField;

		[DataMember]
		public string HtmlContent
		{
			get
			{
				return this.HtmlContentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HtmlContentField, value))
				{
					this.HtmlContentField = value;
					base.RaisePropertyChanged("HtmlContent");
				}
			}
		}

		public OutputInvoiceModel()
		{
		}
	}
}