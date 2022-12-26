namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundFAQDTO
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
}
