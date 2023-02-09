using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="hizmetTuru", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum hizmetTuru
	{
		[EnumMember]
		E_ARSIV,
		[EnumMember]
		E_FATURA,
		[EnumMember]
		E_DEFTER,
		[EnumMember]
		SAKLAMA,
		[EnumMember]
		E_DEFTER_YUKLEME,
		[EnumMember]
		E_IRSALIYE,
		[EnumMember]
		SMM,
		[EnumMember]
		MM,
		[EnumMember]
		MALI_RAPOR_ESKI_OKC,
		[EnumMember]
		MALI_RAPOR_YENI_OKC,
		[EnumMember]
		DEFTER_KONTROL,
		[EnumMember]
		ON_MUHASEBE,
		[EnumMember]
		E_ARSIV_KASA,
		[EnumMember]
		E_GIDER_PUSULASI
	}
}