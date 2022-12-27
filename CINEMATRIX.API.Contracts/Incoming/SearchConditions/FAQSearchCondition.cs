using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class FAQSearchCondition : PagedDTOBase
    {
        public string[] Questions { get; set; }
        public string[] Answers { get; set; }
        public string[] Categories { get; set; }
    }
}
