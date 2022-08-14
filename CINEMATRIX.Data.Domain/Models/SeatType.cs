namespace CINEMATRIX.Data.Domain.Models
{
    public class SeatType : KeyedEntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
