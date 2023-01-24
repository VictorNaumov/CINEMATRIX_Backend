using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendMovieCreditResponse
    {
        public List<MovieCreditResponse> Cast { get; set; }
        public List<MovieCreditResponse> Crew { get; set; }
    }
}
