using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendVideoResponse
    {
        public List<FoundVideoDTO> Results { get; set; }
    }
}
