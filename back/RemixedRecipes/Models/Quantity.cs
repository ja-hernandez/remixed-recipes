using System;
namespace RemixedRecipes.Models
{
    public class Quantity
    {
        public int Id { get; set; }
        public string QuantityName { get; set; }
        public string QuantityDisplay { get; set; }

        public Quantity()
        {
        }
    }
}
