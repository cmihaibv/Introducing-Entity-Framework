using IntroducingEntityFramework.Models;

using Microsoft.EntityFrameworkCore;

namespace IntroducingEntityFramework.Data;

public class IntroducingEntityFrameworkContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IntroducingEntityFrameworkDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");
    }

}
