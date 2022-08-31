using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CINEMATRIX.Data.Domain.Models.TMDB
{
    internal class Video
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Site { get; set; }
        public int Size { get; set; }
        public string Type{ get; set; }
        public bool Official { get; set; }
        [JsonPropertyName("published_at")]
        public DateTime PublishedAt{ get; set; }
    }
}
