using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Despatchs", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Despatchs : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string DespatchDocumentIDField;

		[OptionalField]
		private string DespatchDocumentIssueDateField;

		[DataMember]
		public string DespatchDocumentID
		{
			get
			{
				return this.DespatchDocumentIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DespatchDocumentIDField, value))
				{
					this.DespatchDocumentIDField = value;
					this.RaisePropertyChanged("DespatchDocumentID");
				}
			}
		}

		[DataMember]
		public string DespatchDocumentIssueDate
		{
			get
			{
				return this.DespatchDocumentIssueDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DespatchDocumentIssueDateField, value))
				{
					this.DespatchDocumentIssueDateField = value;
					this.RaisePropertyChanged("DespatchDocumentIssueDate");
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

		public Despatchs()
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