﻿using CINEMATRIX.API.Contracts.Incoming.Abstractions;
using System.ComponentModel;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class SeatTypeSearchCondition : PagedDTOBase
    {
        public string[] Name { get; set; }
        [DefaultValue(0)]
        public decimal StartPrice { get; set; }
        [DefaultValue(long.MaxValue)]
        public decimal FinishPrice { get; set; }
    }
}
