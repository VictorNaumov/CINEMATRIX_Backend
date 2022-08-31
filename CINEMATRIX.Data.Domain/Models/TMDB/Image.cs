using System.Text.Json.Serialization;

namespace CINEMATRIX.Data.Domain.Models.TMDB
{
    public class Image
    {
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
