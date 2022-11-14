using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Cinema : KeyedEntityBase
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public ICollection<Hall> Halls { get; set; }
    }
}
