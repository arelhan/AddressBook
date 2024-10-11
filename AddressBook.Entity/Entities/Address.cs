using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Address : EntitiyBase
    {
        public string Street { get; set; }
        public Guid CityId { get; set; }
        public string PostalCode { get; set; }

        // Navigation properties
        public City City { get; set; }
    }
}
