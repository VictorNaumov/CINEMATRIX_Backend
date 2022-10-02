using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            long id = 1;

            builder.HasData
            (
                new Hall
                {
                    Id = id++,
                    Name = "LUX",
                    Description = "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 x 3,9",
                    ScreenResolution = "4K",
                },
                new Hall
                {
                    Id = id++,
                    Name = "SWEET BOX",
                    Description = "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 х 3,9",
                    ScreenResolution = "4K",
                },
                new Hall
                {
                    Id = id++,
                    Name = "SMALL HALL",
                    Description = "Standard seats. For two Sofa Love.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "8,7 х 3,9",
                    ScreenResolution = "4K",
                },
                new Hall
                {
                    Id = id++,
                    Name = "BIG HALL",
                    Description = "Standard seats. For two Sofa Love.",
                    SoundSystem = "Dolby 7,1",
                    Projector = "Sony",
                    Screen = "13,3 x 5,7",
                    ScreenResolution = "4K",
                },
                new Hall
                {
                    Id = id++,
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