using System;
using Microsoft.EntityFrameworkCore;
using RemixedRecipes.Models;

namespace RemixedRecipes.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredients> Ingredients { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}