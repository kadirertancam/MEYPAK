using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="DocumentUserXml", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DocumentUserXml : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Alias[] AliasListField;

		[OptionalField]
		private string DocumentTypeField;

		[DataMember]
		public Alias[] AliasList
		{
			get
			{
				return this.AliasListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliasListField, value))
				{
					this.AliasListField = value;
					this.RaisePropertyChanged("AliasList");
				}
			}
		}

		[DataMember]
		public string DocumentType
		{
			get
			{
				return this.DocumentTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentTypeField, value))
				{
					this.DocumentTypeField = value;
					this.RaisePropertyChanged("DocumentType");
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

		public DocumentUserXml()
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