using Newtonsoft.Json;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundImageDTO
    {
        public string Id { get; set; }
        [JsonProperty("aspect_ratio")]
        public double AspectRatio { get; set; }
        [JsonProperty("file_path")]
        public string FilePath { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}