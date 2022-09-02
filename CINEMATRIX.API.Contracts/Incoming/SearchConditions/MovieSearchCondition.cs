
using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class MovieSearchCondition : PagedDTOBase
    {
        public string[] Title { get; set; }
    }
}
