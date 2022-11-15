﻿using System;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class ProfileDTO
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
