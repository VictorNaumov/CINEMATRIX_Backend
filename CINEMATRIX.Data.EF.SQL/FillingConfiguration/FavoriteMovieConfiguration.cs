using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class FavoriteMovieConfiguration : IEntityTypeConfiguration<FavoriteMovie>
    {
        public void Configure(EntityTypeBuilder<FavoriteMovie> builder)
        {
            long id = 1;

            builder.HasData
            (
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 1,
                    MovieId = 539681,
                    Rating = 5
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 2,
                    MovieId = 576925,
                    Rating = 4
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 1,
                    MovieId = 610150,
                    Rating = 3
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 3,
                    MovieId = 634649,
                    Rating = 5
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 1,
                    MovieId = 639933,
                    Rating = 4
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 2,
                    MovieId = 718930,
                    Rating = 3
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 3,
                    MovieId = 744276,
                    Rating = 4
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 1,
                    MovieId = 756999,
                    Rating = 5
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 2,
                    MovieId = 760161,
                    Rating = 4
                },
                new FavoriteMovie
                {
                    Id = id++,
                    ProfileId = 3,
                    MovieId = 760741,
                    Rating = 3
                }
            );
        }
    }
}

