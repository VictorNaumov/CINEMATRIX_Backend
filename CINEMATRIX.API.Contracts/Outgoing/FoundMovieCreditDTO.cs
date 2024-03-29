﻿using Newtonsoft.Json;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundMovieCreditDTO
    {
        public long Id { get; set; }
        public bool Adult { get; set; }
        public int Gender { get; set; }
        public double Popularity { get; set; }
        public string KnownForDepartment { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string ProfilePath { get; set; }
        public string CastId { get; set; }
        public string Character { get; set; }
        public string CreditId { get; set; }
        public string Order { get; set; }
    }
}
