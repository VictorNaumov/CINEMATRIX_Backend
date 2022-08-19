using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class PersonalDataDTO
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
    }
}
