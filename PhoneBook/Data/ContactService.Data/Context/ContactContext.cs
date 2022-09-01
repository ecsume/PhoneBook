using ContactService.Data.Entity; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService.Data.Context
{
    public class ContactContext : DbContext
    {  
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) // Veritabanı ayağa kalkarken kullanılan bölüm
        {
            //builder.ApplyConfiguration(new ContactEntityTypeConfiguration());
            //builder.ApplyConfiguration(new ContactInfoEntityTypeConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ContactContext).Assembly);
        }
    }
}
