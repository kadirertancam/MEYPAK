using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MailSendOut", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MailSendOut : ResponseMessage
	{
		[OptionalField]
		private MailSend mailSendField;

		[DataMember]
		public MailSend mailSend
		{
			get
			{
				return this.mailSendField;
			}
			set
			{
				if (!object.ReferenceEquals(this.mailSendField, value))
				{
					this.mailSendField = value;
					base.RaisePropertyChanged("mailSend");
				}
			}
		}

		public MailSendOut()
		{
		}
	}
}