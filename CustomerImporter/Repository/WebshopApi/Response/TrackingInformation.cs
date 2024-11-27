using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "trackingInformation",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class TrackingInformation
{
    [XmlElement(ElementName = "eventLocalId",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/TrackingInformation-1.0")]
    public string EventLocalId { get; set; }

    [XmlElement(ElementName = "applicationId",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/TrackingInformation-1.0")]
    public string ApplicationId { get; set; }

    [XmlElement(ElementName = "timeout",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/TrackingInformation-1.0")]
    public string Timeout { get; set; }

    [XmlElement(ElementName = "requester",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/TrackingInformation-1.0")]
    public string Requester { get; set; }
}