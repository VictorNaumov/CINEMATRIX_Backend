using System;
using System.Text.Json.Serialization;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class FoundVideoDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Site { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public bool Official { get; set; }
        [JsonPropertyName("published_at")]
        public DateTime PublishedAt { get; set; }
    }
}
