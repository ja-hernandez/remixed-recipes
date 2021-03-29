using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}