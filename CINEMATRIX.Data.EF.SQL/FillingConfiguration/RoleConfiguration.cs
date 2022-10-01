using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData
            (
                new Role()
                {
                    Id = 0,
                    Name = "Admin",
                },
                new Role()
                {
                    Id = 1,
                    Name = "Staff",
                },
                new Role()
                {
                    Id = 2,
                    Name = "User",
                }
            );
        }
    }
}
