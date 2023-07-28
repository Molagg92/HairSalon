using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    // public DbSet<Cuisine> Cuisines { get; set; }

    //  public DbSet<Restaurant> Restaurants { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}