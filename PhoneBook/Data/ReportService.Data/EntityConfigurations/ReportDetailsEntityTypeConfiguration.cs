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
    public class ReportDetailsEntityTypeConfiguration : IEntityTypeConfiguration<ReportDetails>
    {
        public void Configure(EntityTypeBuilder<ReportDetails> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ContactCount).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired(); 
        }
    }
}
