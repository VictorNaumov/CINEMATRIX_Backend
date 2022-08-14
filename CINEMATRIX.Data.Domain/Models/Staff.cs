using System;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Staff : KeyedEntityBase
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Phone Phone { get; set; }
        public long? PhoneId { get; set; }
    }
}
