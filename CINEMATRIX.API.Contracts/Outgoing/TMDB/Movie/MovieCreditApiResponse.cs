using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieCreditApiResponse
    {
        public List<FoundVideoDTO> Videos{ get; set; }
    }
}
