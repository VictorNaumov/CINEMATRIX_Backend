using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        private enum PlayedMoviesEnum
        {
            Avatar = 19995,
            Morbius = 526896,
            DC_League_of_Super_Pets = 539681,
            My_Sweet_Monster = 576925,
            Dragon_Ball_Super_Super_Hero = 610150,
            Spider_Man_No_Way_Home = 634649,
            The_Northman = 639933,
            Bullet_Train = 718930,
            After_Ever_Happy = 744276,
            The_Black_Phone = 756999,
            Orphan_First_Kill = 760161,
            Beast = 760741,
            Nope = 762504,
            Drifting_Home = 877957,
            Smile = 882598,
            The_Infernal_Machine = 916605,
            Wire_Room = 921360,
            Last_Seen_Alive = 961484,
            Fall = 985939,
            Stowaway = 999205
        }

        public void Configure(EntityTypeBuilder<Session> builder)
        {
            long id = 1;

            var sessions = new List<Session>();

            var playedMovies = Enum.GetValues(typeof(PlayedMoviesEnum));

            var random = new Random();

            for (int day = 1; day <= 28; day++)
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

            builder.HasData(sessions);
        }
    }
}
