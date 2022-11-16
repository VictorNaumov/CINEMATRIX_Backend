namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundTicketDTO
    {
        public long Id { get; set; }
        public long SessionId { get; set; }
        public long SeatId { get; set; }
        public long ProfileId { get; set; }
        public FoundSeatDTO Seat { get; set; }
        public FoundSessionDTO Session { get; set; }
        public FoundProfileDTO Profile { get; set; }
    }
}
