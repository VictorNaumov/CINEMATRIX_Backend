
using CINEMATRIX.API.Contracts.Incoming.Abstractions;
using System;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class DiscoverMovieSearchCondition : PagedDTOBase
    {
        public int[] Genres { get; set; }
        public int[] People { get; set; }
        public bool IncludeAdult { get; set; }
        public DateTime ReleaseDateGTE{ get; set; }
        public DateTime ReleaseDateLTE{ get; set; }

    }
}
