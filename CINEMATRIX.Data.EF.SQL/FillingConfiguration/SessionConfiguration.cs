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

            var random = new Random();

            for (int day = -1; day <= 14; day++)
            {
                for (int hour = 8; hour <= 22; hour += 2)
                {
                    sessions.AddRange(
                        new List<Session>()
                        {
                            new Session
                            {
                                Id = id++,
                                MovieId = (int)playedMovies.GetValue(random.Next(playedMovies.Length)),
                                HallId = (int)HallEnum.LUX,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour)
                            },
                            new Session
                            {
                                Id = id++,
                                MovieId = (int)playedMovies.GetValue(random.Next(playedMovies.Length)),
                                HallId = (int)HallEnum.SWEETBOX,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieId = (int)playedMovies.GetValue(random.Next(playedMovies.Length)),
                                HallId = (int)HallEnum.SMALLHALL,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieId = (int)playedMovies.GetValue(random.Next(playedMovies.Length)),
                                HallId = (int)HallEnum.BIGHALL,
                                IsPublic = true,
                                DateTime = System.DateTime.Today.AddDays(day).AddHours(hour),
                            },
                            new Session
                            {
                                Id = id++,
                                MovieId = (int)playedMovies.GetValue(random.Next(playedMovies.Length)),
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
