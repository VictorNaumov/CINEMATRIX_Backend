﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieVideoApiResponse
    {
        public List<FoundVideoDTO> Results { get; set; }
    }
}
