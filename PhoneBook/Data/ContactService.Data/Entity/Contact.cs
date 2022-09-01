using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService.Data.Entity
{
    public class Contact : BaseEntity
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; } 
        public ICollection<ContactInfo>  ContactInfo { get; set; }
    }
}
