namespace CINEMATRIX.Data.Domain.Models
{
    public class Food : KeyedEntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlPicture { get; set; }
        public decimal Price { get; set; }
    }
}
