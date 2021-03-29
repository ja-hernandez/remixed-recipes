using System;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Instructions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string InstructionsText { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public Instructions()
        {
        }
    }
}
