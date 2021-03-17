using System;
namespace RemixedRecipes.Models
{
    public class RecipeIngredients
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int QuantityId { get; set; }
        public Quantity Quantity { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public int PreparationId { get; set; }
        public Preparation Preparation { get; set; }

        public RecipeIngredients()
        {
        }
    }
}
