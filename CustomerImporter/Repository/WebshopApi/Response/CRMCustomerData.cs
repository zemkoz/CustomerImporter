using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "CRMCustomerData",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class CRMCustomerData
{
    [XmlElement(ElementName = "Customer",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public List<CRMCustomer> Customers { get; set; }
}