namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundFoodDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlPicture { get; set; }
        public decimal Price { get; set; }
    }
}
