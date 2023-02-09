using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="GibUserListAliasCreation", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GibUserListAliasCreation : ResponseMessage
	{
		[OptionalField]
		private UserXml[] gibUserListField;

		[DataMember]
		public UserXml[] gibUserList
		{
			get
			{
				return this.gibUserListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.gibUserListField, value))
				{
					this.gibUserListField = value;
					base.RaisePropertyChanged("gibUserList");
				}
			}
		}

		public GibUserListAliasCreation()
		{
		}
	}
}