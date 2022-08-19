using System;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundSessionDTO
    {
        public long Id { get; set; }
        public bool IsPublic { get; set; }
        public DateTime DateTime { get; set; }
    }
}
