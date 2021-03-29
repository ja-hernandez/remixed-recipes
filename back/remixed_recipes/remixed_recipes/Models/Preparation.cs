using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Preparation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        public Preparation()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Preparation preparation &&
                   Id == preparation.Id &&
                   Description == preparation.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Description);
        }
    }
}
