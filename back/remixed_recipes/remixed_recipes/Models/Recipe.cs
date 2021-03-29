using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Instructions Instructions { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public Recipe()
        {
        }
    }
}
