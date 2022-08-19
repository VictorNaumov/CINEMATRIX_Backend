using System;

namespace CINEMATRIX.Data.Domain.Models
{
    public class RentHall : KeyedEntityBase
    {
        public long HallId { get; set; }
        public Hall Hall { get; set; }
        public DateTime Date { get; set; }
    }
}
