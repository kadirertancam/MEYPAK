using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="NACEFaaliyetKoduveTanimi", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.Turmob")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class NACEFaaliyetKoduveTanimi : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string faaliyetAdiField;

		[OptionalField]
		private string faaliyetKoduField;

		[OptionalField]
		private string siraField;

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
		public string faaliyetAdi
		{
			get
			{
				return this.faaliyetAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.faaliyetAdiField, value))
				{
					this.faaliyetAdiField = value;
					this.RaisePropertyChanged("faaliyetAdi");
				}
			}
		}

		[DataMember]
		public string faaliyetKodu
		{
			get
			{
				return this.faaliyetKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.faaliyetKoduField, value))
				{
					this.faaliyetKoduField = value;
					this.RaisePropertyChanged("faaliyetKodu");
				}
			}
		}

		[DataMember]
		public string sira
		{
			get
			{
				return this.siraField;
			}
			set
			{
				if (!object.ReferenceEquals(this.siraField, value))
				{
					this.siraField = value;
					this.RaisePropertyChanged("sira");
				}
			}
		}

		public NACEFaaliyetKoduveTanimi()
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