using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="OdemeTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum OdemeTuru
	{
		[EnumMember]
		Pesin,
		[EnumMember]
		Taksit,
		[EnumMember]
		Ucretsiz
	}
}