namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundPosterDTO
    {
        public long Id { get; set; }
        public long MovieId { get; set; }
        public bool IsRentMovie { get; set; }
    }
}
