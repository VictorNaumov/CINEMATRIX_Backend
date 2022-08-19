using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class FoodDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlPicture { get; set; }
        public decimal Price { get; set; }
    }
}
