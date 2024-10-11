using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class City : EntitiyBase
    {
        public string CityName { get; set; }
        public Guid CountryId { get; set; }
    }
}
