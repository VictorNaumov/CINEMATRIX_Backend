using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class PosterDTO
    {
        public long MovieId { get; set; }
        public bool IsRentMovie { get; set; }
    }
}
