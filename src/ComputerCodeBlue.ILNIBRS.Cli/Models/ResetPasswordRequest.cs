namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public class ResetPasswordRequest : NibrsRequestBase
{
    public string NewPassword { get; set; } = string.Empty;
    public ResetPasswordRequest()
    {
        _headers.Add("SOAPAction", "http://www.otech.com/SwifthRepository/SwiftUpload/SwiftUpload/ResetPassword");
    }    
}