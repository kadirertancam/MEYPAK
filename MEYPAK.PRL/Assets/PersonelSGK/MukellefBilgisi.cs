using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MukellefBilgisi", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MukellefBilgisi : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string meslekMensubuKeyField;

		[OptionalField]
		private string vknTcknField;

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
		public string meslekMensubuKey
		{
			get
			{
				return this.meslekMensubuKeyField;
			}
			set
			{
				if (!object.ReferenceEquals(this.meslekMensubuKeyField, value))
				{
					this.meslekMensubuKeyField = value;
					this.RaisePropertyChanged("meslekMensubuKey");
				}
			}
		}

		[DataMember]
		public string vknTckn
		{
			get
			{
				return this.vknTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.vknTcknField, value))
				{
					this.vknTcknField = value;
					this.RaisePropertyChanged("vknTckn");
				}
			}
		}

		public MukellefBilgisi()
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