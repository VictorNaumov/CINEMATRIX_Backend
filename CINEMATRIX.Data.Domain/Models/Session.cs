using System;
using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Session : KeyedEntityBase
    {
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public long HallId { get; set; }
        public bool IsPublic { get; set; }
        public Hall Hall { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
