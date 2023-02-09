using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Customer : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string CityNameField;

		[OptionalField]
		private string CitySubdivisionNameField;

		[OptionalField]
		private string CountryNameField;

		[OptionalField]
		private string ElectronicMailField;

		[OptionalField]
		private string IdentificationIDField;

		[OptionalField]
		private bool ManuelCityAndSubdivisionField;

		[OptionalField]
		private string PartyNameField;

		[OptionalField]
		private string Person_FamilyNameField;

		[OptionalField]
		private string Person_FirstNameField;

		[OptionalField]
		private string PostalZoneField;

		[OptionalField]
		private string StreetNameField;

		[OptionalField]
		private string TaxSchemeNameField;

		[OptionalField]
		private string TelefaxField;

		[OptionalField]
		private string TelephoneField;

		[OptionalField]
		private string WebsiteURIField;

		[OptionalField]
		private Customer_Identification[] customerIdentificationsOtherField;

		[DataMember]
		public string CityName
		{
			get
			{
				return this.CityNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CityNameField, value))
				{
					this.CityNameField = value;
					this.RaisePropertyChanged("CityName");
				}
			}
		}

		[DataMember]
		public string CitySubdivisionName
		{
			get
			{
				return this.CitySubdivisionNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CitySubdivisionNameField, value))
				{
					this.CitySubdivisionNameField = value;
					this.RaisePropertyChanged("CitySubdivisionName");
				}
			}
		}

		[DataMember]
		public string CountryName
		{
			get
			{
				return this.CountryNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CountryNameField, value))
				{
					this.CountryNameField = value;
					this.RaisePropertyChanged("CountryName");
				}
			}
		}

		[DataMember]
		public Customer_Identification[] customerIdentificationsOther
		{
			get
			{
				return this.customerIdentificationsOtherField;
			}
			set
			{
				if (!object.ReferenceEquals(this.customerIdentificationsOtherField, value))
				{
					this.customerIdentificationsOtherField = value;
					this.RaisePropertyChanged("customerIdentificationsOther");
				}
			}
		}

		[DataMember]
		public string ElectronicMail
		{
			get
			{
				return this.ElectronicMailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ElectronicMailField, value))
				{
					this.ElectronicMailField = value;
					this.RaisePropertyChanged("ElectronicMail");
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
		public string IdentificationID
		{
			get
			{
				return this.IdentificationIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdentificationIDField, value))
				{
					this.IdentificationIDField = value;
					this.RaisePropertyChanged("IdentificationID");
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
		public string PartyName
		{
			get
			{
				return this.PartyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PartyNameField, value))
				{
					this.PartyNameField = value;
					this.RaisePropertyChanged("PartyName");
				}
			}
		}

		[DataMember]
		public string Person_FamilyName
		{
			get
			{
				return this.Person_FamilyNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Person_FamilyNameField, value))
				{
					this.Person_FamilyNameField = value;
					this.RaisePropertyChanged("Person_FamilyName");
				}
			}
		}

		[DataMember]
		public string Person_FirstName
		{
			get
			{
				return this.Person_FirstNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Person_FirstNameField, value))
				{
					this.Person_FirstNameField = value;
					this.RaisePropertyChanged("Person_FirstName");
				}
			}
		}

		[DataMember]
		public string PostalZone
		{
			get
			{
				return this.PostalZoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostalZoneField, value))
				{
					this.PostalZoneField = value;
					this.RaisePropertyChanged("PostalZone");
				}
			}
		}

		[DataMember]
		public string StreetName
		{
			get
			{
				return this.StreetNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StreetNameField, value))
				{
					this.StreetNameField = value;
					this.RaisePropertyChanged("StreetName");
				}
			}
		}

		[DataMember]
		public string String_0
		{
			get
			{
				return this.WebsiteURIField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WebsiteURIField, value))
				{
					this.WebsiteURIField = value;
					this.RaisePropertyChanged("WebsiteURI");
				}
			}
		}

		[DataMember]
		public string TaxSchemeName
		{
			get
			{
				return this.TaxSchemeNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TaxSchemeNameField, value))
				{
					this.TaxSchemeNameField = value;
					this.RaisePropertyChanged("TaxSchemeName");
				}
			}
		}

		[DataMember]
		public string Telefax
		{
			get
			{
				return this.TelefaxField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefaxField, value))
				{
					this.TelefaxField = value;
					this.RaisePropertyChanged("Telefax");
				}
			}
		}

		[DataMember]
		public string Telephone
		{
			get
			{
				return this.TelephoneField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelephoneField, value))
				{
					this.TelephoneField = value;
					this.RaisePropertyChanged("Telephone");
				}
			}
		}

		public Customer()
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