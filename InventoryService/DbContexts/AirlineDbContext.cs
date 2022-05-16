using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesService.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlinesService.DbContexts
{
    public class AirlineDbContext : DbContext
    {
        public AirlineDbContext()
        {
        }

        public AirlineDbContext(DbContextOptions<AirlineDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAirlineDetails> TblAirlineDetails { get; set; }
        public virtual DbSet<TblBookingDetails> TblBookingDetails { get; set; }
   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAirlineDetails>(entity =>
            {
                entity.ToTable("tblAirlineDetails");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<TblBookingDetails>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK_tblFlightBooking");

                entity.ToTable("tblBookingDetails");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Destination)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.MealOption).HasMaxLength(20);

                entity.Property(e => e.PassengerGender).HasMaxLength(10);

                entity.Property(e => e.PassengerName).HasMaxLength(50);

                entity.Property(e => e.Pnr).HasColumnName("PNR");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

           

           
        }
    }
}
