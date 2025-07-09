using Microsoft.Net.Http.Headers;

namespace C__MVCPrac.Models;

public class LoginViewModel
{
    public string Username { get; set; }

    public string? Password { get; set; }

    public LoginViewModel()
    {
        Username = string.Empty;
    }
}
