using System.ComponentModel.DataAnnotations;

namespace C__MVCPrac.Models;

public class Account
{
    [Required]
    [MinLength(5)]
    [MaxLength(15)]
    public string Username { get; set; }

    [Required]
    [MinLength(8)]
    [MaxLength(15)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Range(18,60)]
    public int? Age { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Url]
    public string? Website { get; set; }

    public Account()
    {
        Username = string.Empty;
    }
}
