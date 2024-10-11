using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class City : EntitiyBase
    {
        public string CityName { get; set; }

        // Navigation property
        public Country Country { get; set; }
    }
}
