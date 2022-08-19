
using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class SeatTypeSearchCondition : PagedDTOBase
    {
        public string[] Name { get; set; }
        public decimal[] Price { get; set; }
    }
}
