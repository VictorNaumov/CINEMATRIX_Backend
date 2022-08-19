namespace CINEMATRIX.Data.Domain.Models
{
    public class User : KeyedEntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public PersonalData PersonalData { get; set; }
        public long PersonalDataId { get; set; }
        public Role Role { get; set; }
        public long RoleId { get; set; }
        public string Email { get; set; }
    }
}
