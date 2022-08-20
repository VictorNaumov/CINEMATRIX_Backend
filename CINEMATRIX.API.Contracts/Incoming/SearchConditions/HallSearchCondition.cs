
using CINEMATRIX.API.Contracts.Incoming.Abstractions;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class HallSearchCondition : PagedDTOBase
    {
        public string[] Name { get; set; }
        public string[] Description { get; set; }
        public string[] SoundSystem { get; set; }
        public string[] Projector { get; set; }
        public string[] Screen { get; set; }
        public string[] ScreenResolution { get; set; }
    }
}
