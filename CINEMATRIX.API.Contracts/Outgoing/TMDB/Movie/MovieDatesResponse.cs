using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieDatesResponse
    {
        public DateTime Minimum { get; set; }
        public DateTime Maximum { get; set; }
    }
}
