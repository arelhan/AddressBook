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

    }
}
