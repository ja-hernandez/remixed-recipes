using System;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Instructions Instructions { get; set; }

        public Recipe()
        {
        }
    }
}
