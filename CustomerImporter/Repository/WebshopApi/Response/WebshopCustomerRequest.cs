using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "WebshopCustomerRequest",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class WebshopCustomerRequest
{
    [XmlElement(ElementName = "trackingInformation",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public TrackingInformation TrackingInformation { get; set; }

    [XmlElement(ElementName = "EMail",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string EMail { get; set; }
}
