using main;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace main
{
    class accessContext:DbContext
    {
        public accessContext() : base("name=mobilesdbs")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Student & StudentAddress entity
            modelBuilder.Entity<accessierdetaile>()
                        .HasOptional(s => s.Accessierimages) // Mark Address property optional in Student entity
                        .WithRequired(ad => ad.Accessierdetaile);
            modelBuilder.Entity<mobildetaile>().HasMany(t => t.Bills).WithMany(t => t.Mobildetailes).Map(m =>
            {
                m.ToTable("mobildetaileBills");
                m.MapLeftKey("idmob");
                m.MapRightKey("idbillmob");
            });
            modelBuilder.Entity<accessierdetaile>().HasMany(t => t.Bills).WithMany(t => t.Accessierdetailes).Map(m =>
            {
                m.ToTable("accessierdetaileBills");
                m.MapLeftKey("idaccess");
                m.MapRightKey("idbillaccess");
            });
        }
        
        public DbSet<accessierdetaile> accdetailes { get; set; }
        public DbSet<accessierimages> accimages { get; set; }
       
        public DbSet<mobildetaile> mobdetailes { get; set; }
        public DbSet<mobile_images> mobimages { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        //public  DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<CustomerProduct> customerProducts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public DbSet<user> Users { get; set; }

    }
}
