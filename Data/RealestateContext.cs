using Microsoft.EntityFrameworkCore;
using realestate.Models;

namespace realestate.Data
{
    public class RealestateContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=realestate.db");

        public RealestateContext(DbContextOptions options) : base(options)
        {
        }
    }
}