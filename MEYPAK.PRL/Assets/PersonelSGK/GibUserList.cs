using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="GibUserList", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GibUserList : ResponseMessage
	{
		[OptionalField]
		private GibUser[] gibUserListsField;

		[DataMember]
		public GibUser[] gibUserLists
		{
			get
			{
				return this.gibUserListsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.gibUserListsField, value))
				{
					this.gibUserListsField = value;
					base.RaisePropertyChanged("gibUserLists");
				}
			}
		}

		public GibUserList()
		{
		}
	}
}