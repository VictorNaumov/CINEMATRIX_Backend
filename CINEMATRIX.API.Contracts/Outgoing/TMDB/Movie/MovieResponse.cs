using Newtonsoft.Json;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class MovieResponse
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public bool Adult { get; set; }
        public decimal Budget { get; set; }
        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }
        public double Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }
        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }
        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public bool Video { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        public List<FoundGenreDTO> Genres { get; set; }
        public List<FoundVideoDTO> Videos { get; set; }
        public List<FoundImageDTO> Images { get; set; }
        public List<MovieCreditResponse> Credits { get; set; }
        public List<FoundMovieCommentDTO> MovieComments { get; set; }
    }
}
