using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}