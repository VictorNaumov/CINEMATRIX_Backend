using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CINEMATRIX.Data.Domain.Models.TMDB
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public bool Adult { get; set; }
        public decimal Budget { get; set; }
        [JsonPropertyName("original_lanuguage")]
        public string OriginalLanguage { get; set; }
        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public bool Video { get; set; }
        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
