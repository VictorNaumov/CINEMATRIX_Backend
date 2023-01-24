using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundPersonDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? DeathDay { get; set; }
        public string Biography { get; set; }
        public decimal Popularity { get; set; }
        public bool Adult { get; set; }
        public string PlaceOfBirth { get; set; }
        public List<FoundImageDTO> Images { get; set; }
        public List<FoundPersonCreditDTO> Credits { get; set; }
    }
}
