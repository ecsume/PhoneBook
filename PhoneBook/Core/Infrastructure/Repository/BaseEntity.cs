using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public abstract class BaseEntity //Newlerek kullanılamaz,sadece buradan kalıtım alınır.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModificationDate { get; set; } = DateTime.Now; 
    }
}
