using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="TransferTip", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum TransferTip
	{
		[EnumMember]
		ZarfZip = 1,
		[EnumMember]
		BelgeZip = 2
	}
}