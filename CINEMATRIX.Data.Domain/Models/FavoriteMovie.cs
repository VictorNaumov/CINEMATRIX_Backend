namespace CINEMATRIX.Data.Domain.Models
{
    public class FavoriteMovie : KeyedEntityBase
    {
        public long ProfileId { get; set; }
        public long MovieId { get; set; }
        public int Rating { get; set; }
        public Profile Profile { get; set; }
    }
}
