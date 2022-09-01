using ReportService.Data.Context;
using ReportService.Data.Entity;
using Microsoft.EntityFrameworkCore;
using ReportService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReportService.Data.Context
{
    public class ReportContext : DbContext
    {
        public ReportContext(DbContextOptions<ReportContext> options) : base(options)
        {

        }
        public DbSet<Report> Report { get; set; }
        public DbSet<ReportDetails> ReportDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) // Veritabanı ayağa kalkarken kullanılan bölüm
        {
            //builder.ApplyConfiguration(new ReporttEntityTypeConfiguration());
            //builder.ApplyConfiguration(new ReportDetailsInfoEntityTypeConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ReportContext).Assembly);
        }
    }
}
