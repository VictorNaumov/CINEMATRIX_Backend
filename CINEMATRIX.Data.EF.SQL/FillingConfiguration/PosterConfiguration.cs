using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL.FillingConfiguration.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class PosterConfiguration : IEntityTypeConfiguration<Poster>
    {
        public void Configure(EntityTypeBuilder<Poster> builder)
        {
            int id = 1;

            var playedMovies = Enum.GetValues(typeof(PlayedMoviesEnum));

            var posters = new List<Poster>();

            for (int i = 0; i < playedMovies.Length; i++)
            {
                posters.Add(
                    new Poster()
                    {
                        Id = id++,
                        IsRentMovie = true,
                        MovieId = (int)playedMovies.GetValue(i)
                    }
                );
            }

            builder.HasData(posters.Distinct());
        }
    }
}