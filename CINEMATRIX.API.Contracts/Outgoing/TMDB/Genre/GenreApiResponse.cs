using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class GenreApiResponse
    {
        public List<FoundGenreDTO> Genres { get; set; }
    }
}
