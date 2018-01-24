namespace EntityFramework01
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StaffContext : DbContext
    {
        public StaffContext()
            : base("name=StaffContext")
        {
            
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<TimeReport> TimeReport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.ProjectName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TimeReport>()
                .Property(e => e.Hours)
                .HasPrecision(18, 0);
        }
    }
}
