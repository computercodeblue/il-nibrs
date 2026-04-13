namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class ChangePasswordRequest : NibrsRequestBase
{
    public string NewPassword { get; set; } = string.Empty;

    public ChangePasswordRequest()
    {
        _headers.Add("SOAPAction", "http://www.otech.com/SwifthRepository/SwiftUpload/SwiftUpload/ResetPassword");
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
    <h:ChangePasswordRequest>
      <h:NewPassword>{NewPassword}</h:NewPassword>
    </h:ChangePasswordRequest>
  </s:Body>
</s:Envelope>";
        }
    }        
}