using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="KrediRaporOutput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class KrediRaporOutput : ResponseMessage
	{
		[OptionalField]
		private KrediRapor[] krediRaporListField;

		[DataMember]
		public KrediRapor[] krediRaporList
		{
			get
			{
				return this.krediRaporListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.krediRaporListField, value))
				{
					this.krediRaporListField = value;
					base.RaisePropertyChanged("krediRaporList");
				}
			}
		}

		public KrediRaporOutput()
		{
		}
	}
}