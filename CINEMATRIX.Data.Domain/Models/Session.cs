using System;
using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Session : KeyedEntityBase
    {
        public string MovieTitle { get; set; }
        public long MovieId { get; set; }
        public long HallId { get; set; }
        public bool IsPublic { get; set; }
        public Hall Hall { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
