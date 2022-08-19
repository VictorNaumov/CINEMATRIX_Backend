namespace CINEMATRIX.Data.Domain.Models
{
    public class Poster : KeyedEntityBase
    {
        public long MovieId { get; set; }
        public bool IsRentMovie { get; set; }
    }
}
