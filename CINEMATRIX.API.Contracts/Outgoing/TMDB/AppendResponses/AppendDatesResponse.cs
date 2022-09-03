using System;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendDatesResponse
    {
        public DateTime? Minimum { get; set; }
        public DateTime? Maximum { get; set; }
    }
}
