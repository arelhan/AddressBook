using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Department : EntitiyBase
    {
        public string DepartmentName { get; set; }
        public Guid CompanyId { get; set; }
        
    }
}
