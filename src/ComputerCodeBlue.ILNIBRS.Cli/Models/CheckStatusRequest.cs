using System.Net;
using System.Net.Http.Headers;

namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class CheckStatusRequest : NibrsRequestBase
{
    public int SubmissionId { get; set; }

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
    <h:CheckStatusRequest>
      <h:SubmissionID>{SubmissionId}</h:SubmissionID>
    </h:CheckStatusRequest>
  </s:Body>
</s:Envelope>";
        }
    }

    public CheckStatusRequest()
    {
        _headers.Add("SOAPAction", "http://www.otech.com/SwifthRepository/SwiftUpload/SwiftUpload/CheckStatus");
    }
}