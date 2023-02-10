using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="GibUserAliasCreation", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GibUserAliasCreation : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AliasField;

		[OptionalField]
		private DateTime AliasCreationTimeField;

		[OptionalField]
		private DateTime? DeletionTimeField;

		[OptionalField]
		private DateTime FirstCreationTimeField;

		[OptionalField]
		private string IdentifierField;

		[OptionalField]
		private string TitleField;

		[OptionalField]
		private string TypeField;

		[DataMember]
		public string Alias
		{
			get
			{
				return this.AliasField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliasField, value))
				{
					this.AliasField = value;
					this.RaisePropertyChanged("Alias");
				}
			}
		}

		[DataMember]
		public DateTime AliasCreationTime
		{
			get
			{
				return this.AliasCreationTimeField;
			}
			set
			{
				if (!this.AliasCreationTimeField.Equals(value))
				{
					this.AliasCreationTimeField = value;
					this.RaisePropertyChanged("AliasCreationTime");
				}
			}
		}

		[DataMember]
		public DateTime? DeletionTime
		{
			get
			{
				return this.DeletionTimeField;
			}
			set
			{
				if (!this.DeletionTimeField.Equals(value))
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
		public DateTime FirstCreationTime
		{
			get
			{
				return this.FirstCreationTimeField;
			}
			set
			{
				if (!this.FirstCreationTimeField.Equals(value))
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

		public GibUserAliasCreation()
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