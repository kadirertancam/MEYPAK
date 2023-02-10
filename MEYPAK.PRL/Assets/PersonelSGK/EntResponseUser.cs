using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPTYPE.HizliTeknoloji
{
	[DataContract(Name="EntResponseUser", Namespace="http://schemas.datacontract.org/2004/07/HizliWebApp.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class EntResponseUser : ResponseMessage
	{
		[OptionalField]
		private string kalanKontorField;

		[OptionalField]
		private MusteriBilgileri musteriBilgileriField;

		[OptionalField]
		private KrediSonucu sonucVerisiField;

		[DataMember]
		public string kalanKontor
		{
			get
			{
				return this.kalanKontorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.kalanKontorField, value))
				{
					this.kalanKontorField = value;
					base.RaisePropertyChanged("kalanKontor");
				}
			}
		}

		[DataMember]
		public MusteriBilgileri musteriBilgileri
		{
			get
			{
				return this.musteriBilgileriField;
			}
			set
			{
				if (!object.ReferenceEquals(this.musteriBilgileriField, value))
				{
					this.musteriBilgileriField = value;
					base.RaisePropertyChanged("musteriBilgileri");
				}
			}
		}

		[DataMember]
		public KrediSonucu sonucVerisi
		{
			get
			{
				return this.sonucVerisiField;
			}
			set
			{
				if (!object.ReferenceEquals(this.sonucVerisiField, value))
				{
					this.sonucVerisiField = value;
					base.RaisePropertyChanged("sonucVerisi");
				}
			}
		}

		public EntResponseUser()
		{
		}
	}
}