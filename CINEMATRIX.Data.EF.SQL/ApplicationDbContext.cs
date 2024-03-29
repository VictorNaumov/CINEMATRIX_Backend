﻿using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL.FillingConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CINEMATRIX.Data.EF.SQL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmailConfirmationToken> EmailConfirmationTokens { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<MovieComment> MovieComments { get; set; }
        public DbSet<FavoriteMovie> FavoriteMovies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Session>().HasMany(x => x.Tickets).WithOne(y => y.Session).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ticket>().HasIndex(c => new { c.SessionId, c.SeatId }).IsUnique();
        }
    }
}
