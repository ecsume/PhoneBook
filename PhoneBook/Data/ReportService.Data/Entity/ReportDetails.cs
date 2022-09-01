using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.Data.Entity
{
    public class ReportDetails : BaseEntity
    {  
        public int PhoneNumberCount { get; set; } 
        public int ContactCount { get; set; } 
        public Report Report { get; set; }
    }
}
