using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.sample_table1")]
    public partial class SampleTable1
    {
        public SampleTable1()
        {
            Id = 0;
            Name = null;

        }

        ///<summary>column:id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long Id { get; set; }

        ///<summary>column:name</summary>
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

    }
}
