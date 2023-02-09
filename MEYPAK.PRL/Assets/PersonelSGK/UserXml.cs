using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="UserXml", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class UserXml : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AccountTypeField;

		[OptionalField]
		private DocumentUserXml[] DocumentListField;

		[OptionalField]
		private string FirstCreationTimeField;

		[OptionalField]
		private string IdentifierField;

		[OptionalField]
		private string TitleField;

		[OptionalField]
		private string TypeField;

		[DataMember]
		public string AccountType
		{
			get
			{
				return this.AccountTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccountTypeField, value))
				{
					this.AccountTypeField = value;
					this.RaisePropertyChanged("AccountType");
				}
			}
		}

		[DataMember]
		public DocumentUserXml[] DocumentList
		{
			get
			{
				return this.DocumentListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentListField, value))
				{
					this.DocumentListField = value;
					this.RaisePropertyChanged("DocumentList");
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

		[DataMember]
		public string FirstCreationTime
		{
			get
			{
				return this.FirstCreationTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FirstCreationTimeField, value))
				{
					this.FirstCreationTimeField = value;
					this.RaisePropertyChanged("FirstCreationTime");
				}
			}
		}

		[DataMember]
		public string Identifier
		{
			get
			{
				return this.IdentifierField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdentifierField, value))
				{
					this.IdentifierField = value;
					this.RaisePropertyChanged("Identifier");
				}
			}
		}

		[DataMember]
		public string Title
		{
			get
			{
				return this.TitleField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TitleField, value))
				{
					this.TitleField = value;
					this.RaisePropertyChanged("Title");
				}
			}
		}

		[DataMember]
		public string Type
		{
			get
			{
				return this.TypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TypeField, value))
				{
					this.TypeField = value;
					this.RaisePropertyChanged("Type");
				}
			}
		}

		public UserXml()
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