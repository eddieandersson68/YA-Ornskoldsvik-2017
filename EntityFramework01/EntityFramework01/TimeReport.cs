namespace EntityFramework01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeReport")]
    public partial class TimeReport
    {
        [Key]
        public short TimeReport_ID { get; set; }

        public short? Person_ID { get; set; }

        public short? Project_ID { get; set; }

        public byte? WeekNr { get; set; }

        public decimal? Hours { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Project Project { get; set; }
    }
}
