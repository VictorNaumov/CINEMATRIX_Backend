namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundSeatDTO
    {
        public long Id { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        public int SeatTypeId { get; set; }
        public FoundSeatTypeDTO SeatType { get; set; }
    }
}
