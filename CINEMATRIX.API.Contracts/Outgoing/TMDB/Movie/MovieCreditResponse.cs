using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieCreditResponse
    {
        public List<FoundVideoDTO> Videos { get; set; }
    }
}
