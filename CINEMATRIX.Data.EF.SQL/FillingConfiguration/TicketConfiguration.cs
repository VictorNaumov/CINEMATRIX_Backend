using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            long id = 1;

            var tickets = new List<Ticket>();

            var random = new Random();

            Dictionary<HallEnum, (int, int)> hallSeatRanges = new Dictionary<HallEnum, (int, int)>()
            {
                { HallEnum.LUX, (1, 40) },
                { HallEnum.SWEETBOX, (41, 70) },
                { HallEnum.SMALLHALL, (71, 148) },
                { HallEnum.BIGHALL, (149, 329) },
                { HallEnum.ATMOS, (330, 472) }
            };

            var days = 14;
            var firstSessionHour = 8;
            var lastSessionHour = 22;
            var countOfSessions = days * ((lastSessionHour - firstSessionHour) / 2);
            var countOfSeats = hallSeatRanges.LastOrDefault().Value.Item2;

            while (tickets.Count < 600)
            {
                var sessionId = random.Next(1, countOfSessions + 1);
                var hallId = sessionId > 5 ? sessionId % 5 : sessionId;
                hallId = hallId == 0 ? 5 : hallId;

                var rangeSeat = hallSeatRanges[(HallEnum)hallId];
                var seatId = random.Next(rangeSeat.Item1, rangeSeat.Item2 + 1);

                for (int i = 0; i < GetCountTogether(); i++)
                {
                    if (rangeSeat.Item1 <= seatId + i && seatId + i <= rangeSeat.Item2 &&
                        !tickets.Any(t => t.SessionId == sessionId && t.SeatId == seatId + i))
                    {
                        tickets.Add(
                            new Ticket
                            {
                                Id = id++,
                                SessionId = sessionId,
                                SeatId = seatId + i,
                                ProfileId = random.Next(1, 4)
                            }
                        );
                    }
                }
            }

            builder.HasData(tickets);
        }

        int GetCountTogether()
        {
            //max 101 because Random.Next return values included MinValue
            //but not MaxValue(1 % -100 %)
            int value = new Random().Next(1, 101);

            if (1 <= value && value <= 15) return 1;
            else if (16 <= value && value <= 60) return 2;
            else if (61 <= value && value <= 90) return 3;
            else if (91 <= value && value <= 100) return 4;
            else return 1;
        }
    }
}
