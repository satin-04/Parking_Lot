using Microsoft.EntityFrameworkCore;
using Parking_Lot.Models;

namespace Parking_Lot.Data {
    public class AppDbContext : DbContext {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration) {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<User> User { get; set; }
    }

}

