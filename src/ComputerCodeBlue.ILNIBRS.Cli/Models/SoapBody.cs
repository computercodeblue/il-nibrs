using System;
using System.Xml.Serialization;

namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class SoapBody
{
    [XmlElement("CheckStatusResponse", Namespace = "http://www.otech.com/SwifthRepository/SwiftUpload")]
    public CheckStatusResponse CheckStatusResponse { get; set; } = new();
}
