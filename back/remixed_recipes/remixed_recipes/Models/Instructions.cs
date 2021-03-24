using System;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Instructions
    {
        [Key]
        public int Id { get; set; }
        public string InstructionsText { get; set; }
        public int RecipeId { get; set; }
        public Instructions()
        {
        }
    }
}
