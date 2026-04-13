namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class UploadRequest : NibrsRequestBase
{
    private string _fileBase64 = string.Empty;
    private List<byte> _file = new();

    public string FileName { get; set; } = string.Empty;
    public string FileBase64
    { 
        get
        {
            return _fileBase64;
        }
        set
        {
            _fileBase64 = value;
            _file = Convert.FromBase64String(value).ToList();
        }
    }
    public byte[] File
    {
        get
        {
            return _file.ToArray();
        }
        set
        {
            _file = value.ToList();
            _fileBase64 = Convert.ToBase64String(value);
        }
    }
    public string RequestBody
    {
        get
        {
            return 
@$"<s:Envelope xmlns:a=""http://schemas.microsoft.com/ws/2005/05/addressing/none""
            xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/""
            xmlns:h=""http://www.otech.com/SwifthRepository/SwiftUpload"">
  <s:Header>
    <h:SwiftUploadCredentials>
      <h:UserName>{UserName}</h:UserName>
      <h:Password>{Password}</h:Password>
    </h:SwiftUploadCredentials>
  </s:Header>
  <s:Body>
    <h:UploadRequest>
      <h:FileName>{FileName}</h:FileName>
      <h:File>{FileBase64}</h:File>
    </h:UploadRequest>
  </s:Body>
</s:Envelope>";
        }
    }
    public UploadRequest()
    {
        _headers.Add("SOAPAction", "http://www.otech.com/SwifthRepository/SwiftUpload/SwiftUpload/Upload");
    }    
}