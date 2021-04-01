using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace remixed_recipes.Models
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }

        public Account CreatedBy { get; set; }
    }
}
