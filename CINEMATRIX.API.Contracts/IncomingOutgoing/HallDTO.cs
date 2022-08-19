using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class HallDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundSystem { get; set; }
        public string Projector { get; set; }
        public string Screen { get; set; }
        public string ScreenResolution { get; set; }
    }
}
