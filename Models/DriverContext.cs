using Microsoft.EntityFrameworkCore;

namespace GlobalTrans.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Driver> Driver { get; set; }

    }
}
