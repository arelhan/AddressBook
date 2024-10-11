using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Company : EntitiyBase
    {
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public Guid AddressId { get; set; }
    }
}
