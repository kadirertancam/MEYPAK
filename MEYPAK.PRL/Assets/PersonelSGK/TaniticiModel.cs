using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="TaniticiModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class TaniticiModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int IdField;

		[OptionalField]
		private string TaniticiDegerField;

		[OptionalField]
		private int TaniticiIdField;

		[OptionalField]
		private string TaniticiKodField;

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
		public int Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember]
		public string TaniticiDeger
		{
			get
			{
				return this.TaniticiDegerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TaniticiDegerField, value))
				{
					this.TaniticiDegerField = value;
					this.RaisePropertyChanged("TaniticiDeger");
				}
			}
		}

		[DataMember]
		public int TaniticiId
		{
			get
			{
				return this.TaniticiIdField;
			}
			set
			{
				if (!this.TaniticiIdField.Equals(value))
				{
					this.TaniticiIdField = value;
					this.RaisePropertyChanged("TaniticiId");
				}
			}
		}

		[DataMember]
		public string TaniticiKod
		{
			get
			{
				return this.TaniticiKodField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TaniticiKodField, value))
				{
					this.TaniticiKodField = value;
					this.RaisePropertyChanged("TaniticiKod");
				}
			}
		}

		public TaniticiModel()
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