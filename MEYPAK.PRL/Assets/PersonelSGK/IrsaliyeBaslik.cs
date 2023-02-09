using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="IrsaliyeBaslik", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.IrsaliyeModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class IrsaliyeBaslik : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string DestinationUrnField;

		[OptionalField]
		private decimal Doviz_KuruField;

		[OptionalField]
		private string string_0;

		[OptionalField]
		private string Irsaliye_NoField;

		[OptionalField]
		private DateTime Irsaliye_TarihiField;

		[OptionalField]
		private string Irsaliye_TipiField;

		[OptionalField]
		private DateTime Irsaliye_ZamaniField;

		[OptionalField]
		private string Para_BirimiField;

		[OptionalField]
		private string PlakaField;

		[OptionalField]
		private string PrefixField;

		[OptionalField]
		private string SenaryoField;

		[OptionalField]
		private DateTime Sevk_TarihiField;

		[OptionalField]
		private DateTime Sevk_ZamaniField;

		[OptionalField]
		private string Siparis_NoField;

		[OptionalField]
		private DateTime Siparis_TarihField;

		[OptionalField]
		private string SourceUrnField;

		[OptionalField]
		private int SubeKoduField;

		[OptionalField]
		private string Tasiyici_AdiField;

		[OptionalField]
		private string Tasiyici_SoyadiField;

		[OptionalField]
		private string Tasiyici_UnvanField;

		[OptionalField]
		private string Tasiyici_VknField;

		[OptionalField]
		private decimal Toplam_TutarField;

		[OptionalField]
		private bool UpdateDocumentField;

		[OptionalField]
		private string XSLT_AdiField;

		[DataMember]
		public string DestinationUrn
		{
			get
			{
				return this.DestinationUrnField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DestinationUrnField, value))
				{
					this.DestinationUrnField = value;
					this.RaisePropertyChanged("DestinationUrn");
				}
			}
		}

		[DataMember]
		public decimal Doviz_Kuru
		{
			get
			{
				return this.Doviz_KuruField;
			}
			set
			{
				if (!this.Doviz_KuruField.Equals(value))
				{
					this.Doviz_KuruField = value;
					this.RaisePropertyChanged("Doviz_Kuru");
				}
			}
		}

		[DataMember]
		public string ETTN
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (!object.ReferenceEquals(this.string_0, value))
				{
					this.string_0 = value;
					this.RaisePropertyChanged("ETTN");
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
		public string Irsaliye_No
		{
			get
			{
				return this.Irsaliye_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Irsaliye_NoField, value))
				{
					this.Irsaliye_NoField = value;
					this.RaisePropertyChanged("Irsaliye_No");
				}
			}
		}

		[DataMember]
		public DateTime Irsaliye_Tarihi
		{
			get
			{
				return this.Irsaliye_TarihiField;
			}
			set
			{
				if (!this.Irsaliye_TarihiField.Equals(value))
				{
					this.Irsaliye_TarihiField = value;
					this.RaisePropertyChanged("Irsaliye_Tarihi");
				}
			}
		}

		[DataMember]
		public string Irsaliye_Tipi
		{
			get
			{
				return this.Irsaliye_TipiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Irsaliye_TipiField, value))
				{
					this.Irsaliye_TipiField = value;
					this.RaisePropertyChanged("Irsaliye_Tipi");
				}
			}
		}

		[DataMember]
		public DateTime Irsaliye_Zamani
		{
			get
			{
				return this.Irsaliye_ZamaniField;
			}
			set
			{
				if (!this.Irsaliye_ZamaniField.Equals(value))
				{
					this.Irsaliye_ZamaniField = value;
					this.RaisePropertyChanged("Irsaliye_Zamani");
				}
			}
		}

		[DataMember]
		public string Para_Birimi
		{
			get
			{
				return this.Para_BirimiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Para_BirimiField, value))
				{
					this.Para_BirimiField = value;
					this.RaisePropertyChanged("Para_Birimi");
				}
			}
		}

		[DataMember]
		public string Plaka
		{
			get
			{
				return this.PlakaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlakaField, value))
				{
					this.PlakaField = value;
					this.RaisePropertyChanged("Plaka");
				}
			}
		}

		[DataMember]
		public string Prefix
		{
			get
			{
				return this.PrefixField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PrefixField, value))
				{
					this.PrefixField = value;
					this.RaisePropertyChanged("Prefix");
				}
			}
		}

		[DataMember]
		public string Senaryo
		{
			get
			{
				return this.SenaryoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SenaryoField, value))
				{
					this.SenaryoField = value;
					this.RaisePropertyChanged("Senaryo");
				}
			}
		}

		[DataMember]
		public DateTime Sevk_Tarihi
		{
			get
			{
				return this.Sevk_TarihiField;
			}
			set
			{
				if (!this.Sevk_TarihiField.Equals(value))
				{
					this.Sevk_TarihiField = value;
					this.RaisePropertyChanged("Sevk_Tarihi");
				}
			}
		}

		[DataMember]
		public DateTime Sevk_Zamani
		{
			get
			{
				return this.Sevk_ZamaniField;
			}
			set
			{
				if (!this.Sevk_ZamaniField.Equals(value))
				{
					this.Sevk_ZamaniField = value;
					this.RaisePropertyChanged("Sevk_Zamani");
				}
			}
		}

		[DataMember]
		public string Siparis_No
		{
			get
			{
				return this.Siparis_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Siparis_NoField, value))
				{
					this.Siparis_NoField = value;
					this.RaisePropertyChanged("Siparis_No");
				}
			}
		}

		[DataMember]
		public DateTime Siparis_Tarih
		{
			get
			{
				return this.Siparis_TarihField;
			}
			set
			{
				if (!this.Siparis_TarihField.Equals(value))
				{
					this.Siparis_TarihField = value;
					this.RaisePropertyChanged("Siparis_Tarih");
				}
			}
		}

		[DataMember]
		public string SourceUrn
		{
			get
			{
				return this.SourceUrnField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SourceUrnField, value))
				{
					this.SourceUrnField = value;
					this.RaisePropertyChanged("SourceUrn");
				}
			}
		}

		[DataMember]
		public int SubeKodu
		{
			get
			{
				return this.SubeKoduField;
			}
			set
			{
				if (!this.SubeKoduField.Equals(value))
				{
					this.SubeKoduField = value;
					this.RaisePropertyChanged("SubeKodu");
				}
			}
		}

		[DataMember]
		public string Tasiyici_Adi
		{
			get
			{
				return this.Tasiyici_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tasiyici_AdiField, value))
				{
					this.Tasiyici_AdiField = value;
					this.RaisePropertyChanged("Tasiyici_Adi");
				}
			}
		}

		[DataMember]
		public string Tasiyici_Soyadi
		{
			get
			{
				return this.Tasiyici_SoyadiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tasiyici_SoyadiField, value))
				{
					this.Tasiyici_SoyadiField = value;
					this.RaisePropertyChanged("Tasiyici_Soyadi");
				}
			}
		}

		[DataMember]
		public string Tasiyici_Unvan
		{
			get
			{
				return this.Tasiyici_UnvanField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tasiyici_UnvanField, value))
				{
					this.Tasiyici_UnvanField = value;
					this.RaisePropertyChanged("Tasiyici_Unvan");
				}
			}
		}

		[DataMember]
		public string Tasiyici_Vkn
		{
			get
			{
				return this.Tasiyici_VknField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tasiyici_VknField, value))
				{
					this.Tasiyici_VknField = value;
					this.RaisePropertyChanged("Tasiyici_Vkn");
				}
			}
		}

		[DataMember]
		public decimal Toplam_Tutar
		{
			get
			{
				return this.Toplam_TutarField;
			}
			set
			{
				if (!this.Toplam_TutarField.Equals(value))
				{
					this.Toplam_TutarField = value;
					this.RaisePropertyChanged("Toplam_Tutar");
				}
			}
		}

		[DataMember]
		public bool UpdateDocument
		{
			get
			{
				return this.UpdateDocumentField;
			}
			set
			{
				if (!this.UpdateDocumentField.Equals(value))
				{
					this.UpdateDocumentField = value;
					this.RaisePropertyChanged("UpdateDocument");
				}
			}
		}

		[DataMember]
		public string XSLT_Adi
		{
			get
			{
				return this.XSLT_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.XSLT_AdiField, value))
				{
					this.XSLT_AdiField = value;
					this.RaisePropertyChanged("XSLT_Adi");
				}
			}
		}

		public IrsaliyeBaslik()
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