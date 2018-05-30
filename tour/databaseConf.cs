using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
   public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DBConnection")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PayStatus> PayStatuses { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().Property(c => c.LastName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.SecondName).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.Email).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.Gender).HasMaxLength(50);
            modelBuilder.Entity<Complain>().Property(c => c.Text).HasMaxLength(200);
            modelBuilder.Entity<CType>().Property(c => c.Type).HasMaxLength(50);
            modelBuilder.Entity<Doc>().Property(d => d.DocName).HasMaxLength(100);
            modelBuilder.Entity<PayStatus>().Property(p=>p.PStatusName).HasMaxLength(50);
            base.OnModelCreating(modelBuilder);

        }
    }
}
