using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Class1
    {

        // NOT: Oluşturulan kod en az .NET Framework 4.5 veya.NET Core/Standard 2.0 gerektirebilir.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
        public partial class Envelope
        {

            private EnvelopeBody bodyField;

            /// <remarks/>
            public EnvelopeBody Body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public partial class EnvelopeBody
        {

            private BaseRequestMessageOf_UrunlerIstek baseRequestMessageOf_UrunlerIstekField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseRequestMessageOf_UrunlerIstek BaseRequestMessageOf_UrunlerIstek
            {
                get
                {
                    return this.baseRequestMessageOf_UrunlerIstekField;
                }
                set
                {
                    this.baseRequestMessageOf_UrunlerIstekField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gtb.gov.tr//WebServices")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gtb.gov.tr//WebServices", IsNullable = false)]
        public partial class BaseRequestMessageOf_UrunlerIstek
        {

            private object istekField;

            private string passwordField;

            private string servicePasswordField;

            private ulong userNameField;

            /// <remarks/>
            public object Istek
            {
                get
                {
                    return this.istekField;
                }
                set
                {
                    this.istekField = value;
                }
            }

            /// <remarks/>
            public string Password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }

            /// <remarks/>
            public string ServicePassword
            {
                get
                {
                    return this.servicePasswordField;
                }
                set
                {
                    this.servicePasswordField = value;
                }
            }

            /// <remarks/>
            public ulong UserName
            {
                get
                {
                    return this.userNameField;
                }
                set
                {
                    this.userNameField = value;
                }
            }
        }


    }
}
