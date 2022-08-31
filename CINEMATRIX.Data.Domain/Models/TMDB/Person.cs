using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CINEMATRIX.Data.Domain.Models.TMDB
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime DeathDay { get; set; }
        public string Biography{ get; set; }
        public decimal Popularity { get; set; }
        public bool Adult { get; set; }

        [JsonPropertyName("place_of_birth")]
        public string PlaceOfBirth { get; set; }
    }
}
