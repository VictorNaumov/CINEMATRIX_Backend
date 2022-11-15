using System;
using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Profile : KeyedEntityBase
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
