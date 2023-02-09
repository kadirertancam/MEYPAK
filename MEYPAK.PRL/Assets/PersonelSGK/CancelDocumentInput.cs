using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="CancelDocumentInput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.EArsiv")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CancelDocumentInput : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private string CancelDateField;

		[OptionalField]
		private string CancelReasonField;

		[OptionalField]
		private string DocumentUuidField;

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
		public string CancelDate
		{
			get
			{
				return this.CancelDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CancelDateField, value))
				{
					this.CancelDateField = value;
					this.RaisePropertyChanged("CancelDate");
				}
			}
		}

		[DataMember]
		public string CancelReason
		{
			get
			{
				return this.CancelReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CancelReasonField, value))
				{
					this.CancelReasonField = value;
					this.RaisePropertyChanged("CancelReason");
				}
			}
		}

		[DataMember]
		public string DocumentUuid
		{
			get
			{
				return this.DocumentUuidField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DocumentUuidField, value))
				{
					this.DocumentUuidField = value;
					this.RaisePropertyChanged("DocumentUuid");
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

		public CancelDocumentInput()
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