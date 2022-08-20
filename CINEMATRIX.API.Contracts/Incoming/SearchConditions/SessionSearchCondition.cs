using CINEMATRIX.API.Contracts.Incoming.Abstractions;
using System;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class SessionSearchCondition : PagedDTOBase
    {
        public string[] MovieName { get; set; }
        public bool IsPublic { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.MinValue;
        public DateTime EndDateTime { get; set; } = DateTime.MaxValue;
    }
}
