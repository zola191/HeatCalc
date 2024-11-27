using HeatCalc.Data.Models.Architect;
using HeatCalc.Data.Models.Heat;
using Microsoft.EntityFrameworkCore;
namespace HeatCalc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }

        public DbSet<Heat> Heats { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
