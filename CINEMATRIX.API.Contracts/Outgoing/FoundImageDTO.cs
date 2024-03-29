﻿using Newtonsoft.Json;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundImageDTO
    {
        public string Id { get; set; }
        public double AspectRatio { get; set; }
        public string FilePath { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}