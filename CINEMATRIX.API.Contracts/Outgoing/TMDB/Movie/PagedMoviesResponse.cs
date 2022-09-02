using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class PagedMoviesResponse
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
        public List<FoundMovieDTO> Results { get; set; }
    }
}
