using System;
using System.Xml.Serialization;

namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

[XmlRoot("CheckStatusResponse", Namespace = "http://www.otech.com/SwifthRepository/SwiftUpload")]
public class CheckStatusResponse
{
    public string OperationStatusID { get; set; } = string.Empty;
    public string OperationStatusMessage { get; set; } = string.Empty;

    public string FileStatusID { get; set; } = string.Empty;
    public string FileStatusDescription { get; set; } = string.Empty;

    public int UnValidatedLinesOrNodes { get; set; }
    public int ValidLinesOrNodes { get; set; }
    public int InValidLinesOrNodes { get; set; }
    public int ValidButUnMigratedLinesOrNodes { get; set; }
    public int MigratedLinesOrNodes { get; set; }
    public int ErrorsInMigrationLinesOrNodes { get; set; }

    public string FileType { get; set; } = string.Empty;
    public string CurrentFileName { get; set; } = string.Empty;
    public string OriginalFileName { get; set; } = string.Empty;
}