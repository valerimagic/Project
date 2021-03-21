using DAL.Connection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.DataContext
{
    public class AirflightDbContext : DbContext
    {
        public DbSet<Airplanes> Airplane { get; set; }
        public DbSet<Flights> Flight { get; set; }
        public DbSet<Passengers> Passenger { get; set; }




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
