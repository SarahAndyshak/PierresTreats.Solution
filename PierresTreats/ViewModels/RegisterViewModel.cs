using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(nameof = "Email Address")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{6,}$", ErrorMessage = "Your password must contain at least six characters, a capital letter, a lowercase letter, a number, and a special character.")]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(nameof = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
  }
}