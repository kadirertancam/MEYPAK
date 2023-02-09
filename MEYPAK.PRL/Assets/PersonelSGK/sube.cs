using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="sube", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.HbtMusteri")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class sube : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool MerkezMiField;

		[OptionalField]
		private string binaAdiField;

		[OptionalField]
		private string binaNoField;

		[OptionalField]
		private string caddeAdiField;

		[OptionalField]
		private string efaturaGbEtiketField;

		[OptionalField]
		private string efaturaPkEtiketField;

		[OptionalField]
		private string eirsaliyeGbEtiketField;

		[OptionalField]
		private string eirsaliyePkEtiketField;

		[OptionalField]
		private string epostaField;

		[OptionalField]
		private string faxField;

		[OptionalField]
		private string ilceAdiField;

		[OptionalField]
		private string kapiNoField;

		[OptionalField]
		private string postaKoduField;

		[OptionalField]
		private int referansIdField;

		[OptionalField]
		private string sehirAdiField;

		[OptionalField]
		private string subeAdiField;

		[OptionalField]
		private string subeKisaAdiField;

		[OptionalField]
		private TaniticiModel[] taniticiListField;

		[OptionalField]
		private string telefonField;

		[OptionalField]
		private string ulkeField;

		[OptionalField]
		private string webSitesiField;

		[DataMember]
		public string binaAdi
		{
			get
			{
				return this.binaAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.binaAdiField, value))
				{
					this.binaAdiField = value;
					this.RaisePropertyChanged("binaAdi");
				}
			}
		}

		[DataMember]
		public string binaNo
		{
			get
			{
				return this.binaNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.binaNoField, value))
				{
					this.binaNoField = value;
					this.RaisePropertyChanged("binaNo");
				}
			}
		}

		[DataMember]
		public string caddeAdi
		{
			get
			{
				return this.caddeAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.caddeAdiField, value))
				{
					this.caddeAdiField = value;
					this.RaisePropertyChanged("caddeAdi");
				}
			}
		}

		[DataMember]
		public string efaturaGbEtiket
		{
			get
			{
				return this.efaturaGbEtiketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.efaturaGbEtiketField, value))
				{
					this.efaturaGbEtiketField = value;
					this.RaisePropertyChanged("efaturaGbEtiket");
				}
			}
		}

		[DataMember]
		public string efaturaPkEtiket
		{
			get
			{
				return this.efaturaPkEtiketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.efaturaPkEtiketField, value))
				{
					this.efaturaPkEtiketField = value;
					this.RaisePropertyChanged("efaturaPkEtiket");
				}
			}
		}

		[DataMember]
		public string eirsaliyeGbEtiket
		{
			get
			{
				return this.eirsaliyeGbEtiketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.eirsaliyeGbEtiketField, value))
				{
					this.eirsaliyeGbEtiketField = value;
					this.RaisePropertyChanged("eirsaliyeGbEtiket");
				}
			}
		}

		[DataMember]
		public string eirsaliyePkEtiket
		{
			get
			{
				return this.eirsaliyePkEtiketField;
			}
			set
			{
				if (!object.ReferenceEquals(this.eirsaliyePkEtiketField, value))
				{
					this.eirsaliyePkEtiketField = value;
					this.RaisePropertyChanged("eirsaliyePkEtiket");
				}
			}
		}

		[DataMember]
		public string eposta
		{
			get
			{
				return this.epostaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.epostaField, value))
				{
					this.epostaField = value;
					this.RaisePropertyChanged("eposta");
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
		public string fax
		{
			get
			{
				return this.faxField;
			}
			set
			{
				if (!object.ReferenceEquals(this.faxField, value))
				{
					this.faxField = value;
					this.RaisePropertyChanged("fax");
				}
			}
		}

		[DataMember]
		public string ilceAdi
		{
			get
			{
				return this.ilceAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ilceAdiField, value))
				{
					this.ilceAdiField = value;
					this.RaisePropertyChanged("ilceAdi");
				}
			}
		}

		[DataMember]
		public string kapiNo
		{
			get
			{
				return this.kapiNoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kapiNoField, value))
				{
					this.kapiNoField = value;
					this.RaisePropertyChanged("kapiNo");
				}
			}
		}

		[DataMember]
		public bool MerkezMi
		{
			get
			{
				return this.MerkezMiField;
			}
			set
			{
				if (!this.MerkezMiField.Equals(value))
				{
					this.MerkezMiField = value;
					this.RaisePropertyChanged("MerkezMi");
				}
			}
		}

		[DataMember]
		public string postaKodu
		{
			get
			{
				return this.postaKoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.postaKoduField, value))
				{
					this.postaKoduField = value;
					this.RaisePropertyChanged("postaKodu");
				}
			}
		}

		[DataMember]
		public int referansId
		{
			get
			{
				return this.referansIdField;
			}
			set
			{
				if (!this.referansIdField.Equals(value))
				{
					this.referansIdField = value;
					this.RaisePropertyChanged("referansId");
				}
			}
		}

		[DataMember]
		public string sehirAdi
		{
			get
			{
				return this.sehirAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sehirAdiField, value))
				{
					this.sehirAdiField = value;
					this.RaisePropertyChanged("sehirAdi");
				}
			}
		}

		[DataMember]
		public string subeAdi
		{
			get
			{
				return this.subeAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.subeAdiField, value))
				{
					this.subeAdiField = value;
					this.RaisePropertyChanged("subeAdi");
				}
			}
		}

		[DataMember]
		public string subeKisaAdi
		{
			get
			{
				return this.subeKisaAdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.subeKisaAdiField, value))
				{
					this.subeKisaAdiField = value;
					this.RaisePropertyChanged("subeKisaAdi");
				}
			}
		}

		[DataMember]
		public TaniticiModel[] taniticiList
		{
			get
			{
				return this.taniticiListField;
			}
			set
			{
				if (!object.ReferenceEquals(this.taniticiListField, value))
				{
					this.taniticiListField = value;
					this.RaisePropertyChanged("taniticiList");
				}
			}
		}

		[DataMember]
		public string telefon
		{
			get
			{
				return this.telefonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.telefonField, value))
				{
					this.telefonField = value;
					this.RaisePropertyChanged("telefon");
				}
			}
		}

		[DataMember]
		public string ulke
		{
			get
			{
				return this.ulkeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ulkeField, value))
				{
					this.ulkeField = value;
					this.RaisePropertyChanged("ulke");
				}
			}
		}

		[DataMember]
		public string webSitesi
		{
			get
			{
				return this.webSitesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.webSitesiField, value))
				{
					this.webSitesiField = value;
					this.RaisePropertyChanged("webSitesi");
				}
			}
		}

		public sube()
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