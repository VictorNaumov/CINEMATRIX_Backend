using Newtonsoft.Json;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class PagedPeopleResponse
    {
        public int Page { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        public List<FoundPersonDTO> Results { get; set; }
    }
}
