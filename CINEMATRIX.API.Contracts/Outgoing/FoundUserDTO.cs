﻿namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundUserDTO
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public long RoleId { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public FoundProfileDTO Profile { get; set; }
    }
}
