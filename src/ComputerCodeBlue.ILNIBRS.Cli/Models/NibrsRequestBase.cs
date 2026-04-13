using System.Net.Http.Headers;

namespace ComputerCodeBlue.ILNIBRS.Cli.Models;

public abstract class NibrsRequestBase
{
    protected Dictionary<string, string> _headers = new();
    public string UserName {get; set; } = string.Empty;
    public string Password {get; set; } = string.Empty;
}