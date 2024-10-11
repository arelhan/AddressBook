using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Entities
{
    public abstract class EntitiyBase : IEntityBase
    {
        [Key]
        public virtual Guid Id { get; set; } = Guid.NewGuid(); // Common identifier for all entities
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual bool IsActive { get; set; } = true; // Active/Inactive flag
    }
}
