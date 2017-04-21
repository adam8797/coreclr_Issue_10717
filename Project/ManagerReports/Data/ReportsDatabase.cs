using System;
using System.Data.Entity;

namespace ManagerReports.Data
{
    public class ReportsDatabase : DbContext
    {
        public ReportsDatabase(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<IncidentReport> IncidentReports { get; set; }

        public DbSet<InvolvedPerson> InvolvedPersons { get; set; }

        public DbSet<ManagerReport> ManagerReports { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentNote> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentReport>()
                .HasMany(x => x.InvolvedPersons)
                .WithMany(x => x.InvolvedReports);

            modelBuilder.Entity<RacingFormSalesNote>();
        }
    }
}
