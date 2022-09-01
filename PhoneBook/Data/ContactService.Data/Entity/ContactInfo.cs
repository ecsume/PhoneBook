using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService.Data.Entity
{
    public class ContactInfo : BaseEntity
    { 
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string InfoContent { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
