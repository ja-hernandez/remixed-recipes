using System;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Ingredient()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   Id == ingredient.Id &&
                   Name == ingredient.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}