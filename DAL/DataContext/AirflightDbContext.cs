namespace DAL.DataContext
{
    using DAL.Connection;
    using DAL.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AirflightDbContext : DbContext
    {
        public DbSet<Airplanes> Airplane { get; set; }

        public DbSet<Flights> Flight { get; set; }

        public DbSet<Passengers> Passenger { get; set; }

        public DbSet<RegistrationDetail> RegistrationDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString.DefaultConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
