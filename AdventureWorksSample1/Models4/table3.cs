namespace AdventureWorksSample1.Models4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class table3
    {
        public long id { get; set; }

        [Required]
        [StringLength(256)]
        public string name { get; set; }

        public long table1_id { get; set; }

        public virtual table1 table1 { get; set; }
    }
}
