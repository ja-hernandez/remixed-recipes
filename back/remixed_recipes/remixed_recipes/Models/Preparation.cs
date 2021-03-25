using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace remixed_recipes.Models
{
    public class Preparation
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public Preparation()
        {
        }
    }
}
