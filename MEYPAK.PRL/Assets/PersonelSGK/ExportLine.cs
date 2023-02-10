using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="ExportLine", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ExportLine : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string ActualPackageIDField;

		[OptionalField]
		private string ActualPackagePackagingTypeCodeField;

		[OptionalField]
		private string ActualPackagePackagingTypeNameField;

		[OptionalField]
		private decimal ActualPackageQuantityField;

		[OptionalField]
		private string CityNameField;

		[OptionalField]
		private string CitySubdivisionNameField;

		[OptionalField]
		private string CountryField;

		[OptionalField]
		private decimal DeclaredForCarriageValueAmountField;

		[OptionalField]
		private string DeliveryTermsIDField;

		[OptionalField]
		private string DeliveryTermsSpecialTermsField;

		[OptionalField]
		private decimal GrossWeightMeasureField;

		[OptionalField]
		private decimal InsuranceValueAmountField;

		[OptionalField]
		private decimal NetWeightMeasureField;

		[OptionalField]
		private string PartNameField;

		[OptionalField]
		private string RequiredCustomsIDField;

		[OptionalField]
		private string ShipmentTransportDetailField;

		[OptionalField]
		private string StreetNameField;

		[OptionalField]
		private string TransportModeCodeField;

		[DataMember]
		public string ActualPackageID
		{
			get
			{
				return this.ActualPackageIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActualPackageIDField, value))
				{
					this.ActualPackageIDField = value;
					this.RaisePropertyChanged("ActualPackageID");
				}
			}
		}

		[DataMember]
		public string ActualPackagePackagingTypeCode
		{
			get
			{
				return this.ActualPackagePackagingTypeCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActualPackagePackagingTypeCodeField, value))
				{
					this.ActualPackagePackagingTypeCodeField = value;
					this.RaisePropertyChanged("ActualPackagePackagingTypeCode");
				}
			}
		}

		[DataMember]
		public string ActualPackagePackagingTypeName
		{
			get
			{
				return this.ActualPackagePackagingTypeNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ActualPackagePackagingTypeNameField, value))
				{
					this.ActualPackagePackagingTypeNameField = value;
					this.RaisePropertyChanged("ActualPackagePackagingTypeName");
				}
			}
		}

		[DataMember]
		public decimal ActualPackageQuantity
		{
			get
			{
				return this.ActualPackageQuantityField;
			}
			set
			{
				if (!this.ActualPackageQuantityField.Equals(value))
				{
					this.ActualPackageQuantityField = value;
					this.RaisePropertyChanged("ActualPackageQuantity");
				}
			}
		}

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
		public string Country
		{
			get
			{
				return this.CountryField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CountryField, value))
				{
					this.CountryField = value;
					this.RaisePropertyChanged("Country");
				}
			}
		}

		[DataMember]
		public decimal DeclaredForCarriageValueAmount
		{
			get
			{
				return this.DeclaredForCarriageValueAmountField;
			}
			set
			{
				if (!this.DeclaredForCarriageValueAmountField.Equals(value))
				{
					this.DeclaredForCarriageValueAmountField = value;
					this.RaisePropertyChanged("DeclaredForCarriageValueAmount");
				}
			}
		}

		[DataMember]
		public string DeliveryTermsID
		{
			get
			{
				return this.DeliveryTermsIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeliveryTermsIDField, value))
				{
					this.DeliveryTermsIDField = value;
					this.RaisePropertyChanged("DeliveryTermsID");
				}
			}
		}

		[DataMember]
		public string DeliveryTermsSpecialTerms
		{
			get
			{
				return this.DeliveryTermsSpecialTermsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeliveryTermsSpecialTermsField, value))
				{
					this.DeliveryTermsSpecialTermsField = value;
					this.RaisePropertyChanged("DeliveryTermsSpecialTerms");
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
		public decimal GrossWeightMeasure
		{
			get
			{
				return this.GrossWeightMeasureField;
			}
			set
			{
				if (!this.GrossWeightMeasureField.Equals(value))
				{
					this.GrossWeightMeasureField = value;
					this.RaisePropertyChanged("GrossWeightMeasure");
				}
			}
		}

		[DataMember]
		public decimal InsuranceValueAmount
		{
			get
			{
				return this.InsuranceValueAmountField;
			}
			set
			{
				if (!this.InsuranceValueAmountField.Equals(value))
				{
					this.InsuranceValueAmountField = value;
					this.RaisePropertyChanged("InsuranceValueAmount");
				}
			}
		}

		[DataMember]
		public decimal NetWeightMeasure
		{
			get
			{
				return this.NetWeightMeasureField;
			}
			set
			{
				if (!this.NetWeightMeasureField.Equals(value))
				{
					this.NetWeightMeasureField = value;
					this.RaisePropertyChanged("NetWeightMeasure");
				}
			}
		}

		[DataMember]
		public string PartName
		{
			get
			{
				return this.PartNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PartNameField, value))
				{
					this.PartNameField = value;
					this.RaisePropertyChanged("PartName");
				}
			}
		}

		[DataMember]
		public string RequiredCustomsID
		{
			get
			{
				return this.RequiredCustomsIDField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RequiredCustomsIDField, value))
				{
					this.RequiredCustomsIDField = value;
					this.RaisePropertyChanged("RequiredCustomsID");
				}
			}
		}

		[DataMember]
		public string ShipmentTransportDetail
		{
			get
			{
				return this.ShipmentTransportDetailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ShipmentTransportDetailField, value))
				{
					this.ShipmentTransportDetailField = value;
					this.RaisePropertyChanged("ShipmentTransportDetail");
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
		public string TransportModeCode
		{
			get
			{
				return this.TransportModeCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TransportModeCodeField, value))
				{
					this.TransportModeCodeField = value;
					this.RaisePropertyChanged("TransportModeCode");
				}
			}
		}

		public ExportLine()
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