using HeatCalc.Data.Models.Architect;
using HeatCalc.Data.Models.Building;
using HeatCalc.Data.Models.Heat;
using Microsoft.EntityFrameworkCore;
namespace HeatCalc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Corridor> Corridors { get; set; }
        public DbSet<Elevator> Elevators { get; set; }
        public DbSet<Parking> Parking { get; set; }
        public DbSet<SectionOld> Sections { get; set; }
        public DbSet<Staircase> Stairs { get; set; }

        public DbSet<Heat> Heats { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
