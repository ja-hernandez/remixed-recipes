using System;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Quantity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Quantity()
        {
        }
    }
}
