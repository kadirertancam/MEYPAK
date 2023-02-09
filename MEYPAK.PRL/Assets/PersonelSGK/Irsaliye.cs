using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Irsaliye", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.IrsaliyeModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Irsaliye : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.Aciklamalar[] AciklamalarField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.AliciBilgileri AliciBilgileriField;

		[OptionalField]
		private FirmaBigisi AliciSubeBilgileriField;

		[OptionalField]
		private Tanitici[] AliciSubeTaniticiField;

		[OptionalField]
		private Tanitici[] AliciTaniticiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.AliciBilgileri AsilAliciBilgileriField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.AliciBilgileri AsilSaticiBilgileriField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.DorsePlaka[] DorsePlakaField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.IrsaliyeBaslik IrsaliyeBaslikField;

		[OptionalField]
		private IrsaliyeKalemleri[] IrsaliyeKalemField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.AliciBilgileri IslemleriBaslatanBilgileriField;

		[OptionalField]
		private FirmaBigisi SaticiBilgileriField;

		[OptionalField]
		private FirmaBigisi SaticiSubeBilgileriField;

		[OptionalField]
		private Tanitici[] SaticiTaniticiField;

		[OptionalField]
		private OPTYPE.HizliTeknoloji.SoforBilgileri[] SoforBilgileriField;

		[DataMember]
		public OPTYPE.HizliTeknoloji.Aciklamalar[] Aciklamalar
		{
			get
			{
				return this.AciklamalarField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AciklamalarField, value))
				{
					this.AciklamalarField = value;
					this.RaisePropertyChanged("Aciklamalar");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.AliciBilgileri AliciBilgileri
		{
			get
			{
				return this.AliciBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliciBilgileriField, value))
				{
					this.AliciBilgileriField = value;
					this.RaisePropertyChanged("AliciBilgileri");
				}
			}
		}

		[DataMember]
		public FirmaBigisi AliciSubeBilgileri
		{
			get
			{
				return this.AliciSubeBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliciSubeBilgileriField, value))
				{
					this.AliciSubeBilgileriField = value;
					this.RaisePropertyChanged("AliciSubeBilgileri");
				}
			}
		}

		[DataMember]
		public Tanitici[] AliciSubeTanitici
		{
			get
			{
				return this.AliciSubeTaniticiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliciSubeTaniticiField, value))
				{
					this.AliciSubeTaniticiField = value;
					this.RaisePropertyChanged("AliciSubeTanitici");
				}
			}
		}

		[DataMember]
		public Tanitici[] AliciTanitici
		{
			get
			{
				return this.AliciTaniticiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AliciTaniticiField, value))
				{
					this.AliciTaniticiField = value;
					this.RaisePropertyChanged("AliciTanitici");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.AliciBilgileri AsilAliciBilgileri
		{
			get
			{
				return this.AsilAliciBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AsilAliciBilgileriField, value))
				{
					this.AsilAliciBilgileriField = value;
					this.RaisePropertyChanged("AsilAliciBilgileri");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.AliciBilgileri AsilSaticiBilgileri
		{
			get
			{
				return this.AsilSaticiBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AsilSaticiBilgileriField, value))
				{
					this.AsilSaticiBilgileriField = value;
					this.RaisePropertyChanged("AsilSaticiBilgileri");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.DorsePlaka[] DorsePlaka
		{
			get
			{
				return this.DorsePlakaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DorsePlakaField, value))
				{
					this.DorsePlakaField = value;
					this.RaisePropertyChanged("DorsePlaka");
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
		public OPTYPE.HizliTeknoloji.IrsaliyeBaslik IrsaliyeBaslik
		{
			get
			{
				return this.IrsaliyeBaslikField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IrsaliyeBaslikField, value))
				{
					this.IrsaliyeBaslikField = value;
					this.RaisePropertyChanged("IrsaliyeBaslik");
				}
			}
		}

		[DataMember]
		public IrsaliyeKalemleri[] IrsaliyeKalem
		{
			get
			{
				return this.IrsaliyeKalemField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IrsaliyeKalemField, value))
				{
					this.IrsaliyeKalemField = value;
					this.RaisePropertyChanged("IrsaliyeKalem");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.AliciBilgileri IslemleriBaslatanBilgileri
		{
			get
			{
				return this.IslemleriBaslatanBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IslemleriBaslatanBilgileriField, value))
				{
					this.IslemleriBaslatanBilgileriField = value;
					this.RaisePropertyChanged("IslemleriBaslatanBilgileri");
				}
			}
		}

		[DataMember]
		public FirmaBigisi SaticiBilgileri
		{
			get
			{
				return this.SaticiBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SaticiBilgileriField, value))
				{
					this.SaticiBilgileriField = value;
					this.RaisePropertyChanged("SaticiBilgileri");
				}
			}
		}

		[DataMember]
		public FirmaBigisi SaticiSubeBilgileri
		{
			get
			{
				return this.SaticiSubeBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SaticiSubeBilgileriField, value))
				{
					this.SaticiSubeBilgileriField = value;
					this.RaisePropertyChanged("SaticiSubeBilgileri");
				}
			}
		}

		[DataMember]
		public Tanitici[] SaticiTanitici
		{
			get
			{
				return this.SaticiTaniticiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SaticiTaniticiField, value))
				{
					this.SaticiTaniticiField = value;
					this.RaisePropertyChanged("SaticiTanitici");
				}
			}
		}

		[DataMember]
		public OPTYPE.HizliTeknoloji.SoforBilgileri[] SoforBilgileri
		{
			get
			{
				return this.SoforBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SoforBilgileriField, value))
				{
					this.SoforBilgileriField = value;
					this.RaisePropertyChanged("SoforBilgileri");
				}
			}
		}

		public Irsaliye()
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