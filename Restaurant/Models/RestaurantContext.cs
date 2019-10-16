  
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class RestaurantContext : DbContext
  {
    public DbSet<Store> Stores { get; set; }

    public RestaurantContext(DbContextOptions options) : base(options) { }
  }
}