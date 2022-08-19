using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class TicketDTO
    {
        public long SessionId { get; set; }
        public long SeatId { get; set; }
    }
}
