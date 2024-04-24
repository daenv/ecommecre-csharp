using Microsoft.EntityFrameworkCore;

namespace Ecommerce_CSharp.Data;

public class ApplicationDbContext : DbContext

{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Electronics",
                Description = "Electronic Items"
            },
            new Category
            {
                Id = 2,
                Name = "Clothes",
                Description = "Dresses"
            }
        );
    }
}