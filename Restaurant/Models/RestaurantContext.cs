  
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class RestaurantContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Store> Stores { get; set; }
    

    public RestaurantContext(DbContextOptions options) : base(options) { }
  }
}