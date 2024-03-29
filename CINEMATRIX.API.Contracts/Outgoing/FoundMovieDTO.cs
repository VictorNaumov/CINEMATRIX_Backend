﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundMovieDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public bool Adult { get; set; }
        public decimal Budget { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public string BackdropPath { get; set; }
        public string ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public List<FoundGenreDTO> Genres { get; set; }
        public List<FoundVideoDTO> Videos { get; set; }
        public List<FoundImageDTO> Images { get; set; }
        public List<FoundMovieCreditDTO> Credits { get; set; }
        public List<FoundMovieCommentDTO> MovieComments { get; set; }
    }
}
