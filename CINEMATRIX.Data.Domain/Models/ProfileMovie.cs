namespace CINEMATRIX.Data.Domain.Models
{
    public class ProfileMovie : KeyedEntityBase
    {
        public long ProfileId { get; set; }
        public long MovieId { get; set; }
    }
}
