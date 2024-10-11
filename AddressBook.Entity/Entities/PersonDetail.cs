using AddressBook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Entity.Entities
{
    public class PersonDetail : EntitiyBase
    {
        public Guid PersonId { get; set; }
        public Guid PositionId { get; set; }
        public Guid AddressId { get; set; }
        public Guid PhoneId { get; set; }
        public Guid EmailId { get; set; }

    }
}
