using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Department : EntitiyBase
    {
        public string DepartmentName { get; set; }

        // Navigation property
        public ICollection<Position> Positions { get; set; }
        
    }
}
