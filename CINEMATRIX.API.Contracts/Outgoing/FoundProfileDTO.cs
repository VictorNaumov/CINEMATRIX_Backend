using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundProfileDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public List<FoundTicketDTO> Tickets { get; set; }
    }
}
