using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="LineTax", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Models.InvoiceModels")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class LineTax : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private decimal Tax_AmntField;

		[OptionalField]
		private decimal Tax_BaseField;

		[OptionalField]
		private string Tax_CodeField;

		[OptionalField]
		private string Tax_ExemField;

		[OptionalField]
		private string Tax_Exem_CodeField;

		[OptionalField]
		private string Tax_NameField;

		[OptionalField]
		private decimal Tax_PercField;

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
		public decimal Tax_Amnt
		{
			get
			{
				return this.Tax_AmntField;
			}
			set
			{
				if (!this.Tax_AmntField.Equals(value))
				{
					this.Tax_AmntField = value;
					this.RaisePropertyChanged("Tax_Amnt");
				}
			}
		}

		[DataMember]
		public decimal Tax_Base
		{
			get
			{
				return this.Tax_BaseField;
			}
			set
			{
				if (!this.Tax_BaseField.Equals(value))
				{
					this.Tax_BaseField = value;
					this.RaisePropertyChanged("Tax_Base");
				}
			}
		}

		[DataMember]
		public string Tax_Code
		{
			get
			{
				return this.Tax_CodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tax_CodeField, value))
				{
					this.Tax_CodeField = value;
					this.RaisePropertyChanged("Tax_Code");
				}
			}
		}

		[DataMember]
		public string Tax_Exem
		{
			get
			{
				return this.Tax_ExemField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tax_ExemField, value))
				{
					this.Tax_ExemField = value;
					this.RaisePropertyChanged("Tax_Exem");
				}
			}
		}

		[DataMember]
		public string Tax_Exem_Code
		{
			get
			{
				return this.Tax_Exem_CodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tax_Exem_CodeField, value))
				{
					this.Tax_Exem_CodeField = value;
					this.RaisePropertyChanged("Tax_Exem_Code");
				}
			}
		}

		[DataMember]
		public string Tax_Name
		{
			get
			{
				return this.Tax_NameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.Tax_NameField, value))
				{
					this.Tax_NameField = value;
					this.RaisePropertyChanged("Tax_Name");
				}
			}
		}

		[DataMember]
		public decimal Tax_Perc
		{
			get
			{
				return this.Tax_PercField;
			}
			set
			{
				if (!this.Tax_PercField.Equals(value))
				{
					this.Tax_PercField = value;
					this.RaisePropertyChanged("Tax_Perc");
				}
			}
		}

		public LineTax()
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