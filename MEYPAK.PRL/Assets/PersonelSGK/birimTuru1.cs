using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="birimTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum birimTuru1
	{
		[EnumMember]
		FaturaAdedi,
		[EnumMember]
		AlanBoyutu,
		[EnumMember]
		ArsivKasa
	}
}