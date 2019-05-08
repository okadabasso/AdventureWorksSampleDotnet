using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table3")]
    public partial class Table3
    {
        public Table3()
        {
            Id = 0;
            Name = null;
            Table1Id = 0;

        }

        ///<summary>id</summary>
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        ///<summary>name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

        ///<summary>table1_id</summary>
        [Column("table1_id")]
        public long Table1Id { get; set; }

        public virtual Table1 Table1 { get; set; }

    }
}
