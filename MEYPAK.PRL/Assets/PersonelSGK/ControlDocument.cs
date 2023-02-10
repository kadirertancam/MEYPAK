using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="ControlDocument", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ControlDocument : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private string DocumentXmlField;

		[DataMember]
		public int AppType
		{
			get
			{
				return this.AppTypeField;
			}
			set
			{
				if (!this.AppTypeField.Equals(value))
				{
					this.AppTypeField = value;
					this.RaisePropertyChanged("AppType");
				}
			}
		}

		[DataMember]
		public string DocumentXml
		{
			get
			{
				return this.DocumentXmlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentXmlField, value))
				{
					this.DocumentXmlField = value;
					this.RaisePropertyChanged("DocumentXml");
				}
			}
		}

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

		public ControlDocument()
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