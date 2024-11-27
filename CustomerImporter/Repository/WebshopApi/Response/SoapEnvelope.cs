using System.Xml.Serialization;

namespace CustomerImporter.Soap.Response;

[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class SoapEnvelope
{
    [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public string Header { get; set; }

    [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public SoapEnvelopeBody Body { get; set; }

    [XmlAttribute(AttributeName = "xmlns")]
    public string Xmlns { get; set; }

    [XmlAttribute(AttributeName = "ns", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string Ns { get; set; }

    [XmlAttribute(AttributeName = "ns1", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string Ns1 { get; set; }

    [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string Ns2 { get; set; }
}