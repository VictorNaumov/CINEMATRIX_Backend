using System.Text.Json.Serialization;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class FoundImageDTO
    {
        public string Id { get; set; }
        [JsonPropertyName("aspect_ratio")]
        public double AspectRatio { get; set; }
        [JsonPropertyName("file_path")]
        public string FilePath { get; set; }
        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }
        [JsonPropertyName("vote_count")]
        public double VoteCount { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
