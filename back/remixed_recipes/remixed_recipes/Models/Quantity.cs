using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Quantity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public Quantity()
        {
        }
    }
}
