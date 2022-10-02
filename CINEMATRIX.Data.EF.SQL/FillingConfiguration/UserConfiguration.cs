using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            int id = 1;

            builder.HasData
            (
                new User
                {
                    Id = id++,
                    UserName = "admin",
                    Password = "admin",
                    ProfileId = 1,
                    RoleId = (int)RoleEnum.Admin,
                    Email = "admin@gmail.com",
                },
                new User
                {
                    Id = id++,
                    UserName = "staff",
                    Password = "staff",
                    ProfileId = 2,
                    RoleId = (int)RoleEnum.Staff,
                    Email = "staff@gmail.com",
                },
                new User
                {
                    Id = id++,
                    UserName = "user",
                    Password = "user",
                    ProfileId = 3,
                    RoleId = (int)RoleEnum.User,
                    Email = "user@gmail.com",
                }
            );
        }
    }
}









