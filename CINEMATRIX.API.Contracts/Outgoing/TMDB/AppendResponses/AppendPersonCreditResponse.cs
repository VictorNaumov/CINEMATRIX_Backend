using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendPersonCreditResponse
    {
        public List<FoundPersonCreditDTO> Cast { get; set; }
        public List<FoundPersonCreditDTO> Crew { get; set; }
    }
}
