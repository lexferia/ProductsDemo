using Microsoft.EntityFrameworkCore;
using ProductsDemo.WebAPI.Entities;

namespace ProductsDemo.WebAPI.Data;

public class DemoDbContext : DbContext
{
    public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}
