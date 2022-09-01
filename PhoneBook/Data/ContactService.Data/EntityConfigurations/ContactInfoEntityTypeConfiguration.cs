using ContactService.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService.Data.EntityConfigurations
{
    public class ContactInfoEntityTypeConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        { 
            builder.HasKey(c => c.Id); 
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(c => c.InfoContent).HasMaxLength(300).IsRequired();
        }
    }
}
