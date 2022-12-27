using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            long id = 1;

            builder.HasData
            (
                new Cinema
                {
                    Id = id++,
                    Name = "Cinematrix",
                    Address = "Novopolotsk Pushkina street",
                    Email = "cinematrix@gmail.com",
                    ContactNumber = "+37529281133"
                }
            );
        }
    }
}

