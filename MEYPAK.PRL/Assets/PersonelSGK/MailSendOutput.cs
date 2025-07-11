using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MailSendOutput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MailSendOutput : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private MailSendOut[] MailSendOutListField;

		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember]
		public MailSendOut[] MailSendOutList
		{
			get
			{
				return this.MailSendOutListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MailSendOutListField, value))
				{
					this.MailSendOutListField = value;
					this.RaisePropertyChanged("MailSendOutList");
				}
			}
		}

		public MailSendOutput()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}