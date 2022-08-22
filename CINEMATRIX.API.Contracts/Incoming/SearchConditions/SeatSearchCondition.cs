
using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class SeatSearchCondition : PagedDTOBase
    {
        public int[] Row { get; set; }
        public int[] Number { get; set; }
    }
}
