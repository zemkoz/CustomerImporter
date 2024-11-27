using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "WebshopCustomerResponse",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class WebshopCustomerResponse
{
    [XmlElement(ElementName = "trackingInformation",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public TrackingInformation TrackingInformation { get; set; }

    [XmlElement(ElementName = "CRMCustomerData",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public CRMCustomerData CRMCustomerData { get; set; }
}
