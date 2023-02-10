using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="KrediSonucu", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class KrediSonucu : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private decimal harcananAlanMiktariField;

		[OptionalField]
		private int harcananEArsivFaturaMiktariField;

		[OptionalField]
		private int harcananGelenFaturaMiktariField;

		[OptionalField]
		private int harcananGidenFaturaMiktariField;

		[OptionalField]
		private decimal toplamAlanBoyutuField;

		[OptionalField]
		private int toplamFaturaAdediField;

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
		public decimal harcananAlanMiktari
		{
			get
			{
				return this.harcananAlanMiktariField;
			}
			set
			{
				if (!this.harcananAlanMiktariField.Equals(value))
				{
					this.harcananAlanMiktariField = value;
					this.RaisePropertyChanged("harcananAlanMiktari");
				}
			}
		}

		[DataMember]
		public int harcananEArsivFaturaMiktari
		{
			get
			{
				return this.harcananEArsivFaturaMiktariField;
			}
			set
			{
				if (!this.harcananEArsivFaturaMiktariField.Equals(value))
				{
					this.harcananEArsivFaturaMiktariField = value;
					this.RaisePropertyChanged("harcananEArsivFaturaMiktari");
				}
			}
		}

		[DataMember]
		public int harcananGelenFaturaMiktari
		{
			get
			{
				return this.harcananGelenFaturaMiktariField;
			}
			set
			{
				if (!this.harcananGelenFaturaMiktariField.Equals(value))
				{
					this.harcananGelenFaturaMiktariField = value;
					this.RaisePropertyChanged("harcananGelenFaturaMiktari");
				}
			}
		}

		[DataMember]
		public int harcananGidenFaturaMiktari
		{
			get
			{
				return this.harcananGidenFaturaMiktariField;
			}
			set
			{
				if (!this.harcananGidenFaturaMiktariField.Equals(value))
				{
					this.harcananGidenFaturaMiktariField = value;
					this.RaisePropertyChanged("harcananGidenFaturaMiktari");
				}
			}
		}

		[DataMember]
		public decimal toplamAlanBoyutu
		{
			get
			{
				return this.toplamAlanBoyutuField;
			}
			set
			{
				if (!this.toplamAlanBoyutuField.Equals(value))
				{
					this.toplamAlanBoyutuField = value;
					this.RaisePropertyChanged("toplamAlanBoyutu");
				}
			}
		}

		[DataMember]
		public int toplamFaturaAdedi
		{
			get
			{
				return this.toplamFaturaAdediField;
			}
			set
			{
				if (!this.toplamFaturaAdediField.Equals(value))
				{
					this.toplamFaturaAdediField = value;
					this.RaisePropertyChanged("toplamFaturaAdedi");
				}
			}
		}

		public KrediSonucu()
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