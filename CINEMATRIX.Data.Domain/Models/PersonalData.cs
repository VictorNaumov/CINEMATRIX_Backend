namespace CINEMATRIX.Data.Domain.Models
{
    public class PersonalData : KeyedEntityBase
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string DateOfBirth { get; set; }
        public Phone Phones { get; set; }
        public long? PhoneId { get; set; }
    }
}
