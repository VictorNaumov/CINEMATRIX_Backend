using System;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class SessionDTO
    {
        public long MovieId { get; set; }
        public long HallId { get; set; }
        public bool IsPublic { get; set; }
        public DateTime DateTime { get; set; }
    }
}
