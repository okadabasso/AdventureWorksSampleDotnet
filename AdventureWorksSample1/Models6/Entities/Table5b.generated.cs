using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace AdventureWorks1.Models6
{
    [Table("dbo.table5b")]
    public partial class Table5b
    {
        public Table5b()
        {
            Key1 = 0;
            Name = null;

        }

        ///<summary>column:key1</summary>
        [Key]
        [Column("key1", Order = 0, TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key1 { get; set; }

        ///<summary>column:name</summary>
        [Required]
        [Column("name", Order = 1, TypeName = "nvarchar")]
        public string Name { get; set; }

    }
}
