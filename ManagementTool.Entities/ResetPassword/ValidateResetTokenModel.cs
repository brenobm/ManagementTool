using System.ComponentModel.DataAnnotations;

namespace ManagementTool.Entities.ResetPassword;

public class ValidateResetTokenModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Token { get; set; }
}
