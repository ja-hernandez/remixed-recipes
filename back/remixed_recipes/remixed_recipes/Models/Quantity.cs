using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Quantity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public Quantity()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Quantity quantity &&
                   Id == quantity.Id &&
                   Name == quantity.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
