using Newtonsoft.Json;
using System;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class VideoResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Site { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public bool Official { get; set; }
        [JsonProperty("published_at")]
        public DateTime PublishedAt { get; set; }
    }
}
