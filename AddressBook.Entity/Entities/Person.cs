using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Core.Entities;

namespace AddressBook.Entity.Entities
{
    public class Person : EntitiyBase
    {
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Guid PositionId { get; set; }
        public Guid AddressId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid PhoneId { get; set; }
        public Guid EmailId { get; set; }
        public DateTime HireDate { get; set; }

        // Navigation properties
        public Position Position { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }
        public PhoneNumber Phone { get; set; }
        public Email Email { get; set; }
    }
}
