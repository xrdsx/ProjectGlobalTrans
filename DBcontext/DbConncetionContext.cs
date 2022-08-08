using GlobalTrans.Models;
using Microsoft.EntityFrameworkCore;

namespace GlobalTrans.DBcontext
{
    public class DbConnectionContext : DbContext
    {
        public DbConnectionContext(DbContextOptions options) : base(options)
        {

        }

        
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Load> Load { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Road> Road { get; set; }
        public DbSet<RoadToDriver> RoadToDriver { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<RoadToDriver>().HasNoKey();
        }

    }
}
