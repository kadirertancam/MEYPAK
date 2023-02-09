using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="tarifeTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum tarifeTuru
	{
		[EnumMember]
		FATURALI,
		[EnumMember]
		KONTORLU
	}
}