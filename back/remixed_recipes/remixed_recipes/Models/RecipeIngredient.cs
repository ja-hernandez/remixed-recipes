using System;
using System.Collections.Generic;

namespace remixed_recipes.Models
{
    public class RecipeIngredient
    {
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }

        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        public Quantity Quantity { get; set; }
        public int QuantityId { get; set; }

        public Unit Unit { get; set; }
        public int? UnitId { get; set; }

        public Preparation Preparation { get; set; }
        public int? PreparationId { get; set; }

        public RecipeIngredient()
        {
        }
    }
}
