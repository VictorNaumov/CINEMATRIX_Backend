using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing.TMDB
{
    public class AppendImageResponse
    {
        public List<ImageResponse> Backdrops { get; set; }
        public List<ImageResponse> Logos { get; set; }
        public List<ImageResponse> Posters { get; set; }
        public List<ImageResponse> Profiles { get; set; }
    }
}