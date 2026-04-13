namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class VerifyUploadRequest : UploadRequest
{
    public new string RequestBody
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
    <h:VerifyUploadRequest>
      <h:FileName>{FileName}</h:FileName>
      <h:File>{FileBase64}</h:File>
    </h:VerifyUploadRequest>
  </s:Body>
</s:Envelope>";
        }
    }    
    public VerifyUploadRequest()
    {
        _headers.Add("SOAPAction", "http://www.otech.com/SwifthRepository/SwiftUpload/SwiftUpload/VerifyUpload");
    }    
}