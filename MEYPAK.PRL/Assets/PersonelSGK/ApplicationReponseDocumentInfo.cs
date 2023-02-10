using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="ApplicationReponseDocumentInfo", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ApplicationReponseDocumentInfo : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private DateTime DocumentDateField;

		[OptionalField]
		private string DocumentIdField;

		[OptionalField]
		private string DocumentUUIDField;

		[DataMember]
		public DateTime DocumentDate
		{
			get
			{
				return this.DocumentDateField;
			}
			set
			{
				if (!this.DocumentDateField.Equals(value))
				{
					this.DocumentDateField = value;
					this.RaisePropertyChanged("DocumentDate");
				}
			}
		}

		[DataMember]
		public string DocumentId
		{
			get
			{
				return this.DocumentIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentIdField, value))
				{
					this.DocumentIdField = value;
					this.RaisePropertyChanged("DocumentId");
				}
			}
		}

		[DataMember]
		public string DocumentUUID
		{
			get
			{
				return this.DocumentUUIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentUUIDField, value))
				{
					this.DocumentUUIDField = value;
					this.RaisePropertyChanged("DocumentUUID");
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

		public ApplicationReponseDocumentInfo()
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