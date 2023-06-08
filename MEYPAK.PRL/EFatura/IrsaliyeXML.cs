using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.EFatura
{
    internal class IrsaliyeXML
    {

        // NOT: Oluşturulan kod en az .NET Framework 4.5 veya.NET Core/Standard 2.0 gerektirebilir.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", IsNullable = false)]
        public partial class DespatchAdvice
        {

            private UBLExtensions uBLExtensionsField;

            private decimal uBLVersionIDField;

            private string customizationIDField;

            private string profileIDField;

            private ID idField;

            private bool copyIndicatorField;

            private string uUIDField;

            private System.DateTime issueDateField;

            private System.DateTime issueTimeField;

            private string despatchAdviceTypeCodeField;

            private string noteField;

            private OrderReference orderReferenceField;

            private AdditionalDocumentReference[] additionalDocumentReferenceField;

            private Signature signatureField;

            private DespatchSupplierParty despatchSupplierPartyField;

            private DeliveryCustomerParty deliveryCustomerPartyField;

            private Shipment shipmentField;

            private List<DespatchLine> despatchLineField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
            public UBLExtensions UBLExtensions
            {
                get
                {
                    return this.uBLExtensionsField;
                }
                set
                {
                    this.uBLExtensionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public decimal UBLVersionID
            {
                get
                {
                    return this.uBLVersionIDField;
                }
                set
                {
                    this.uBLVersionIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CustomizationID
            {
                get
                {
                    return this.customizationIDField;
                }
                set
                {
                    this.customizationIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string ProfileID
            {
                get
                {
                    return this.profileIDField;
                }
                set
                {
                    this.profileIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public bool CopyIndicator
            {
                get
                {
                    return this.copyIndicatorField;
                }
                set
                {
                    this.copyIndicatorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string UUID
            {
                get
                {
                    return this.uUIDField;
                }
                set
                {
                    this.uUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
            public System.DateTime IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "time")]
            public System.DateTime IssueTime
            {
                get
                {
                    return this.issueTimeField;
                }
                set
                {
                    this.issueTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string DespatchAdviceTypeCode
            {
                get
                {
                    return this.despatchAdviceTypeCodeField;
                }
                set
                {
                    this.despatchAdviceTypeCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Note
            {
                get
                {
                    return this.noteField;
                }
                set
                {
                    this.noteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public OrderReference OrderReference
            {
                get
                {
                    return this.orderReferenceField;
                }
                set
                {
                    this.orderReferenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public AdditionalDocumentReference[] AdditionalDocumentReference
            {
                get
                {
                    return this.additionalDocumentReferenceField;
                }
                set
                {
                    this.additionalDocumentReferenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public Signature Signature
            {
                get
                {
                    return this.signatureField;
                }
                set
                {
                    this.signatureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public DespatchSupplierParty DespatchSupplierParty
            {
                get
                {
                    return this.despatchSupplierPartyField;
                }
                set
                {
                    this.despatchSupplierPartyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public DeliveryCustomerParty DeliveryCustomerParty
            {
                get
                {
                    return this.deliveryCustomerPartyField;
                }
                set
                {
                    this.deliveryCustomerPartyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public Shipment Shipment
            {
                get
                {
                    return this.shipmentField;
                }
                set
                {
                    this.shipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
            public List<DespatchLine> DespatchLine
            {
                get
                {
                    return this.despatchLineField;
                }
                set
                {
                    this.despatchLineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
        public partial class UBLExtensions
        {

            private UBLExtensionsUBLExtension uBLExtensionField;

            /// <remarks/>
            public UBLExtensionsUBLExtension UBLExtension
            {
                get
                {
                    return this.uBLExtensionField;
                }
                set
                {
                    this.uBLExtensionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public partial class UBLExtensionsUBLExtension
        {

            private UBLExtensionsUBLExtensionExtensionContent extensionContentField;

            /// <remarks/>
            public UBLExtensionsUBLExtensionExtensionContent ExtensionContent
            {
                get
                {
                    return this.extensionContentField;
                }
                set
                {
                    this.extensionContentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public partial class UBLExtensionsUBLExtensionExtensionContent
        {

            private object autogenerated_for_wildcardField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("auto-generated_for_wildcard", Namespace = "http://www.altova.com/samplexml/other-namespace")]
            public object autogenerated_for_wildcard
            {
                get
                {
                    return this.autogenerated_for_wildcardField;
                }
                set
                {
                    this.autogenerated_for_wildcardField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class ID
        {

            private string schemeIDField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemeID
            {
                get
                {
                    return this.schemeIDField;
                }
                set
                {
                    this.schemeIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class OrderReference
        {

            private ID idField;

            private System.DateTime issueDateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
            public System.DateTime IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class AdditionalDocumentReference
        {

            private ID idField;

            private System.DateTime issueDateField;

            private string documentTypeField;

            private string documentDescriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
            public System.DateTime IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string DocumentType
            {
                get
                {
                    return this.documentTypeField;
                }
                set
                {
                    this.documentTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string DocumentDescription
            {
                get
                {
                    return this.documentDescriptionField;
                }
                set
                {
                    this.documentDescriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class Signature
        {

            private ID idField;

            private SignatureSignatoryParty signatoryPartyField;

            private SignatureDigitalSignatureAttachment digitalSignatureAttachmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public SignatureSignatoryParty SignatoryParty
            {
                get
                {
                    return this.signatoryPartyField;
                }
                set
                {
                    this.signatoryPartyField = value;
                }
            }

            /// <remarks/>
            public SignatureDigitalSignatureAttachment DigitalSignatureAttachment
            {
                get
                {
                    return this.digitalSignatureAttachmentField;
                }
                set
                {
                    this.digitalSignatureAttachmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureSignatoryParty
        {

            private SignatureSignatoryPartyPartyIdentification partyIdentificationField;

            private SignatureSignatoryPartyPostalAddress postalAddressField;

            /// <remarks/>
            public SignatureSignatoryPartyPartyIdentification PartyIdentification
            {
                get
                {
                    return this.partyIdentificationField;
                }
                set
                {
                    this.partyIdentificationField = value;
                }
            }

            /// <remarks/>
            public SignatureSignatoryPartyPostalAddress PostalAddress
            {
                get
                {
                    return this.postalAddressField;
                }
                set
                {
                    this.postalAddressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureSignatoryPartyPartyIdentification
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureSignatoryPartyPostalAddress
        {

            private string streetNameField;

            private string buildingNumberField;

            private string citySubdivisionNameField;

            private string cityNameField;

            private ushort postalZoneField;

            private SignatureSignatoryPartyPostalAddressCountry countryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string StreetName
            {
                get
                {
                    return this.streetNameField;
                }
                set
                {
                    this.streetNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string BuildingNumber
            {
                get
                {
                    return this.buildingNumberField;
                }
                set
                {
                    this.buildingNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CitySubdivisionName
            {
                get
                {
                    return this.citySubdivisionNameField;
                }
                set
                {
                    this.citySubdivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CityName
            {
                get
                {
                    return this.cityNameField;
                }
                set
                {
                    this.cityNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ushort PostalZone
            {
                get
                {
                    return this.postalZoneField;
                }
                set
                {
                    this.postalZoneField = value;
                }
            }

            /// <remarks/>
            public SignatureSignatoryPartyPostalAddressCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureSignatoryPartyPostalAddressCountry
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureDigitalSignatureAttachment
        {

            private SignatureDigitalSignatureAttachmentExternalReference externalReferenceField;

            /// <remarks/>
            public SignatureDigitalSignatureAttachmentExternalReference ExternalReference
            {
                get
                {
                    return this.externalReferenceField;
                }
                set
                {
                    this.externalReferenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class SignatureDigitalSignatureAttachmentExternalReference
        {

            private string uRIField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string URI
            {
                get
                {
                    return this.uRIField;
                }
                set
                {
                    this.uRIField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class DespatchSupplierParty
        {

            private DespatchSupplierPartyParty partyField;

            private DespatchSupplierPartyDespatchContact despatchContactField;

            /// <remarks/>
            public DespatchSupplierPartyParty Party
            {
                get
                {
                    return this.partyField;
                }
                set
                {
                    this.partyField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyDespatchContact DespatchContact
            {
                get
                {
                    return this.despatchContactField;
                }
                set
                {
                    this.despatchContactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyParty
        {

            private string websiteURIField;

            private DespatchSupplierPartyPartyPartyIdentification partyIdentificationField;

            private DespatchSupplierPartyPartyPartyName partyNameField;

            private DespatchSupplierPartyPartyPostalAddress postalAddressField;

            private DespatchSupplierPartyPartyPhysicalLocation physicalLocationField;

            private DespatchSupplierPartyPartyPartyTaxScheme partyTaxSchemeField;

            private DespatchSupplierPartyPartyContact contactField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string WebsiteURI
            {
                get
                {
                    return this.websiteURIField;
                }
                set
                {
                    this.websiteURIField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPartyIdentification PartyIdentification
            {
                get
                {
                    return this.partyIdentificationField;
                }
                set
                {
                    this.partyIdentificationField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPartyName PartyName
            {
                get
                {
                    return this.partyNameField;
                }
                set
                {
                    this.partyNameField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPostalAddress PostalAddress
            {
                get
                {
                    return this.postalAddressField;
                }
                set
                {
                    this.postalAddressField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPhysicalLocation PhysicalLocation
            {
                get
                {
                    return this.physicalLocationField;
                }
                set
                {
                    this.physicalLocationField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPartyTaxScheme PartyTaxScheme
            {
                get
                {
                    return this.partyTaxSchemeField;
                }
                set
                {
                    this.partyTaxSchemeField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPartyIdentification
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPartyName
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPostalAddress
        {

            private ID idField;

            private string streetNameField;

            private string buildingNumberField;

            private string citySubdivisionNameField;

            private string cityNameField;

            private ushort postalZoneField;

            private DespatchSupplierPartyPartyPostalAddressCountry countryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string StreetName
            {
                get
                {
                    return this.streetNameField;
                }
                set
                {
                    this.streetNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string BuildingNumber
            {
                get
                {
                    return this.buildingNumberField;
                }
                set
                {
                    this.buildingNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CitySubdivisionName
            {
                get
                {
                    return this.citySubdivisionNameField;
                }
                set
                {
                    this.citySubdivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CityName
            {
                get
                {
                    return this.cityNameField;
                }
                set
                {
                    this.cityNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ushort PostalZone
            {
                get
                {
                    return this.postalZoneField;
                }
                set
                {
                    this.postalZoneField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPostalAddressCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPostalAddressCountry
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPhysicalLocation
        {

            private ID idField;

            private DespatchSupplierPartyPartyPhysicalLocationAddress addressField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPhysicalLocationAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPhysicalLocationAddress
        {

            private ID idField;

            private string streetNameField;

            private string buildingNumberField;

            private string citySubdivisionNameField;

            private string cityNameField;

            private ushort postalZoneField;

            private DespatchSupplierPartyPartyPhysicalLocationAddressCountry countryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string StreetName
            {
                get
                {
                    return this.streetNameField;
                }
                set
                {
                    this.streetNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string BuildingNumber
            {
                get
                {
                    return this.buildingNumberField;
                }
                set
                {
                    this.buildingNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CitySubdivisionName
            {
                get
                {
                    return this.citySubdivisionNameField;
                }
                set
                {
                    this.citySubdivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CityName
            {
                get
                {
                    return this.cityNameField;
                }
                set
                {
                    this.cityNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ushort PostalZone
            {
                get
                {
                    return this.postalZoneField;
                }
                set
                {
                    this.postalZoneField = value;
                }
            }

            /// <remarks/>
            public DespatchSupplierPartyPartyPhysicalLocationAddressCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPhysicalLocationAddressCountry
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPartyTaxScheme
        {

            private DespatchSupplierPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

            /// <remarks/>
            public DespatchSupplierPartyPartyPartyTaxSchemeTaxScheme TaxScheme
            {
                get
                {
                    return this.taxSchemeField;
                }
                set
                {
                    this.taxSchemeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyPartyTaxSchemeTaxScheme
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyPartyContact
        {

            private string telephoneField;

            private string telefaxField;

            private string electronicMailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Telephone
            {
                get
                {
                    return this.telephoneField;
                }
                set
                {
                    this.telephoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Telefax
            {
                get
                {
                    return this.telefaxField;
                }
                set
                {
                    this.telefaxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string ElectronicMail
            {
                get
                {
                    return this.electronicMailField;
                }
                set
                {
                    this.electronicMailField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchSupplierPartyDespatchContact
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class DeliveryCustomerParty
        {

            private DeliveryCustomerPartyParty partyField;

            /// <remarks/>
            public DeliveryCustomerPartyParty Party
            {
                get
                {
                    return this.partyField;
                }
                set
                {
                    this.partyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyParty
        {

            private string websiteURIField;

            private DeliveryCustomerPartyPartyPartyIdentification[] partyIdentificationField;

            private DeliveryCustomerPartyPartyPartyName partyNameField;

            private DeliveryCustomerPartyPartyPostalAddress postalAddressField;

            private DeliveryCustomerPartyPartyPartyTaxScheme partyTaxSchemeField;

            private DeliveryCustomerPartyPartyContact contactField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string WebsiteURI
            {
                get
                {
                    return this.websiteURIField;
                }
                set
                {
                    this.websiteURIField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
            public DeliveryCustomerPartyPartyPartyIdentification[] PartyIdentification
            {
                get
                {
                    return this.partyIdentificationField;
                }
                set
                {
                    this.partyIdentificationField = value;
                }
            }

            /// <remarks/>
            public DeliveryCustomerPartyPartyPartyName PartyName
            {
                get
                {
                    return this.partyNameField;
                }
                set
                {
                    this.partyNameField = value;
                }
            }

            /// <remarks/>
            public DeliveryCustomerPartyPartyPostalAddress PostalAddress
            {
                get
                {
                    return this.postalAddressField;
                }
                set
                {
                    this.postalAddressField = value;
                }
            }

            /// <remarks/>
            public DeliveryCustomerPartyPartyPartyTaxScheme PartyTaxScheme
            {
                get
                {
                    return this.partyTaxSchemeField;
                }
                set
                {
                    this.partyTaxSchemeField = value;
                }
            }

            /// <remarks/>
            public DeliveryCustomerPartyPartyContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPartyIdentification
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPartyName
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPostalAddress
        {

            private ID idField;

            private string streetNameField;

            private string buildingNumberField;

            private string citySubdivisionNameField;

            private string cityNameField;

            private ushort postalZoneField;

            private DeliveryCustomerPartyPartyPostalAddressCountry countryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string StreetName
            {
                get
                {
                    return this.streetNameField;
                }
                set
                {
                    this.streetNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string BuildingNumber
            {
                get
                {
                    return this.buildingNumberField;
                }
                set
                {
                    this.buildingNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CitySubdivisionName
            {
                get
                {
                    return this.citySubdivisionNameField;
                }
                set
                {
                    this.citySubdivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CityName
            {
                get
                {
                    return this.cityNameField;
                }
                set
                {
                    this.cityNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ushort PostalZone
            {
                get
                {
                    return this.postalZoneField;
                }
                set
                {
                    this.postalZoneField = value;
                }
            }

            /// <remarks/>
            public DeliveryCustomerPartyPartyPostalAddressCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPostalAddressCountry
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPartyTaxScheme
        {

            private DeliveryCustomerPartyPartyPartyTaxSchemeTaxScheme taxSchemeField;

            /// <remarks/>
            public DeliveryCustomerPartyPartyPartyTaxSchemeTaxScheme TaxScheme
            {
                get
                {
                    return this.taxSchemeField;
                }
                set
                {
                    this.taxSchemeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyPartyTaxSchemeTaxScheme
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DeliveryCustomerPartyPartyContact
        {

            private string telephoneField;

            private string telefaxField;

            private string electronicMailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Telephone
            {
                get
                {
                    return this.telephoneField;
                }
                set
                {
                    this.telephoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Telefax
            {
                get
                {
                    return this.telefaxField;
                }
                set
                {
                    this.telefaxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string ElectronicMail
            {
                get
                {
                    return this.electronicMailField;
                }
                set
                {
                    this.electronicMailField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class Shipment
        {

            private ID idField;

            private ShipmentGoodsItem goodsItemField;

            private ShipmentShipmentStage shipmentStageField;

            private ShipmentDelivery deliveryField;

            private ShipmentTransportEquipment[] transportHandlingUnitField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public ShipmentGoodsItem GoodsItem
            {
                get
                {
                    return this.goodsItemField;
                }
                set
                {
                    this.goodsItemField = value;
                }
            }

            /// <remarks/>
            public ShipmentShipmentStage ShipmentStage
            {
                get
                {
                    return this.shipmentStageField;
                }
                set
                {
                    this.shipmentStageField = value;
                }
            }

            /// <remarks/>
            public ShipmentDelivery Delivery
            {
                get
                {
                    return this.deliveryField;
                }
                set
                {
                    this.deliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("TransportEquipment", IsNullable = false)]
            public ShipmentTransportEquipment[] TransportHandlingUnit
            {
                get
                {
                    return this.transportHandlingUnitField;
                }
                set
                {
                    this.transportHandlingUnitField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentGoodsItem
        {

            private ValueAmount valueAmountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ValueAmount ValueAmount
            {
                get
                {
                    return this.valueAmountField;
                }
                set
                {
                    this.valueAmountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class ValueAmount
        {

            private string currencyIDField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currencyID
            {
                get
                {
                    return this.currencyIDField;
                }
                set
                {
                    this.currencyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentShipmentStage
        {

            private ShipmentShipmentStageTransportMeans transportMeansField;

            private ShipmentShipmentStageDriverPerson[] driverPersonField;

            /// <remarks/>
            public ShipmentShipmentStageTransportMeans TransportMeans
            {
                get
                {
                    return this.transportMeansField;
                }
                set
                {
                    this.transportMeansField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DriverPerson")]
            public ShipmentShipmentStageDriverPerson[] DriverPerson
            {
                get
                {
                    return this.driverPersonField;
                }
                set
                {
                    this.driverPersonField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentShipmentStageTransportMeans
        {

            private ShipmentShipmentStageTransportMeansRoadTransport roadTransportField;

            /// <remarks/>
            public ShipmentShipmentStageTransportMeansRoadTransport RoadTransport
            {
                get
                {
                    return this.roadTransportField;
                }
                set
                {
                    this.roadTransportField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentShipmentStageTransportMeansRoadTransport
        {

            private LicensePlateID licensePlateIDField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public LicensePlateID LicensePlateID
            {
                get
                {
                    return this.licensePlateIDField;
                }
                set
                {
                    this.licensePlateIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class LicensePlateID
        {

            private string schemeIDField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string schemeID
            {
                get
                {
                    return this.schemeIDField;
                }
                set
                {
                    this.schemeIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentShipmentStageDriverPerson
        {

            private string firstNameField;

            private string familyNameField;

            private string titleField;

            private ulong nationalityIDField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string FamilyName
            {
                get
                {
                    return this.familyNameField;
                }
                set
                {
                    this.familyNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ulong NationalityID
            {
                get
                {
                    return this.nationalityIDField;
                }
                set
                {
                    this.nationalityIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDelivery
        {

            private ShipmentDeliveryCarrierParty carrierPartyField;

            private ShipmentDeliveryDespatch despatchField;

            /// <remarks/>
            public ShipmentDeliveryCarrierParty CarrierParty
            {
                get
                {
                    return this.carrierPartyField;
                }
                set
                {
                    this.carrierPartyField = value;
                }
            }

            /// <remarks/>
            public ShipmentDeliveryDespatch Despatch
            {
                get
                {
                    return this.despatchField;
                }
                set
                {
                    this.despatchField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryCarrierParty
        {

            private ShipmentDeliveryCarrierPartyPartyIdentification partyIdentificationField;

            private ShipmentDeliveryCarrierPartyPartyName partyNameField;

            private ShipmentDeliveryCarrierPartyPostalAddress postalAddressField;

            /// <remarks/>
            public ShipmentDeliveryCarrierPartyPartyIdentification PartyIdentification
            {
                get
                {
                    return this.partyIdentificationField;
                }
                set
                {
                    this.partyIdentificationField = value;
                }
            }

            /// <remarks/>
            public ShipmentDeliveryCarrierPartyPartyName PartyName
            {
                get
                {
                    return this.partyNameField;
                }
                set
                {
                    this.partyNameField = value;
                }
            }

            /// <remarks/>
            public ShipmentDeliveryCarrierPartyPostalAddress PostalAddress
            {
                get
                {
                    return this.postalAddressField;
                }
                set
                {
                    this.postalAddressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryCarrierPartyPartyIdentification
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryCarrierPartyPartyName
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryCarrierPartyPostalAddress
        {

            private string citySubdivisionNameField;

            private string cityNameField;

            private ShipmentDeliveryCarrierPartyPostalAddressCountry countryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CitySubdivisionName
            {
                get
                {
                    return this.citySubdivisionNameField;
                }
                set
                {
                    this.citySubdivisionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string CityName
            {
                get
                {
                    return this.cityNameField;
                }
                set
                {
                    this.cityNameField = value;
                }
            }

            /// <remarks/>
            public ShipmentDeliveryCarrierPartyPostalAddressCountry Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryCarrierPartyPostalAddressCountry
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentDeliveryDespatch
        {

            private System.DateTime actualDespatchDateField;

            private System.DateTime actualDespatchTimeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "date")]
            public System.DateTime ActualDespatchDate
            {
                get
                {
                    return this.actualDespatchDateField;
                }
                set
                {
                    this.actualDespatchDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", DataType = "time")]
            public System.DateTime ActualDespatchTime
            {
                get
                {
                    return this.actualDespatchTimeField;
                }
                set
                {
                    this.actualDespatchTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class ShipmentTransportEquipment
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public partial class DespatchLine
        {

            private ID idField;

            private DeliveredQuantity deliveredQuantityField;

            private DespatchLineOrderLineReference orderLineReferenceField;

            private DespatchLineItem itemField;

            private DespatchLineShipment shipmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public DeliveredQuantity DeliveredQuantity
            {
                get
                {
                    return this.deliveredQuantityField;
                }
                set
                {
                    this.deliveredQuantityField = value;
                }
            }

            /// <remarks/>
            public DespatchLineOrderLineReference OrderLineReference
            {
                get
                {
                    return this.orderLineReferenceField;
                }
                set
                {
                    this.orderLineReferenceField = value;
                }
            }

            /// <remarks/>
            public DespatchLineItem Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            public DespatchLineShipment Shipment
            {
                get
                {
                    return this.shipmentField;
                }
                set
                {
                    this.shipmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class DeliveredQuantity
        {

            private string unitCodeField;

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string unitCode
            {
                get
                {
                    return this.unitCodeField;
                }
                set
                {
                    this.unitCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineOrderLineReference
        {

            private byte lineIDField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public byte LineID
            {
                get
                {
                    return this.lineIDField;
                }
                set
                {
                    this.lineIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineItem
        {

            private string nameField;

            private DespatchLineItemSellersItemIdentification sellersItemIdentificationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public DespatchLineItemSellersItemIdentification SellersItemIdentification
            {
                get
                {
                    return this.sellersItemIdentificationField;
                }
                set
                {
                    this.sellersItemIdentificationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineItemSellersItemIdentification
        {

            private ID idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineShipment
        {

            private ID idField;

            private DespatchLineShipmentGoodsItem goodsItemField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public DespatchLineShipmentGoodsItem GoodsItem
            {
                get
                {
                    return this.goodsItemField;
                }
                set
                {
                    this.goodsItemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineShipmentGoodsItem
        {

            private DespatchLineShipmentGoodsItemInvoiceLine invoiceLineField;

            /// <remarks/>
            public DespatchLineShipmentGoodsItemInvoiceLine InvoiceLine
            {
                get
                {
                    return this.invoiceLineField;
                }
                set
                {
                    this.invoiceLineField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineShipmentGoodsItemInvoiceLine
        {

            private ID idField;

            private byte invoicedQuantityField;

            private LineExtensionAmount lineExtensionAmountField;

            private DespatchLineShipmentGoodsItemInvoiceLineItem itemField;

            private DespatchLineShipmentGoodsItemInvoiceLinePrice priceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public ID ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public byte InvoicedQuantity
            {
                get
                {
                    return this.invoicedQuantityField;
                }
                set
                {
                    this.invoicedQuantityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public LineExtensionAmount LineExtensionAmount
            {
                get
                {
                    return this.lineExtensionAmountField;
                }
                set
                {
                    this.lineExtensionAmountField = value;
                }
            }

            /// <remarks/>
            public DespatchLineShipmentGoodsItemInvoiceLineItem Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            public DespatchLineShipmentGoodsItemInvoiceLinePrice Price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class LineExtensionAmount
        {

            private string currencyIDField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currencyID
            {
                get
                {
                    return this.currencyIDField;
                }
                set
                {
                    this.currencyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineShipmentGoodsItemInvoiceLineItem
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public partial class DespatchLineShipmentGoodsItemInvoiceLinePrice
        {

            private PriceAmount priceAmountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
            public PriceAmount PriceAmount
            {
                get
                {
                    return this.priceAmountField;
                }
                set
                {
                    this.priceAmountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
        public partial class PriceAmount
        {

            private string currencyIDField;

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currencyID
            {
                get
                {
                    return this.currencyIDField;
                }
                set
                {
                    this.currencyIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }


    }
}
