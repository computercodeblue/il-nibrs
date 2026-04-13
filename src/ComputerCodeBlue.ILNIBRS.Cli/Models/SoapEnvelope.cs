using System;
using System.Xml.Serialization;

namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

[XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class SoapEnvelope
{
    [XmlElement("Body")]
    public SoapBody Body { get; set; } = new();
}