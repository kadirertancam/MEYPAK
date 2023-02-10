using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="DocumentContent", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DocumentContent : ResponseMessage
	{
		[OptionalField]
		private byte[] DocumentFileField;

		[DataMember]
		public byte[] DocumentFile
		{
			get
			{
				return this.DocumentFileField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentFileField, value))
				{
					this.DocumentFileField = value;
					base.RaisePropertyChanged("DocumentFile");
				}
			}
		}

		public DocumentContent()
		{
		}
	}
}