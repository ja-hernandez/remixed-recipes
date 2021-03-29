using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using remixed_recipes.Models;

namespace remixed_recipes.Data
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
            .HasKey(ri => new { ri.RecipeId, ri.IngredientId });


        }
    }


}