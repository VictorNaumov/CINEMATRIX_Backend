﻿namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public long? RoleId { get; set; }
    }
}
