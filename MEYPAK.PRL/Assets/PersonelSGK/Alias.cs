using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Alias", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Alias : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string CreationTimeField;

		[OptionalField]
		private string DeletionTimeField;

		[OptionalField]
		private string[] NameField;

		[DataMember]
		public string CreationTime
		{
			get
			{
				return this.CreationTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CreationTimeField, value))
				{
					this.CreationTimeField = value;
					this.RaisePropertyChanged("CreationTime");
				}
			}
		}

		[DataMember]
		public string DeletionTime
		{
			get
			{
				return this.DeletionTimeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeletionTimeField, value))
				{
					this.DeletionTimeField = value;
					this.RaisePropertyChanged("DeletionTime");
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
		public string[] Name
		{
			get
			{
				return this.NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NameField, value))
				{
					this.NameField = value;
					this.RaisePropertyChanged("Name");
				}
			}
		}

		public Alias()
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