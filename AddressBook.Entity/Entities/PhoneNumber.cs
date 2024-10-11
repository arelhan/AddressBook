using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class PhoneNumber : EntitiyBase
    {
        public string PhoneNumberValue { get; set; }
        public string PhoneType { get; set; }
    }
}
