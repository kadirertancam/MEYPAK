using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="DocumentList", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DocumentList : ResponseMessage
	{
		[OptionalField]
		private Document[] documentsField;

		[DataMember]
		public Document[] documents
		{
			get
			{
				return this.documentsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.documentsField, value))
				{
					this.documentsField = value;
					base.RaisePropertyChanged("documents");
				}
			}
		}

		public DocumentList()
		{
		}
	}
}