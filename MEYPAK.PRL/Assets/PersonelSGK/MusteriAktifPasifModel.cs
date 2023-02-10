using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="MusteriAktifPasifModel", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MusteriAktifPasifModel : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool AktifPasifField;

		[OptionalField]
		private string MesajField;

		[OptionalField]
		private string VknTcknField;

		[DataMember]
		public bool AktifPasif
		{
			get
			{
				return this.AktifPasifField;
			}
			set
			{
				if (!this.AktifPasifField.Equals(value))
				{
					this.AktifPasifField = value;
					this.RaisePropertyChanged("AktifPasif");
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
		public string Mesaj
		{
			get
			{
				return this.MesajField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MesajField, value))
				{
					this.MesajField = value;
					this.RaisePropertyChanged("Mesaj");
				}
			}
		}

		[DataMember]
		public string VknTckn
		{
			get
			{
				return this.VknTcknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VknTcknField, value))
				{
					this.VknTcknField = value;
					this.RaisePropertyChanged("VknTckn");
				}
			}
		}

		public MusteriAktifPasifModel()
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