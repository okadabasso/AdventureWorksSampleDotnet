namespace AdventureWorksSample1.Models4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class table2
    {
        public long id { get; set; }

        [Required]
        [StringLength(256)]
        public string name { get; set; }

        [ForeignKey("table1")]
        public long? table1_id { get; set; }

        [Association("table1","table1_id","id",IsForeignKey = true)]
        public virtual table1 table1 { get; set; }
    }
}
