using System;
using System.Collections.Generic;
using remixed_recipes.Models;

namespace remixed_recipes.Services.RecipeServices
{
    public interface IRecipeService
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        List<Recipe> Add(Recipe newRecipe);
    }
}
