using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using remixed_recipes.Models;
using remixed_recipes.Services;

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

        public UserService _userService;
        public string _currentAccount;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
            .HasKey(ri => new { ri.RecipeId, ri.IngredientId });


        }

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    _currentAccount = _userService.GetNameIdentifier();
        //    var account = await Accounts.SingleAsync(x => x.Email == _currentAccount);

        //    AddCreateInfo(account);

        //    return (await base.SaveChangesAsync(true, cancellationToken));
        //}

        //public override int SaveChanges()
        //{
        //    _currentAccount = _userService.GetNameIdentifier();
        //    var account = Accounts.Single(x => x.Email == _currentAccount);

        //    AddCreateInfo(account);

        //    return base.SaveChanges();
        //}

        public void AddCreateInfo(Account account)
        {
            foreach (var changedEntity in ChangeTracker.Entries())
            {
                if (changedEntity.Entity is BaseEntity entity && changedEntity.State == EntityState.Added)
                {
                    entity.CreatedDate = DateTime.UtcNow;
                    entity.CreatedBy = account;
                }
            }
        }
    }
}