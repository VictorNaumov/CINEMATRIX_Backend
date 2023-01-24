using Newtonsoft.Json;
using System;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class PersonDetailByIdResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? DeathDay { get; set; }
        public string Biography { get; set; }
        public decimal Popularity { get; set; }
        public bool Adult { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }
        public AppendImageResponse Images { get; set; }
        public AppendPersonCreditResponse Credits { get; set; }
    }
}
