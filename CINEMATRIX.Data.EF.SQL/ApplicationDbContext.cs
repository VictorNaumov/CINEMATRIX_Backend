using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CINEMATRIX.Data.EF.SQL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<RentHall> RentHalls { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
