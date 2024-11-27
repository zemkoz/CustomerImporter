using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "Customer",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class CRMCustomer
{
    [XmlElement(ElementName = "Title",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string Title { get; set; }

    [XmlElement(ElementName = "Salutation",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string Salutation { get; set; }

    [XmlElement(ElementName = "PersonID",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string PersonID { get; set; }

    [XmlElement(ElementName = "FirstName",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string FirstName { get; set; }

    [XmlElement(ElementName = "MiddleInitial",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string MiddleInitial { get; set; }

    [XmlElement(ElementName = "LastName",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string LastName { get; set; }

    [XmlElement(ElementName = "EMail",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string EMail { get; set; }

    [XmlElement(ElementName = "Company",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string Company { get; set; }

    [XmlElement(ElementName = "CompanyID",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string CompanyID { get; set; }

    [XmlElement(ElementName = "SAPID",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string SapId { get; set; }

    [XmlElement(ElementName = "Status",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
    public string Status { get; set; }
}