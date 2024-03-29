﻿using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class SeatTypeConfiguration : IEntityTypeConfiguration<SeatType>
    {
        public void Configure(EntityTypeBuilder<SeatType> builder)
        {
            long id = 1;
            builder.HasData
            (
                new SeatType
                {
                    Id = id++,
                    Name = "Standart",
                    Price = 4
                },
                new SeatType
                {
                    Id = id++,
                    Name = "Lux",
                    Price = 6
                },
                new SeatType
                {
                    Id = id++,
                    Name = "Romantic",
                    Price = 8
                }
            );
        }
    }
}
