using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class GenreResponse
    {
        public List<FoundGenreDTO> Genres { get; set; }
    }
}
