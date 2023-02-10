using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="BuyerCustomerParty", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class BuyerCustomerParty : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string CityNameField;

		[OptionalField]
		private string CountryNameField;

		[OptionalField]
		private string IdentificationIDField;

		[OptionalField]
		private string PartyNameField;

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

		public BuyerCustomerParty()
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