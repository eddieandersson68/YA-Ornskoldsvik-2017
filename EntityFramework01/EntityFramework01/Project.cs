namespace EntityFramework01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            TimeReport = new HashSet<TimeReport>();
        }

        [Key]
        public short Project_ID { get; set; }

        [StringLength(25)]
        public string ProjectName { get; set; }

        public byte? StartDate { get; set; }

        public byte? EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeReport> TimeReport { get; set; }
    }
}
