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


    }
}
