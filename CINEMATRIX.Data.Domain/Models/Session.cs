using System;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Session : KeyedEntityBase
    {
        public long MovieId { get; set; }
        public long HallId { get; set; }
        public Hall Hall { get; set; }
        public DateTime DateTime { get; set; }
    }
}
