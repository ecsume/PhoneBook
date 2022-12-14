using ReportService.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportService.Data.Entity;

namespace ReportService.Data.EntityConfigurations
{ 
    public class ReportEntityTypeConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReportStatus).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ReportRequestDate).IsRequired();  
        }
    }
}
