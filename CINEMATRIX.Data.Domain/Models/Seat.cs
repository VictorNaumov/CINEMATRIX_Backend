namespace CINEMATRIX.Data.Domain.Models
{
    public class Seat : KeyedEntityBase
    {
        public int Row { get; set; }
        public int Number { get; set; }
        public long HallId { get; set; }
        public Hall Hall { get; set; }
        public long SeatTypeId { get; set; }
        public SeatType SeatType { get; set; }
    }
}
