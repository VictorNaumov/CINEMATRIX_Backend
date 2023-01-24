using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendPersonCreditResponse
    {
        public List<PersonCreditResponse> Cast { get; set; }
        public List<PersonCreditResponse> Crew { get; set; }
    }
}
