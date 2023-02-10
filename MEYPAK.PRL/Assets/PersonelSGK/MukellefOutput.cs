using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MukellefOutput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MukellefOutput : ResponseMessage1
	{
		[OptionalField]
		private MukellefModel mukellefField;

		[DataMember]
		public MukellefModel mukellef
		{
			get
			{
				return this.mukellefField;
			}
			set
			{
				if (!object.ReferenceEquals(this.mukellefField, value))
				{
					this.mukellefField = value;
					base.RaisePropertyChanged("mukellef");
				}
			}
		}

		public MukellefOutput()
		{
		}
	}
}