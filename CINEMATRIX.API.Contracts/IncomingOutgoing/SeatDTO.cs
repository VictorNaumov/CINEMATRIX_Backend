using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class SeatDTO
    {
        public int Row { get; set; }
        public int Number { get; set; }
        public long HallId { get; set; }
        public long SeatTypeId { get; set; }
    }
}
