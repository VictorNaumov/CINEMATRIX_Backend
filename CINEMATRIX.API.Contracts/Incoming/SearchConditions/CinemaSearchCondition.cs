
using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class CinemaSearchCondition : PagedDTOBase
    {
        public string[] Name { get; set; }
    }
}
