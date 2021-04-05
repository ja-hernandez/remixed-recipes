using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Unit
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public Unit()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Unit unit &&
                   Id == unit.Id &&
                   Name == unit.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
