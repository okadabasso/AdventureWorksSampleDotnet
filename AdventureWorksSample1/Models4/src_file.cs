namespace AdventureWorksSample1.Models4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class src_file
    {
        public int id { get; set; }

        [StringLength(1024)]
        public string directory_name { get; set; }

        [StringLength(1024)]
        public string source_file_name { get; set; }
    }
}
