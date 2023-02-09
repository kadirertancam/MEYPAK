using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="GibUserListUserXml", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GibUserListUserXml : ResponseMessage
	{
		[OptionalField]
		private UserXml gibUserField;

		[DataMember]
		public UserXml gibUser
		{
			get
			{
				return this.gibUserField;
			}
			set
			{
				if (!object.ReferenceEquals(this.gibUserField, value))
				{
					this.gibUserField = value;
					base.RaisePropertyChanged("gibUser");
				}
			}
		}

		public GibUserListUserXml()
		{
		}
	}
}