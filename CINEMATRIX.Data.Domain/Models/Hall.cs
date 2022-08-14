using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class Hall : KeyedEntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundSystem { get; set; }
        public string Projector { get; set; }
        public string Screen { get; set; }
        public string ScreenResolution { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
