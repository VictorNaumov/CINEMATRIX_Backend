using System;

namespace CINEMATRIX.Data.Domain.Models
{
    public class FAQ : KeyedEntityBase
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
