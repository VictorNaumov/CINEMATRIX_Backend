using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundHallDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundSystem { get; set; }
        public string Projector { get; set; }
        public string Screen { get; set; }
        public string ScreenResolution { get; set; }
        public ICollection<FoundSeatDTO> Seats { get; set; }
    }
}
