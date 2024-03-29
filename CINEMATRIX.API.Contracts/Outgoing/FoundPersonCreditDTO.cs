﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundPersonCreditDTO
    {
        public long Id { get; set; }
        public bool Adult { get; set; }
        public string BackdropPath { get; set; }
        public List<int> GenreIds { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public string CreditId { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
        public string Character { get; set; }
        public int? Order { get; set; }
    }
}
