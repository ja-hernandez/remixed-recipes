using System;
using System.ComponentModel.DataAnnotations;

namespace RemixedRecipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public string RecipeName { get; set; }



    }
}
