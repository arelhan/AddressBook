using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Position : EntitiyBase
    {
        public string PositionTitle { get; set; }
        public Guid DepartmentId { get; set; }

    }
}
