using System;
using System.ComponentModel.DataAnnotations;

namespace RemixedRecipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; }

        public string RecipeName { get; set; }

        static private int nextId = 1;

        public Recipe(string name)
        {
            RecipeName = name;
            Id = nextId;
            nextId++;
        }
    }
}
