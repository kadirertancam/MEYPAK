using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="ObjectDocumentInput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.EArsiv")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ObjectDocumentInput : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private string DocumentUuidField;

		[OptionalField]
		private string ObjectionDateField;

		[OptionalField]
		private string ObjectionDocumentNoField;

		[OptionalField]
		private string ObjectionReasonField;

		[OptionalField]
		private string ObjectionTypeField;

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

		[DataMember]
		public string ObjectionDate
		{
			get
			{
				return this.ObjectionDateField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ObjectionDateField, value))
				{
					this.ObjectionDateField = value;
					this.RaisePropertyChanged("ObjectionDate");
				}
			}
		}

		[DataMember]
		public string ObjectionDocumentNo
		{
			get
			{
				return this.ObjectionDocumentNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ObjectionDocumentNoField, value))
				{
					this.ObjectionDocumentNoField = value;
					this.RaisePropertyChanged("ObjectionDocumentNo");
				}
			}
		}

		[DataMember]
		public string ObjectionReason
		{
			get
			{
				return this.ObjectionReasonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ObjectionReasonField, value))
				{
					this.ObjectionReasonField = value;
					this.RaisePropertyChanged("ObjectionReason");
				}
			}
		}

		[DataMember]
		public string ObjectionType
		{
			get
			{
				return this.ObjectionTypeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ObjectionTypeField, value))
				{
					this.ObjectionTypeField = value;
					this.RaisePropertyChanged("ObjectionType");
				}
			}
		}

		public ObjectDocumentInput()
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