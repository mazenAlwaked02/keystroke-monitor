using KeystrokeMonitor.DataAccess.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KeystrokeMonitor.DataAccess
{
    public partial class KeystrokeMonitorDBContext : DbContext
    {
        public KeystrokeMonitorDBContext()
            : base("name=KeystrokeMonitorDBContext")
        {
        }

        public virtual DbSet<BlackListWord> BlackListWords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
