using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class FavoriteMovieSearchCondition : PagedDTOBase
    {
        public long[] ProfileIds { get; set; }
        public long[] MovieIds { get; set; }
        public int[] Ratings { get; set; }
    }
}
