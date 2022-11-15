using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            long id = 1;

            #region Add seat configuration for LUX hall

            var seatsForLuxHall = new List<Seat>();

            var countRowsLuxHall = 5;
            for (int r = 0; r < countRowsLuxHall; r++)
            {
                var countNumbersLuxHall = 8;

                for (int n = 0; n < countNumbersLuxHall; n++)
                {
                    seatsForLuxHall.Add(
                        new Seat()
                        {
                            Id = id++,
                            Row = r + 1,
                            Number = n + 1,
                            HallId = (long)HallEnum.LUX,
                            SeatTypeId = (long)SeatTypeEnum.Lux
                        }
                    );
                }
            }

            #endregion

            #region Add seat configuration for SWEETBOX hall

            var seatsForSweetBoxHall = new List<Seat>();

            var countRowsSweetBoxHall = 6;
            for (int r = 0; r < countRowsSweetBoxHall; r++)
            {
                var countNumbersSweetBoxHall = 5;
                for (int n = 0; n < countNumbersSweetBoxHall; n++)
                {
                    seatsForSweetBoxHall.Add(
                        new Seat()
                        {
                            Id = id++,
                            Row = r + 1,
                            Number = n + 1,
                            HallId = (long)HallEnum.SWEETBOX,
                            SeatTypeId = (long)SeatTypeEnum.Romantic
                        }
                     );
                }
            }

            #endregion

            #region Add seat configuration for SMALLHALL hall

            var seatsForSmallHall = new List<Seat>();

            var countRowsSmallHall = 7;
            for (int r = 0; r < countRowsSmallHall; r++)
            {
                var isLastRow = r == countRowsSmallHall - 1;
                var countNumbersSmallHall = isLastRow ? 6 : 12;
                var seatType = isLastRow ? SeatTypeEnum.Romantic : SeatTypeEnum.Standart;
                for (int n = 0; n < countNumbersSmallHall; n++)
                {
                    seatsForSmallHall.Add(
                        new Seat()
                        {
                            Id = id++,
                            Row = r + 1,
                            Number = n + 1,
                            HallId = (long)HallEnum.SMALLHALL,
                            SeatTypeId = (long)seatType
                        }
                     );
                }
            }

            #endregion

            #region Add seat configuration for BIGHALL hall

            var seatsForBigHall = new List<Seat>();

            var countRowsBigHall = 11;
            for (int r = 0; r < countRowsBigHall; r++)
            {
                var isTwoLastRow = r == countRowsBigHall - 1 || r == countRowsBigHall - 2;

                var countNumbersBigHall = isTwoLastRow ? 9 : 18;

                var seatType = isTwoLastRow ? SeatTypeEnum.Romantic : SeatTypeEnum.Standart;

                for (int n = 0; n < countNumbersBigHall; n++)
                {
                    seatsForBigHall.Add(
                        new Seat()
                        {
                            Id = id++,
                            Row = r + 1,
                            Number = n + 1,
                            HallId = (long)HallEnum.BIGHALL,
                            SeatTypeId = (long)seatType
                        }
                     );
                }
            }

            #endregion

            #region Add seat configuration for ATMOS hall

            var seatsForAtmosHall = new List<Seat>();

            var countRowsAtmos = 10;
            for (int r = 0; r < countRowsAtmos; r++)
            {
                var isTwoPenultimate = r == countRowsAtmos - 3 || r == countRowsAtmos - 4;
                var isLastRow = r == countRowsAtmos - 1 || r == countRowsAtmos - 2;

                var countNumbersAtmos = isLastRow ? 8 : 16;

                var seatType = SeatTypeEnum.Standart;

                if (isLastRow)
                {
                    seatType = SeatTypeEnum.Romantic;
                }

                if (isTwoPenultimate)
                {
                    seatType = SeatTypeEnum.Lux;
                }

                for (int n = 0; n < countNumbersAtmos; n++)
                {
                    seatsForAtmosHall.Add(
                        new Seat()
                        {
                            Id = id++,
                            Row = r + 1,
                            Number = n + 1,
                            HallId = (long)HallEnum.ATMOS,
                            SeatTypeId = (long)seatType
                        }
                     );
                }
            }

            #endregion

            var resultSeats = new List<Seat>();
            resultSeats.AddRange(seatsForLuxHall);
            resultSeats.AddRange(seatsForSweetBoxHall);
            resultSeats.AddRange(seatsForSmallHall);
            resultSeats.AddRange(seatsForBigHall);
            resultSeats.AddRange(seatsForAtmosHall);

            builder.HasData(resultSeats.Distinct());
        }
    }
}