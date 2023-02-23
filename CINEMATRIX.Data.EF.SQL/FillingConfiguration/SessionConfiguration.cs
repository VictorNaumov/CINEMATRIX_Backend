using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL.FillingConfiguration.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            long id = 1;

            var sessions = new List<Session>();

            var playedMovies = Enum.GetValues(typeof(PlayedMoviesEnum));
            var playedTitleMovies = Enum.GetNames(typeof(PlayedMoviesEnum));

            var random = new Random();

            for (int day = -1; day <= 14; day++)
            {
                for (int hour = 8; hour <= 22; hour += 2)
                {
                    var movie1 = random.Next(playedMovies.Length);
                    var movie2 = random.Next(playedMovies.Length);
                    var movie3 = random.Next(playedMovies.Length);
                    var movie4 = random.Next(playedMovies.Length);
                    var movie5 = random.Next(playedMovies.Length);

                    sessions.AddRange(
                        new List<Session>()
                        {
                            new Session
                            {
                                Id = id++,
                                MovieTitle = (string)playedTitleMovies.GetValue(movie1),
                                MovieId = (int)playedMovies.GetValue(movie1),
                                HallId = (int)HallEnum.LUX,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour)
                            },
                            new Session
                            {
                                Id = id++,
                                MovieTitle = (string)playedTitleMovies.GetValue(movie2),
                                MovieId = (int)playedMovies.GetValue(movie2),
                                HallId = (int)HallEnum.SWEETBOX,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieTitle = (string)playedTitleMovies.GetValue(movie3),
                                MovieId = (int)playedMovies.GetValue(movie3),
                                HallId = (int)HallEnum.SMALLHALL,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieTitle = (string)playedTitleMovies.GetValue(movie4),
                                MovieId = (int)playedMovies.GetValue(movie4),
                                HallId = (int)HallEnum.BIGHALL,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieTitle = (string)playedTitleMovies.GetValue(movie5),
                                MovieId = (int)playedMovies.GetValue(movie5),
                                HallId = (int)HallEnum.ATMOS,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            }
                        }
                    );
                }
            }

            builder.HasData(sessions.Distinct());
        }
    }
}
