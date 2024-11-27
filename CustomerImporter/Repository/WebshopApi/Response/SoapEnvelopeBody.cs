using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class SoapEnvelopeBody
{
    [XmlElement(ElementName = "WebshopCustomerRequest",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public WebshopCustomerRequest Request { get; set; }

    [XmlElement(ElementName = "WebshopCustomerResponse",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public WebshopCustomerResponse Response { get; set; }

    [XmlElement(ElementName = "WebshopCustomerError",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public WebshopCustomerError Error { get; set; }
}