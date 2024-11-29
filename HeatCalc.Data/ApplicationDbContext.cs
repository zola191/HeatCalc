using HeatCalc.Data.Models.Architect;
using HeatCalc.Data.Models.Heat;
using Microsoft.EntityFrameworkCore;

namespace HeatCalc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Corridor> Corridors { get; set; }
        public DbSet<Staircase> Staircases { get; set; }
        public DbSet<Elevator> Elevators { get; set; }
        //public DbSet<SectionCorridor> SectionCorridors { get; set; }
        //public DbSet<SectionElevator> SectionElevators { get; set; }
        //public DbSet<SectionStaircase> SectionStaircases { get; set; }
        //public DbSet<ParkingElevator> ParkingElevators { get; set; }

        public DbSet<Heat> Heats { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(option =>
            {
                option.HasKey(f => f.Id);

                option.Property(f => f.Name).IsRequired();
                option.Property(f => f.BuildingType).IsRequired();
                option.Property(f => f.VolumeIncludingFirstFloor).IsRequired();

                option.HasMany(f => f.Sections)
                .WithOne(f => f.Building)
                .HasForeignKey(f => f.BuildingId);

                option.HasMany(f => f.Parkings)
                .WithOne(f => f.Building)
                .HasForeignKey(f => f.BuildingId);

            });

            modelBuilder.Entity<Section>().HasMany(f => f.Corridors).WithMany(f => f.Sections);
            modelBuilder.Entity<Section>().HasMany(f => f.Staircases).WithMany(f => f.Sections);
            modelBuilder.Entity<Section>().HasMany(f => f.Elevators).WithMany(f => f.Sections);

            //modelBuilder.Entity<SectionCorridor>(option =>
            //{
            //    option.HasOne(f => f.Section)
            //    .WithMany(f => f.SectionCorridors)
            //    .HasForeignKey(f => f.SectionId);

            //    option.HasOne(f => f.Corridor)
            //    .WithMany(f => f.SectionCorridors)
            //    .HasForeignKey(f => f.CorridorId);

            //    option.HasKey(f => new { f.SectionId, f.CorridorId });
            //});

            //modelBuilder.Entity<SectionElevator>(option =>
            //{
            //    option.HasOne(f => f.Section)
            //    .WithMany(f => f.SectionElevators)
            //    .HasForeignKey(f => f.SectionId);

            //    option.HasOne(f => f.Elevator)
            //    .WithMany(f => f.SectionElevators)
            //    .HasForeignKey(f => f.ElevatorId);

            //    option.HasKey(f => new { f.SectionId, f.ElevatorId });
            //});

            //modelBuilder.Entity<SectionStaircase>(option =>
            //{
            //    option.HasOne(f => f.Section)
            //    .WithMany(f => f.SectionStaircases)
            //    .HasForeignKey(f => f.SectionId);

            //    option.HasOne(f => f.Staircase)
            //    .WithMany(f => f.SectionStaircases)
            //    .HasForeignKey(f => f.StaircaseId);

            //    option.HasKey(f => new { f.SectionId, f.StaircaseId });
            //});

            //modelBuilder.Entity<ParkingElevator>(option =>
            //{
            //    option.HasOne(f => f.Parking)
            //    .WithMany(f => f.ParkingElevators)
            //    .HasForeignKey(f => f.ParkingId);

            //    option.HasOne(f => f.Elevator).WithMany(f => f.ParkingElevators).HasForeignKey(f => f.ElevatorType);

            //    option.HasKey(f => new { f.ParkingId, f.ElevatorType });
            //});

            modelBuilder.Entity<Heat>(option =>
            {
                option.HasKey(f => f.Id);

                option.HasOne(f => f.Building).WithOne(f => f.Heat).HasForeignKey<Building>(g => g.HeatId);
            });

            modelBuilder.Entity<Staircase>().HasKey(f => f.Id);
            modelBuilder.Entity<Elevator>().HasKey(f => f.Id);
            modelBuilder.Entity<Parking>().HasMany(f => f.Elevators).WithMany(f => f.Parkings);

            //modelBuilder.Entity<Elevator>(option =>
            //{
            //    option.HasKey(f => f.TypeOfElevator);
            //});
        }
    }
}
