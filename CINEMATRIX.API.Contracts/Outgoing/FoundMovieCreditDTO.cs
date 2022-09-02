using Newtonsoft.Json;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundMovieCreditDTO
    {
        public long Id { get; set; }
        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }
        public bool Adult { get; set; }
        public int Gender { get; set; }
        public string Name { get; set; }
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }
        public double Popularity { get; set; }
        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
        [JsonProperty("cast_id")]
        public string CastId { get; set; }
        public string Character { get; set; }
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }
        public string Order { get; set; }
    }
}
