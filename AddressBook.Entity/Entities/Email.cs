using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Email : EntitiyBase
    {
        public string EmailAddress { get; set; }
        public string EmailType { get; set; }
    }
}
