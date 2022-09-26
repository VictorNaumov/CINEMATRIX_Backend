using System.ComponentModel;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class PosterDTO
    {
        public long MovieId { get; set; }
        [DefaultValue(false)]
        public bool IsRentMovie { get; set; }
    }
}
