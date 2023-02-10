using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="UploadDocumentTransferInput", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class UploadDocumentTransferInput : INotifyPropertyChanged, IExtensibleDataObject
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AppTypeField;

		[OptionalField]
		private TransferTip TipField;

		[OptionalField]
		private byte[] ZipContentField;

		[DataMember]
		public int AppType
		{
			get
			{
				return this.AppTypeField;
			}
			set
			{
				if (!this.AppTypeField.Equals(value))
				{
					this.AppTypeField = value;
					this.RaisePropertyChanged("AppType");
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
		public TransferTip Tip
		{
			get
			{
				return this.TipField;
			}
			set
			{
				if (!this.TipField.Equals(value))
				{
					this.TipField = value;
					this.RaisePropertyChanged("Tip");
				}
			}
		}

		[DataMember]
		public byte[] ZipContent
		{
			get
			{
				return this.ZipContentField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ZipContentField, value))
				{
					this.ZipContentField = value;
					this.RaisePropertyChanged("ZipContent");
				}
			}
		}

		public UploadDocumentTransferInput()
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