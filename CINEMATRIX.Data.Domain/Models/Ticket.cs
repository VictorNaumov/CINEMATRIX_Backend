namespace CINEMATRIX.Data.Domain.Models
{
    public class Ticket : KeyedEntityBase
    {
        public long SessionId { get; set; }
        public long SeatId { get; set; }
        public long ProfileId { get; set; }
        public Seat Seat { get; set; }
        public Session Session { get; set; }
        public Profile Profile { get; set; }
    }
}
