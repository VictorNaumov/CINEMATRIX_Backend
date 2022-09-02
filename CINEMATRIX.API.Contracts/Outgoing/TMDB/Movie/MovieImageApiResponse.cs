using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieImageApiResponse
    {
        public List<FoundImageDTO> Backdrops { get; set; }
        public List<FoundImageDTO> Logos { get; set; }
        public List<FoundImageDTO> Posters { get; set; }
    }
}
