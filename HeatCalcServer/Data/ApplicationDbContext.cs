using HeatCalcServer.Domain.Architect;
using HeatCalcServer.Domain.Heat;
using Microsoft.EntityFrameworkCore;

namespace HeatCalcServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Heat> Heats { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
