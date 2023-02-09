using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="AliciBilgileri", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.IrsaliyeModel")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AliciBilgileri : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string Adres_NoField;

		[OptionalField]
		private Tanitici[] AliciTaniticiField;

		[OptionalField]
		private string BinaField;

		[OptionalField]
		private string Bina_NoField;

		[OptionalField]
		private string CaddeField;

		[OptionalField]
		private string Daire_NoField;

		[OptionalField]
		private string E_PostaField;

		[OptionalField]
		private string FaksField;

		[OptionalField]
		private string IlField;

		[OptionalField]
		private string IlceField;

		[OptionalField]
		private string Internet_SitesiField;

		[OptionalField]
		private string Kisi_AdiField;

		[OptionalField]
		private string Kisi_SoyadiField;

		[OptionalField]
		private bool ManuelCityAndSubdivisionField;

		[OptionalField]
		private string Posta_KoduField;

		[OptionalField]
		private string SemtField;

		[OptionalField]
		private string TelefonField;

		[OptionalField]
		private string Teslimat_Adres_NoField;

		[OptionalField]
		private string Teslimat_BinaField;

		[OptionalField]
		private string Teslimat_Bina_NoField;

		[OptionalField]
		private string Teslimat_CaddeField;

		[OptionalField]
		private string Teslimat_Daire_NoField;

		[OptionalField]
		private string Teslimat_IlField;

		[OptionalField]
		private string Teslimat_IlceField;

		[OptionalField]
		private string Teslimat_Posta_KoduField;

		[OptionalField]
		private string Teslimat_SemtField;

		[OptionalField]
		private string Teslimat_Ulke_AdiField;

		[OptionalField]
		private string Teslimat_Ulke_KoduField;

		[OptionalField]
		private string Ulke_AdiField;

		[OptionalField]
		private string Ulke_KoduField;

		[OptionalField]
		private string UnvaniField;

		[OptionalField]
		private string VKN_TCKNField;

		[OptionalField]
		private string Vergi_DairesiField;

		[DataMember]
		public string Adres_No
		{
			get
			{
				return this.Adres_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Adres_NoField, value))
				{
					this.Adres_NoField = value;
					this.RaisePropertyChanged("Adres_No");
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
		public string Bina
		{
			get
			{
				return this.BinaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BinaField, value))
				{
					this.BinaField = value;
					this.RaisePropertyChanged("Bina");
				}
			}
		}

		[DataMember]
		public string Bina_No
		{
			get
			{
				return this.Bina_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Bina_NoField, value))
				{
					this.Bina_NoField = value;
					this.RaisePropertyChanged("Bina_No");
				}
			}
		}

		[DataMember]
		public string Cadde
		{
			get
			{
				return this.CaddeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CaddeField, value))
				{
					this.CaddeField = value;
					this.RaisePropertyChanged("Cadde");
				}
			}
		}

		[DataMember]
		public string Daire_No
		{
			get
			{
				return this.Daire_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Daire_NoField, value))
				{
					this.Daire_NoField = value;
					this.RaisePropertyChanged("Daire_No");
				}
			}
		}

		[DataMember]
		public string E_Posta
		{
			get
			{
				return this.E_PostaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.E_PostaField, value))
				{
					this.E_PostaField = value;
					this.RaisePropertyChanged("E_Posta");
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
		public string Faks
		{
			get
			{
				return this.FaksField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FaksField, value))
				{
					this.FaksField = value;
					this.RaisePropertyChanged("Faks");
				}
			}
		}

		[DataMember]
		public string Il
		{
			get
			{
				return this.IlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IlField, value))
				{
					this.IlField = value;
					this.RaisePropertyChanged("Il");
				}
			}
		}

		[DataMember]
		public string Ilce
		{
			get
			{
				return this.IlceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IlceField, value))
				{
					this.IlceField = value;
					this.RaisePropertyChanged("Ilce");
				}
			}
		}

		[DataMember]
		public string Internet_Sitesi
		{
			get
			{
				return this.Internet_SitesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Internet_SitesiField, value))
				{
					this.Internet_SitesiField = value;
					this.RaisePropertyChanged("Internet_Sitesi");
				}
			}
		}

		[DataMember]
		public string Kisi_Adi
		{
			get
			{
				return this.Kisi_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Kisi_AdiField, value))
				{
					this.Kisi_AdiField = value;
					this.RaisePropertyChanged("Kisi_Adi");
				}
			}
		}

		[DataMember]
		public string Kisi_Soyadi
		{
			get
			{
				return this.Kisi_SoyadiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Kisi_SoyadiField, value))
				{
					this.Kisi_SoyadiField = value;
					this.RaisePropertyChanged("Kisi_Soyadi");
				}
			}
		}

		[DataMember]
		public bool ManuelCityAndSubdivision
		{
			get
			{
				return this.ManuelCityAndSubdivisionField;
			}
			set
			{
				if (!this.ManuelCityAndSubdivisionField.Equals(value))
				{
					this.ManuelCityAndSubdivisionField = value;
					this.RaisePropertyChanged("ManuelCityAndSubdivision");
				}
			}
		}

		[DataMember]
		public string Posta_Kodu
		{
			get
			{
				return this.Posta_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Posta_KoduField, value))
				{
					this.Posta_KoduField = value;
					this.RaisePropertyChanged("Posta_Kodu");
				}
			}
		}

		[DataMember]
		public string Semt
		{
			get
			{
				return this.SemtField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SemtField, value))
				{
					this.SemtField = value;
					this.RaisePropertyChanged("Semt");
				}
			}
		}

		[DataMember]
		public string Telefon
		{
			get
			{
				return this.TelefonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefonField, value))
				{
					this.TelefonField = value;
					this.RaisePropertyChanged("Telefon");
				}
			}
		}

		[DataMember]
		public string Teslimat_Adres_No
		{
			get
			{
				return this.Teslimat_Adres_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Adres_NoField, value))
				{
					this.Teslimat_Adres_NoField = value;
					this.RaisePropertyChanged("Teslimat_Adres_No");
				}
			}
		}

		[DataMember]
		public string Teslimat_Bina
		{
			get
			{
				return this.Teslimat_BinaField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_BinaField, value))
				{
					this.Teslimat_BinaField = value;
					this.RaisePropertyChanged("Teslimat_Bina");
				}
			}
		}

		[DataMember]
		public string Teslimat_Bina_No
		{
			get
			{
				return this.Teslimat_Bina_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Bina_NoField, value))
				{
					this.Teslimat_Bina_NoField = value;
					this.RaisePropertyChanged("Teslimat_Bina_No");
				}
			}
		}

		[DataMember]
		public string Teslimat_Cadde
		{
			get
			{
				return this.Teslimat_CaddeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_CaddeField, value))
				{
					this.Teslimat_CaddeField = value;
					this.RaisePropertyChanged("Teslimat_Cadde");
				}
			}
		}

		[DataMember]
		public string Teslimat_Daire_No
		{
			get
			{
				return this.Teslimat_Daire_NoField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Daire_NoField, value))
				{
					this.Teslimat_Daire_NoField = value;
					this.RaisePropertyChanged("Teslimat_Daire_No");
				}
			}
		}

		[DataMember]
		public string Teslimat_Il
		{
			get
			{
				return this.Teslimat_IlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_IlField, value))
				{
					this.Teslimat_IlField = value;
					this.RaisePropertyChanged("Teslimat_Il");
				}
			}
		}

		[DataMember]
		public string Teslimat_Ilce
		{
			get
			{
				return this.Teslimat_IlceField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_IlceField, value))
				{
					this.Teslimat_IlceField = value;
					this.RaisePropertyChanged("Teslimat_Ilce");
				}
			}
		}

		[DataMember]
		public string Teslimat_Posta_Kodu
		{
			get
			{
				return this.Teslimat_Posta_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Posta_KoduField, value))
				{
					this.Teslimat_Posta_KoduField = value;
					this.RaisePropertyChanged("Teslimat_Posta_Kodu");
				}
			}
		}

		[DataMember]
		public string Teslimat_Semt
		{
			get
			{
				return this.Teslimat_SemtField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_SemtField, value))
				{
					this.Teslimat_SemtField = value;
					this.RaisePropertyChanged("Teslimat_Semt");
				}
			}
		}

		[DataMember]
		public string Teslimat_Ulke_Adi
		{
			get
			{
				return this.Teslimat_Ulke_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Ulke_AdiField, value))
				{
					this.Teslimat_Ulke_AdiField = value;
					this.RaisePropertyChanged("Teslimat_Ulke_Adi");
				}
			}
		}

		[DataMember]
		public string Teslimat_Ulke_Kodu
		{
			get
			{
				return this.Teslimat_Ulke_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Teslimat_Ulke_KoduField, value))
				{
					this.Teslimat_Ulke_KoduField = value;
					this.RaisePropertyChanged("Teslimat_Ulke_Kodu");
				}
			}
		}

		[DataMember]
		public string Ulke_Adi
		{
			get
			{
				return this.Ulke_AdiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Ulke_AdiField, value))
				{
					this.Ulke_AdiField = value;
					this.RaisePropertyChanged("Ulke_Adi");
				}
			}
		}

		[DataMember]
		public string Ulke_Kodu
		{
			get
			{
				return this.Ulke_KoduField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Ulke_KoduField, value))
				{
					this.Ulke_KoduField = value;
					this.RaisePropertyChanged("Ulke_Kodu");
				}
			}
		}

		[DataMember]
		public string Unvani
		{
			get
			{
				return this.UnvaniField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UnvaniField, value))
				{
					this.UnvaniField = value;
					this.RaisePropertyChanged("Unvani");
				}
			}
		}

		[DataMember]
		public string Vergi_Dairesi
		{
			get
			{
				return this.Vergi_DairesiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Vergi_DairesiField, value))
				{
					this.Vergi_DairesiField = value;
					this.RaisePropertyChanged("Vergi_Dairesi");
				}
			}
		}

		[DataMember]
		public string VKN_TCKN
		{
			get
			{
				return this.VKN_TCKNField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VKN_TCKNField, value))
				{
					this.VKN_TCKNField = value;
					this.RaisePropertyChanged("VKN_TCKN");
				}
			}
		}

		public AliciBilgileri()
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