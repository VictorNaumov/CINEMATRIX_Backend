using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CINEMATRIX.Data.EF.SQL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<PersonalData> PersonalData { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Session>().HasMany(x => x.Tickets).WithOne(y => y.Session).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
