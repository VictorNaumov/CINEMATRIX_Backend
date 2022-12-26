using System;

namespace CINEMATRIX.Data.Domain.Models
{
    public class EmailConfirmationToken : KeyedEntityBase
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
