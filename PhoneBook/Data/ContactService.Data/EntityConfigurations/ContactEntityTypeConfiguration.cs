using ContactService.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ContactService.Data.EntityConfigurations
{
    public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        { 
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Surname).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Company).HasMaxLength(100).IsRequired();
            builder.HasMany(c => c.ContactInfo).WithOne(e => e.Contact).HasForeignKey(f => f.ContactId); // Birden çoğa bağlantı kurmak için eklenmiştir.
        }
    }
}
