using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "errorInformation",
    Namespace = "http://app.hartmann.info/CatalogServices/Schemas/GetWebshopCustomer/1.0")]
public class ErrorInformation
{
    [XmlElement(ElementName = "domain",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string Domain { get; set; }

    [XmlElement(ElementName = "errorPrefix",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string ErrorPrefix { get; set; }

    [XmlElement(ElementName = "msgCode",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string MsgCode { get; set; }

    [XmlElement(ElementName = "timestampOrigin",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string TimestampOrigin { get; set; }

    [XmlElement(ElementName = "classification",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string Classification { get; set; }

    [XmlElement(ElementName = "message",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string Message { get; set; }

    [XmlElement(ElementName = "exceptionClass",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string ExceptionClass { get; set; }

    [XmlElement(ElementName = "description",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string Description { get; set; }

    [XmlElement(ElementName = "processContext",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string ProcessContext { get; set; }

    [XmlElement(ElementName = "payloadOrigin",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string PayloadOrigin { get; set; }

    [XmlElement(ElementName = "payloadCurrentIn",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string PayloadCurrentIn { get; set; }

    [XmlElement(ElementName = "payloadCurrentOut",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string PayloadCurrentOut { get; set; }

    [XmlElement(ElementName = "errorContext",
        Namespace = "http://app.hartmann.info/CatalogServices/Schemas/ErrorInformation-1.0")]
    public string ErrorContext { get; set; }
}