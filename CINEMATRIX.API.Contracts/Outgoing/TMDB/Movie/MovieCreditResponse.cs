using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieCreditResponse
    {
        public List<FoundMovieCreditDTO> Cast { get; set; }
        public List<FoundMovieCreditDTO> Crew { get; set; }
    }
}
