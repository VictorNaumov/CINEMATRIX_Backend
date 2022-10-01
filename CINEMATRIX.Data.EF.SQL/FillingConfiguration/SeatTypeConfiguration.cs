using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class SeatTypeConfiguration : IEntityTypeConfiguration<SeatType>
    {
        public void Configure(EntityTypeBuilder<SeatType> builder)
        {
            builder.HasData
            (
                new SeatType()
                {
                    Id = 0,
                    Name = "Standart",
                    Price = 4
                },
                new SeatType()
                {
                    Id = 1,
                    Name = "Lux",
                    Price = 6
                },
                new SeatType()
                {
                    Id = 2,
                    Name = "Romantic",
                    Price = 8
                }
            );
        }
    }
}
