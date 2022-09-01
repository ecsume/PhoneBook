using ReportService.Data.Entity;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.Data.Entity
{
    public class Report : BaseEntity
    { 
        public DateTime ReportRequestDate { get; set; } = DateTime.Now;
        public string ReportStatus { get; set; }
    }
}
