using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            int id = 1;

            builder.HasData
            (
                new Profile
                {
                    Id = id++,
                    Name = "Admin",
                    SecondName = "Admin",
                    DateOfBirth = DateTime.Today.AddYears(-20),
                    PhoneNumber = "+375291111111",
                    ImageUrl = "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg"
                },
                new Profile
                {
                    Id = id++,
                    Name = "Staff",
                    SecondName = "Staff",
                    DateOfBirth = DateTime.Today.AddYears(-21),
                    PhoneNumber = "+375291111112",
                    ImageUrl = "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg"
                },
                new Profile
                {
                    Id = id++,
                    Name = "User",
                    SecondName = "User",
                    DateOfBirth = DateTime.Today.AddYears(-22),
                    PhoneNumber = "+375291111113",
                    ImageUrl = "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg"
                }
            );
        }
    }
}