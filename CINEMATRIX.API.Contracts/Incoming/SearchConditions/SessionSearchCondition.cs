﻿using CINEMATRIX.API.Contracts.Incoming.Abstractions;
using System;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class SessionSearchCondition : PagedDTOBase
    {
        public bool IsPublic { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.MinValue;
        public DateTime EndDateTime { get; set; } = DateTime.MaxValue;
        public long[] MovieIds { get; set; }
        public long[] HallIds { get; set; }
        public long[] SeatTypeIds { get; set; }
        public long[] TimeSessions { get; set; }
        public bool NeedLoadHall { get; set; }
        public bool NeedLoadSeats { get; set; }
        public bool NeedLoadSeatType { get; set; }
    }
}