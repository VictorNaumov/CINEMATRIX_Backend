using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundPersonCreditDTO
    {
        public long Id { get; set; }
        public bool Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }
        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }
        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public string Character { get; set; }
        public int? Order { get; set; }
    }
}
