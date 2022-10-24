using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp2
{
    public class Urunler
    {
        [XmlRoot(ElementName = "BaseRequestMessageOf_UrunlerIstek", Namespace = "http://www.gtb.gov.tr//WebServices")]
        public class BaseRequestMessageOf_UrunlerIstek
        {
            [XmlElement(ElementName = "Istek", Namespace = "http://www.gtb.gov.tr//WebServices")]
            public UrunlerIstek Istek { get; set; }
            [XmlElement(ElementName = "Password", Namespace = "http://www.gtb.gov.tr//WebServices")]
            public string Password { get; set; }
            [XmlElement(ElementName = "ServicePassword", Namespace = "http://www.gtb.gov.tr//WebServices")]
            public string ServicePassword { get; set; }
            [XmlElement(ElementName = "UserName", Namespace = "http://www.gtb.gov.tr//WebServices")]
            public string UserName { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Body
        {
            [XmlElement(ElementName = "BaseRequestMessageOf_UrunlerIstek", Namespace = "http://www.gtb.gov.tr//WebServices")]
            public BaseRequestMessageOf_UrunlerIstek BaseRequestMessageOf_UrunlerIstek { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Body Body { get; set; }
            [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Soap { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsd { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/GTB.HKS.Urun.ServiceContract")]
        public partial class UrunlerIstek
        {
        }
    }
}
