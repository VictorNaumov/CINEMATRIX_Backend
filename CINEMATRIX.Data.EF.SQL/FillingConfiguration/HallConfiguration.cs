using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasData
            (
                new Hall()
                {
                    Id = 0,
                    Name = "LUX",
                    Description = "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 x 3,9",
                    ScreenResolution = "4K",
                },
                new Hall()
                {
                    Id = 1,
                    Name = "SWEET BOX",
                    Description = "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 х 3,9",
                    ScreenResolution = "4K",
                },
                new Hall()
                {
                    Id = 2,
                    Name = "SMALL HALL",
                    Description = "Standard seats. For two Sofa Love.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 х 3,9",
                    ScreenResolution = "4K",
                },
                new Hall()
                {
                    Id = 3,
                    Name = "BIG HALL",
                    Description = "Standard seats. For two Sofa Love.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "13,3 x 5,7",
                    ScreenResolution = "4K",
                },
                new Hall()
                {
                    Id = 4,
                    Name = "ATMOS",
                    Description = "Standard seats. For two Sofa Love.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "13,3 x 5,7",
                    ScreenResolution = "4K",
                }
            );
        }
    }
}