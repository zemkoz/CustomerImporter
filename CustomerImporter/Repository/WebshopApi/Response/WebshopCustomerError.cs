using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "WebshopCustomerError",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class WebshopCustomerError
{
    [XmlElement(ElementName = "errorInformation",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public ErrorInformation ErrorInformation { get; set; }
}