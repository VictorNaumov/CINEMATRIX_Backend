using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundSessionDTO
    {
        public long Id { get; set; }
        public string MovieTitle { get; set; }
        public long MovieId { get; set; }
        public long HallId { get; set; }
        public bool IsPublic { get; set; }
        public FoundHallDTO Hall { get; set; }
        public FoundMovieDTO Movie { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<FoundTicketDTO> Tickets { get; set; }
    }
}
