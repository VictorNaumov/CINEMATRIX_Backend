using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            int id = 1;

            builder.HasData
            (
                new Role
                {
                    Id = id++,
                    Name = "Admin",
                },
                new Role
                {
                    Id = id++,
                    Name = "Staff",
                },
                new Role
                {
                    Id = id++,
                    Name = "User",
                }
            );
        }
    }
}
